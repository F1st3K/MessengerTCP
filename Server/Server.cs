using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private TcpListener _tcpListener;
        private List<ClientObject> _clients;

        public Server(TcpListener tcpListener)
        {
            _tcpListener = tcpListener;
            _clients = new List<ClientObject>();
        }

        public async Task ListenAsync()
        {
            try
            {
                _tcpListener.Start();
 
                while (true)
                {
                    TcpClient tcpClient = await _tcpListener.AcceptTcpClientAsync();
                    var clientObject = new ClientObject(tcpClient);
                    var reader = new StreamReader(tcpClient.GetStream());
                    clientObject.UserName = await reader.ReadLineAsync();
                    _clients.Add(clientObject);
                }
            }
            finally
            {
                Disconnect();
            }
        }

        private void Disconnect()
        {
            foreach (var client in _clients)
            {
                client.Close();
            }
            _tcpListener.Stop();
        }
    }
}