using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ClientLibrary
{
    public class Client
    {
        private TcpClient _tcpClient;
        private StreamWriter _writer;
        private StreamReader _reader;
        private string _username;
        
        public delegate void MessageHandler(string message);
        public event MessageHandler MessageReceive;
        
        public Client(TcpClient tcpClient, string username)
        {
            _tcpClient = tcpClient;
            _username = username;
            _writer = new StreamWriter(_tcpClient.GetStream());
            _reader = new StreamReader(_tcpClient.GetStream());
        }
        
        public async void SendMessageAsync(string message)
        {
            await _writer.WriteLineAsync(message);
            await _writer.FlushAsync();
        }
        
        public async Task ReceiveMessageAsync()
        {
            SendMessageAsync(_username);
            while (true)
            {
                if (_reader.EndOfStream)
                    continue;
                string message = await _reader.ReadLineAsync();
                MessageReceive?.Invoke(message);
            }
        }

        public void Disconnect()
        {
            _tcpClient.Close();
        }
    }
}