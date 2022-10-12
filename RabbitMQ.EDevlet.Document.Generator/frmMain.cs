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
using EDevlet.Document.Common;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;

namespace RabbitMQ.EDevlet.Document.Generator
{
    public partial class frmMain : Form
    {
        IConnection connection;
        private readonly string createDocument = "create_document_queue";
        private readonly string documentCreated = "document_created_queue";
        private readonly string documentCreateExchange = "document_create_exchange";

        IModel _channel;

        IModel channel => _channel ?? (_channel = GetChannel());

        frmSplash frmSplash = new frmSplash();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(connection == null || !connection.IsOpen)
                connection = GetConnection();

            btnCreateDocument.Enabled = true;

            channel.ExchangeDeclare(documentCreateExchange, "direct");
            channel.QueueDeclare(createDocument, false, false, false);
            channel.QueueBind(createDocument, documentCreateExchange, createDocument);
            channel.QueueDeclare(documentCreated, false, false, false);
            channel.QueueBind(documentCreated, documentCreateExchange, documentCreated);

            AddLog("Connection is open");
        }


     
        private void btnCreateDocument_Click(object sender, EventArgs e)
        {
            var model = new DocumentCreateModel()
            {
                UserId = 1,
                url = "www.eneceb.com",
                DocumentType = DocumentType.Pdf
            };
            WriteToQueue(createDocument, model);

        
            frmSplash.Show();

            var consumerEvent = new EventingBasicConsumer(channel);

            consumerEvent.Received += ConsumerEvent_Received;

            channel.BasicConsume(documentCreated, true, consumerEvent);
        }

        private void ConsumerEvent_Received(object sender, BasicDeliverEventArgs e)
        {
            var model = JsonConvert.DeserializeObject<DocumentCreateModel>(Encoding.UTF8.GetString(e.Body.ToArray()));
            AddLog($"Recived Data URL: {model.url}");

            closeSplashScreen(frmSplash);
        }

        private void closeSplashScreen(frmSplash frmSplash)
        {
            if (frmSplash.InvokeRequired)
            {
                    frmSplash.Invoke(new Action(() => closeSplashScreen(frmSplash)));
                return;
            }
            frmSplash.Close();  
        }

        private void WriteToQueue(string QueueName, DocumentCreateModel model)
        {
            var messageArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(model));

            channel.BasicPublish(documentCreateExchange, QueueName, null, messageArr);

            AddLog("message published");
        }

        private IConnection GetConnection()
        {
            var connFactory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnect.Text)
            };
            return connFactory.CreateConnection();
        }

        private IModel GetChannel()
        {
            return connection.CreateModel();
        }

        private void AddLog(string logString)
        {
            logString = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logString}";
            txtLog.AppendText($"{logString}\n");

            // set the cursor to end
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

       

    }
}
