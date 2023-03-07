using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void _buttonDisconnect_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ConnectionForm();
            form.Show();
        }
    }
}
