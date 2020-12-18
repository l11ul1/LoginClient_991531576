using LoginClient_991531576.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClient_991531576
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationUserClient client = new AuthenticationUserClient("NetTcpBinding_AuthenticationUser");
            string username = textBox1.Text.ToString();
            string pass = textBox2.Text.ToString();
            label2.Text = client.Validate(username, pass);

        }
    }
}
