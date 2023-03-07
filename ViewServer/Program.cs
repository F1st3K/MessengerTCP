using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using ServerLibrary;

namespace ViewServer
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
            var server = new Server(tcpListener);
            
            server.Started += () => 
                Console.WriteLine($"Server is running on {server.EndPoint}");
            
            server.Stopped += () => 
                Console.WriteLine($"Server is stopped");
            
            server.MessageSented += message => 
                Console.WriteLine($"|{DateTime.Now}|->\t{message}");

            Console.CancelKeyPress += (sender, eventArgs) => 
                server.Disconnect();

            await server.ListenAsync();
        }
    }
}