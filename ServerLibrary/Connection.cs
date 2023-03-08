using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ServerLibrary
{
    public class Connection
    {
        private TcpClient _tcpClient;
        
        public Connection(TcpClient tcpClient)
        {
            Id = Guid.NewGuid().ToString();
            _tcpClient = tcpClient;
            Writer = new StreamWriter(_tcpClient.GetStream());
            Reader = new StreamReader(_tcpClient.GetStream());
        }

        protected internal string Id { get;}
        
        protected internal string UserName { get; private set; }
        
        protected internal StreamWriter Writer { get;}
        
        protected internal StreamReader Reader { get;}

        protected internal bool Connected => _tcpClient.Connected;
        
        public async Task ProcessAsync()
        {
            UserName = await Reader.ReadLineAsync();
            await Server.Instance.ConnectMessageAsync(Id);
            while (true)
            {
                string message = await Reader.ReadLineAsync();
                if (message is null)
                {
                    await Server.Instance.DisconnectMessageAsync(Id);
                    Server.Instance.Remove(this);
                    break;
                }

                await Server.Instance.MessageAsync(message, Id);
            }
        }

        public void Close()
        {
            _tcpClient.Close();
        }

    }
}