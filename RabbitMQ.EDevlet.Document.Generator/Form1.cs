using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQ.EDevlet.Document.Generator
{
    public partial class Form1 : Form
    {
        IConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(connection == null || !connection.IsOpen)
                connection = GetConnection();

            btnCreateDocument.Enabled = true;

            AddLog("Connection is open");
        }

        private IConnection GetConnection()
        {
            var connFactory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnect.Text)
            };
            return connFactory.CreateConnection();
        }

        private void AddLog(string logString)
        {
            logString = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logString}";
            txtLog.AppendText($"{logString}\n");

            // set the cursor to end
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void txtConnect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
