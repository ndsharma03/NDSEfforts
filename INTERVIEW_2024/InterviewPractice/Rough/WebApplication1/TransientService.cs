namespace WebApplication1
{
    public interface ITransientService
    {
        void Print(string message);
    }
    public class TransientService:ITransientService
    {
        public TransientService()
        {
            Console.WriteLine("Transient Service ctor");
        }
        public void Print(string message) { Console.WriteLine(message); }
    }
}
