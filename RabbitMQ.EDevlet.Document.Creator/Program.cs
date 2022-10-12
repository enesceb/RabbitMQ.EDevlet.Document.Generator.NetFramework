using EDevlet.Document.Common;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.EDevlet.Document.Creator
{
    internal class Program
    {

        static IConnection connection;
        private static readonly string createDocument = "create_document_queue";
        private static readonly string documentCreated = "document_created_queue";
        private static readonly string documentCreateExchange = "document_create_exchange";

         static IModel _channel;

         static IModel channel => _channel ?? (_channel = GetChannel());

      

        static void Main(string[] args)
        {
            connection = GetConnection();

            channel.ExchangeDeclare(documentCreateExchange, "direct");
            channel.QueueDeclare(createDocument, false, false, false);
            channel.QueueBind(createDocument, documentCreateExchange, createDocument);
            channel.QueueDeclare(documentCreated, false, false, false);
            channel.QueueBind(documentCreated, documentCreateExchange, documentCreated);


            var consumerEvent = new EventingBasicConsumer(channel);

            consumerEvent.Received += ConsumerEvent_Received;

            channel.BasicConsume(createDocument, true, consumerEvent);

            Console.WriteLine($"Exchange: {documentCreateExchange} listening");

            Console.ReadLine();

        }


        private static void ConsumerEvent_Received(object sender, BasicDeliverEventArgs e)
        {
            var modelJson = Encoding.UTF8.GetString(e.Body.ToArray());
            var model = JsonConvert.DeserializeObject<DocumentCreateModel>(modelJson);
            Console.WriteLine($"Recived Data URL: {modelJson}");
            
            Task.Delay(2000).GetAwaiter().GetResult();

           
            model.url = "http://www.turkiye.gov.tr/docs/x.pdf";

            WriteToQueue(documentCreated, model);

            
            
        }


        private static void WriteToQueue(string QueueName, DocumentCreateModel model)
        {
            var messageArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(model));

            channel.BasicPublish(documentCreateExchange, QueueName, null, messageArr);

            Console.WriteLine("message published");
        }

        private static IConnection GetConnection()
        {
            var connFactory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            return connFactory.CreateConnection();
        }

        private static IModel GetChannel()
        {
            return connection.CreateModel();
        }

   
    }
}
