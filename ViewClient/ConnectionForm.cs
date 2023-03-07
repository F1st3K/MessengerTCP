using System;
using System.Net;
using System.Windows.Forms;

namespace ViewClient
{
    public partial class ConnectionForm : Form
    {
        private IPAddress _ipAddress;
        private int _port;
        private string _username;

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void _buttonExit_Click(object sender, System.EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void _buttonConnect_Click(object sender, System.EventArgs e)
        {
            if (IPAddress.TryParse(_textIPAdress.Text, out _ipAddress) == false)
            {
                MessageBox.Show("Invalid IP!!!");
                return;
            }
            if (int.TryParse(_textPort.Text, out _port) == false ||
                (_port > 65535 || _port < 0))
            {
                MessageBox.Show("Invalid port!!!");
                return;
            }
            if ((_username = _textUserName.Text).Length > 20)
            {
                MessageBox.Show("Invalid username (>20)!!!");
                return;
            }
            Hide();
            var form = new ClientForm();
            form.Show();
        }

        
    }
}