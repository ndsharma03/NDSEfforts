
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WebApplication1.DataContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
namespace WebApplication1
{

    interface IA
    {
        object Get(string input);
    }
    class A : IA
    {
      public  object Get(string input)
        {
            return "";
        }
    }

    class DisposeTest : IDisposable
    {
        bool idDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (idDisposed) return;
            if (disposing)
            {
                //free managed objects;
            }
            //free unmanaged object
            idDisposed = true;
        }
        ~DisposeTest()
        {
            Dispose(false);
        }
    }

    class B
    {
        public Action<string> callback { get; set; }
        public Func<int,int> accessPRivateMemeber { get; set; }
        public int Value { get; set; }
        public virtual  void m1() { Console.WriteLine(  "Base");
            Console.WriteLine(  "Hurry! I am able to access private member of a class " +accessPRivateMemeber(0));
        }


    }
    class c:B
    {
        public int MyProperty { get; set; }
        public override void m1() { Console.WriteLine("Derived"); }
    }
    public class Program
    {
        private static int i = 99;
        private static void Localfunc(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Main(string[] args)
        {

            c b = new c();
            b.callback += Localfunc;
            B objb = new B();
            objb.accessPRivateMemeber += (int fromCaller) => { return i; };

            b.m1();
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(MvcOptions =>
            {
                MvcOptions.RespectBrowserAcceptHeader = true;
                //MvcOptions.ReturnHttpNotAcceptable = true;
            }).AddXmlSerializerFormatters()
              .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            })
                ; 
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDataContext>(o =>
            {
                o.UseInMemoryDatabase("Test");
            });

            //builder.Services.AddAuthentication(x=>{ x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(op =>
            //{

            //});
            builder.Services.AddTransient<ITransientService, TransientService>();
            builder.Services.AddSingleton<ISingletonService, SingletonService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.Use(async (context, next) =>
            {
                Console.WriteLine( "Path before"+context.Request.Scheme+context.Request.Path +"="+context.Request.Path);
                Console.WriteLine(" Calling middleware");
                await next();
            });
            app.UseHttpsRedirection();
            app.Use(async (context, next) =>
            {
                var trans=  context.RequestServices.GetService<ITransientService>();
                 trans.Print("Prinitng form middleware using Transient service");

                 Console.WriteLine(" Calling middleware");
                 await next();
            });
            app.UseAuthentication();
            //app.UseAuthorization();
           var scope= app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDataContext>();
            SeedDataGenerator.Generate(context);
          
            app.MapControllers();
            app.MapFallback(async context => {
                await context.Response.WriteAsync("Routed to fallback endpoint");
            });
            app.Run();
        }
    }
}