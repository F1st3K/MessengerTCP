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
            var tcpListener = new TcpListener(IPAddress.Any, 0);
            var server = new Server(tcpListener);
            
            server.Started += () => 
                Console.WriteLine($"ServerLibrary is running on {server.EndPoint}");
            
            server.Stopped += () => 
                Console.WriteLine($"ServerLibrary is stopped");
            
            server.MessageSented += message => 
                Console.WriteLine($"|{DateTime.Now}|=>\t{message}");

            Console.CancelKeyPress += (sender, eventArgs) => 
                server.Disconnect();
            
            await server.ListenAsync();
        }
    }
}