using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Controllers;
using System.Text;

namespace RabbitMQ
{
    public class Program
    {
        public static void PublishMsg()
        {
            var factory = new ConnectionFactory { HostName="localhost"};
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

           var queue= channel.QueueDeclare(queue: "myQueue",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

            var msg = "Hello from message Queue";
            var body = System.Text.Encoding.UTF8.GetBytes(msg);

            channel.BasicPublish("", "myQueue", null, body);
            Console.WriteLine(      "Message published!");
            Console.Read();

        }
        public static void Consumer()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            var queue = channel.QueueDeclare(queue: "myQueue",
                      durable: false,
                      exclusive: false,
                      autoDelete: false,
                      arguments: null);

            var cosumer = new EventingBasicConsumer(channel);
            cosumer.Received += (model, eventArgs) =>
            {
                var msg = System.Text.Encoding.UTF8.GetString(eventArgs.Body.ToArray());
                Console.WriteLine(  "Message from Queue :: "+msg);

            };
            channel.BasicConsume(cosumer, "myQueue", true);
            
        }
        public static void Main(string[] args)
        {
            Consumer();
            PublishMsg();
            //var builder = WebApplication.CreateBuilder(args);

            //// Add services to the container.

            //builder.Services.AddControllers();
            //// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            //var app = builder.Build();

            //// Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            //app.UseHttpsRedirection();

            //app.UseAuthorization();


            //app.MapControllers();

            //app.Run();
        }
    }
}