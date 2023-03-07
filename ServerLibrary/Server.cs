using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ServerLibrary
{
    public class Server
    {
        public static Server Instance { get; private set; }
        public EndPoint EndPoint => _tcpListener.LocalEndpoint;
        public event Action Started;
        public event Action Stopped;
        public delegate void MessageHandler(string message);
        public event MessageHandler MessageSented;
        
        private TcpListener _tcpListener;
        private List<Connection> _connections;

        public Server(TcpListener tcpListener)
        {
            _tcpListener = tcpListener;
            _connections = new List<Connection>();
            Instance = this;
        }


        public async Task ListenAsync()
        {
            try
            {
                _tcpListener.Start();
                Started?.Invoke();
                while (true)
                {
                    TcpClient tcpClient = await _tcpListener.AcceptTcpClientAsync();
                    var connection = new Connection(tcpClient);
                    _connections.Add(connection);
                    Task.Run(connection.ProcessAsync);
                }
            }
            finally
            {
                Disconnect();
            }
        }

        public void Disconnect()
        {
            foreach (var connection in _connections)
            {
                connection.Close();
            }
            _tcpListener.Stop();
            Stopped?.Invoke();
        }
        
        public async Task ConnectMessageAsync(string connectionId)
        {
            if (TryFindConnection(connectionId, out Connection client))
            {
                string message = $"{DateTime.Now:[HH:mm:ss]}\t{client.UserName}\tConnect with server";
                await BroadcastAsync(message);
            }
        }
        
        public async Task DisconnectMessageAsync(string connectionId)
        {
            if (TryFindConnection(connectionId, out Connection client))
            {
                string message = $"{DateTime.Now:[HH:mm:ss]}\t{client.UserName}\tDisconnect with server";
                await BroadcastAsync(message);
            }
        }
        
        public async Task MessageAsync(string message, string connectionId)
        {
            if (TryFindConnection(connectionId, out Connection client))
            {
                message = $"{DateTime.Now:[HH:mm:ss]}\t{client.UserName}:\n{message}";
                await BroadcastAsync(message);
            }
        }

        public void CheckConnections()
        {
            foreach (var connection in _connections.Where(connection => connection.Connected == false))
            {
                _connections.Remove(connection);
            }
        }

        private bool TryFindConnection(string connectionId, out Connection connection)
        {
            connection = _connections.FirstOrDefault(c => c.Id == connectionId);
            return connection != null;
        }
        
        private async Task BroadcastAsync(string message)
        {
            CheckConnections();
            foreach (var client in  _connections)
            {
                await client.Writer.WriteLineAsync(message);
                await client.Writer.FlushAsync();
            }
            MessageSented?.Invoke(message);
        }
    }
}