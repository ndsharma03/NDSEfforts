namespace RateLimitterTEst
{
    public interface ISingleton
    {
        void SingltonMethod();
    }
    public class Singleton : ISingleton
    {
        public Singleton(ITransient trnasient)
        {
            Console.WriteLine("Singleton ctor called");
            Transient = trnasient;
        }

        public ITransient Transient { get; }

        public void SingltonMethod()
        {
            Console.WriteLine("Singleton Method");
            Console.WriteLine("  Transient instance Id :" + Transient.GetHashCode());
        }
    }

    public interface ITransient
    {
        void TransientMethod();
    }
    public class Transient : ITransient
    {
        public Transient()
        {
            Console.WriteLine("Transient ctor called");
        }
        public void TransientMethod()
        {
            Console.WriteLine("Transient Method");
        }
    }

    public interface ITransientA
    {
        void TransientMethod();
    }
    public class TransientA : ITransientA
    {
        private readonly ITransient trns;

        public TransientA()//(ITransient trns)
        {
            Console.WriteLine("TransientA ctor called");
            //this.trns = trns;
        }
        public void TransientMethod()
        {
            Console.WriteLine("Transient A Method");
            //trns.TransientMethod();
        }
    }
}
