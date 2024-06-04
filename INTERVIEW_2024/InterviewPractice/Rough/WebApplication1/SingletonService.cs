namespace WebApplication1
{
    public interface ISingletonService
    {
        void Print(string message);
    }
    public class SingletonService:ISingletonService
    {
        private readonly ITransientService service;

        public SingletonService(ITransientService service)
        {
            Console.WriteLine("SingletonService Service ctor");
            this.service = service;
        }
        public void Print(string message) { Console.WriteLine(message);
            Console.WriteLine("using transient print()");
            service.Print("Transient in singleton");

        }
    }
}
