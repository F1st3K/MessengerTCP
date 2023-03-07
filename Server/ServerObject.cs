using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
    public class ServerObject
    {
        public static ServerObject Instance { get; private set; }
        public EndPoint EndPoint => _tcpListener.LocalEndpoint;
        public event Action Started;
        public event Action Stopped;
        public delegate void MessageHandler(string message);
        public event MessageHandler MessageSented;
        
        private TcpListener _tcpListener;
        private List<ClientObject> _clients;

        public ServerObject(TcpListener tcpListener)
        {
            _tcpListener = tcpListener;
            _clients = new List<ClientObject>();
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
                    var clientObject = new ClientObject(tcpClient);
                    _clients.Add(clientObject);
                    await Task.Run(clientObject.ProcessAsync);
                }
            }
            finally
            {
                Disconnect();
            }
        }

        public void Disconnect()
        {
            foreach (var client in _clients)
            {
                client.Close();
            }
            _tcpListener.Stop();
            Stopped?.Invoke();
        }
        
        public async Task ConnectMessageAsync(string userId)
        {
            if (TryFindClient(userId, out ClientObject client))
            {
                string message = $"[{DateTime.Now}] {client.UserName}\tConnect with server";
                await BroadcastAsync(message);
            }
        }
        
        public async Task DisconnectMessageAsync(string userId)
        {
            if (TryFindClient(userId, out ClientObject client))
            {
                string message = $"[{DateTime.Now}] {client.UserName}\tDisconnect with server";
                await BroadcastAsync(message);
            }
        }
        
        public async Task MessageAsync(string message, string userId)
        {
            if (TryFindClient(userId, out ClientObject client))
            {
                message = $"[{DateTime.Now}] {client.UserName}:\t{message}";
                await BroadcastAsync(message);
                MessageSented?.Invoke(message);
            }
        }

        private bool TryFindClient(string userId, out ClientObject clientObject)
        {
            clientObject = _clients.FirstOrDefault(c => c.Id == userId);
            return clientObject != null;
        }
        
        private async Task BroadcastAsync(string message)
        {
            foreach (var client in  _clients)
            {
                await client.Writer.WriteLineAsync(message);
                await client.Writer.FlushAsync();
            }
        }
    }
}