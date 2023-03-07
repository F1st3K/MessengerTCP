using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Server;

namespace ViewServer
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var tcpListener = new TcpListener(IPAddress.Any, 0);
            var server = new ServerObject(tcpListener);
            await server.ListenAsync();
            Console.WriteLine($"Server is running on {server.EndPoint}");
            
        }
    }
}