namespace MiddlewareTest.Services
{public interface IScopedServiceClass
    {
       Task DoSomething(string msg) ;
    }
    public class ScopedServiceClass : IScopedServiceClass
    {
        public ScopedServiceClass()
        {
            Console.WriteLine(" @@@@@@@@@ : ScopedServiceClass :Instance created!, hashcode: "+this.GetHashCode());
        }
        public async Task DoSomething(string msg)
        {
            
             Console.WriteLine($"Doing Something! From -{msg}");
             await Task.Delay(1000);
        }
    }
}
