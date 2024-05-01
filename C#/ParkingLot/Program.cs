using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public enum Size { Small,Medium,Large};

    public interface IVehicle
    {
        string RegistrationNo { get; set; }
        string Make { get; set; }
        string Color { get; set; }
    }
    public class Bike : IVehicle
    {
        public string RegistrationNo { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
    }
    public class Car : IVehicle
    {
        public string RegistrationNo { get; set ; }
        public string Make { get ; set ; }
        public string Color { get ; set ; }
    }
    public class Truck : IVehicle
    {
        public string RegistrationNo { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
    }
    class ParkingLot
    {
        List<Spot> spots;
        public ParkingLot()
        {
            InitParking();
        }
        public IEnumerable<Spot> FindAllEmptySpot()
        {
            return spots.Where(s=>s.Vehical==null);
        }
        public IEnumerable<Spot> FindEmptySpaceBySize(Size size )
        {
            return spots.Where(s => s.VSize == size && s.Vehical == null);
        }
        public Spot FindEmptySpot(Size size)
        {
            return spots.Find(s => s.VSize == size && s.Vehical == null);
        }
        public Spot ParkVehical(IVehicle vehicle)
        {
            //IEnumerable<Spot> emptySpots;
            Spot _emptySpot = null;
            Spot _spot=null;
            if (vehicle is Bike)
            {
                // Spot s = new Spot { floor = "1", VSize = Size.Small };
                // emptySpots=FindEmptySpaceBySize(s);
                _emptySpot = FindEmptySpot(Size.Small);
            }
            else if (vehicle is Car)
            {
                //Spot s = new Spot { floor = "1", VSize = Size.Medium };
                //emptySpots = FindEmptySpaceBySize(s);
                _emptySpot = FindEmptySpot(Size.Medium);
            }
            else //truck
            {
                //Spot s = new Spot { floor = "1", VSize = Size.Large };
                //emptySpots = FindEmptySpaceBySize(s);
                _emptySpot= FindEmptySpot(Size.Large);
            }

            if (_emptySpot != null)
            {
               
                _emptySpot.Vehical = vehicle;

                Console.WriteLine(" Parking " + vehicle.GetType().Name+" ....");
            }
            else
            {
                throw new Exception(" Parking is full");
            }
            return _spot;
        }
        public IVehicle UnParkVehical(IVehicle vehicle)
        {
            Spot ss= spots.Find(s => s.Vehical.RegistrationNo == vehicle.RegistrationNo);
            IVehicle vehical = ss.Vehical;
            ss.Vehical = null;
            return vehicle;
        }
        private void InitParking()
        {
            spots = new List<Spot>
            {
                new Spot{ floor="1", VSize=Size.Small},
                new Spot{ floor="1", VSize=Size.Medium},
                new Spot{ floor="1", VSize=Size.Large},
            };
        }
    }
    class Spot
    {
        public string SpaceNo { get; set; }
        public string floor { get; set; }
        public Size VSize { get; set; }
        public IVehicle Vehical { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IVehicle bike = new Bike { RegistrationNo = "MH01", Color = "Red" };
                IVehicle car = new Car { RegistrationNo = "NY04", Color = "Gray" };
                IVehicle truck = new Truck { RegistrationNo = "WP04", Color = "Brown" };

                ParkingLot parkinglot = new ParkingLot();

                Console.WriteLine(" Free Spots in PArking lot =" + parkinglot.FindAllEmptySpot().Count());
                parkinglot.ParkVehical(bike);
                parkinglot.ParkVehical(car);
                parkinglot.ParkVehical(truck);

                //---------
                Console.WriteLine(" Current status of Parking lot =" + parkinglot.FindAllEmptySpot().Count());
                Console.WriteLine("Taking bike from PArking...");
                IVehicle vehicle= parkinglot.UnParkVehical(bike);
                Console.WriteLine("Going back to home by my Vehicle :"+vehicle.RegistrationNo);
                Console.WriteLine(" Current status of Parking lot =" + parkinglot.FindAllEmptySpot().Count());
                parkinglot.ParkVehical(bike);
                Console.WriteLine(" Current status of Parking lot =" + parkinglot.FindAllEmptySpot().Count());
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.Read();

        }
    }
}
