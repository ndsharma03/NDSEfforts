using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class AbstractFactoryPattern
    {

        public static void Main()
        {
            IScooter scooter = new HeroFactory().GetScooter();
            Console.WriteLine("Scooter Name =" + scooter.GetName);

            IBike bike = new HeroFactory().GetBike();
            Console.WriteLine("Bike Name =" + bike.GetName);

             scooter = new BajajFactory().GetScooter();
            Console.WriteLine("Scooter Name =" + scooter.GetName);

             bike = new BajajFactory().GetBike();
            Console.WriteLine("Bike Name =" + bike.GetName);

            Console.Read();
        }
    }

    public interface I2Wheeler { void Accelerate(); }

    public interface IScooter : I2Wheeler
    {
        string GetName { get; }
    }
    public interface IBike : I2Wheeler { string GetName { get; } }
    public class HeroScooter : IScooter
    {
        public string GetName
        {
            get { return "HeroScooter"; }
        }
        public void Accelerate()
        {
           
        }
    }
    public class BajajScooter : IScooter
    {
        public string GetName
        {
            get { return "BajajScooter"; }
        }
        public void Accelerate()
        {

        }
    }
    public class BajajBike : IBike
    {
        public string GetName
        {
            get { return "BajajBike"; }
        }
        public void Accelerate()
        {

        }
    }
    public class HeroBike : IBike
    {
        public string GetName
        {
            get { return "HeroBike"; }
        }
        public void Accelerate()
        {

        }
    }
  

    public interface I2WheelerFactory
    {
         IScooter GetScooter();
         IBike GetBike();
    }

    public class HeroFactory : I2WheelerFactory
    {

        IBike bike;
        IScooter scooter;
        public IBike GetBike()
        {
            bike = new HeroBike();
            return bike;
        }

        public IScooter GetScooter()
        {
            scooter = new HeroScooter();
            return scooter;

        }
    }
    public class BajajFactory : I2WheelerFactory
    {

        IBike bike;
        IScooter scooter;
        public IBike GetBike()
        {
            bike = new BajajBike();
            return bike;
        }

        public IScooter GetScooter()
        {
            scooter = new BajajScooter();
            return scooter;

        }
    }


}
