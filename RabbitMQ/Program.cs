// See https://aka.ms/new-console-template for more information
using RabbitMQ;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

Console.WriteLine("Hello, World!");

var factory = new ConnectionFactory() { HostName = "localhost"};
using (var connection = factory.CreateConnection())
using (var channel = connection.CreateModel())
{
    channel.QueueDeclare(queue: "hello",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

    int count = 0;

    string? id = Console.ReadLine();

    while(id != null)
    {
        var loan = new Loan { Id = id.ToString(), Amount = 23500.56M, RequestDate = DateTime.Now };
        var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(loan));

        channel.BasicPublish(exchange: "",
                             routingKey: "hello",
                             basicProperties: null,
                             body: body);
        Console.WriteLine(" [x] Sent {0}", JsonSerializer.Serialize(loan));
    }   
}

Console.ReadKey();