using System;
using System.Net.Sockets;

namespace Server
{
    public class ClientObject
    {
        private TcpClient _tcpClient;
        
        public ClientObject(TcpClient tcpClient)
        {
            Id = Guid.NewGuid().ToString();
            _tcpClient = tcpClient;
        }

        protected internal string Id { get;}
        
        protected internal string UserName { get; set; }


        public void Close()
        {
            _tcpClient.Close();
        }

    }
}