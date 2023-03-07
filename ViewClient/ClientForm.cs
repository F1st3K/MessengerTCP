using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientLibrary;

namespace ViewClient
{
    public partial class ClientForm : Form
    {
        private Client _client;
        public ClientForm(Client client)
        {
            _client = client;
            client.MessageReceive += message => Display.Text += Environment.NewLine+message;
            InitializeComponent();
            Task.Run(client.ReceiveMessageAsync);
        }

        private void _buttonDisconnect_Click(object sender, EventArgs e)
        {
            _client.Disconnect();
            Hide();
            var form = new ConnectionForm();
            form.Show();
        }

        private void _buttonSend_Click(object sender, EventArgs e)
        {
            _client.SendMessageAsync(_textMessage.Text);
            _textMessage.Text = string.Empty;
        }
    }
}
