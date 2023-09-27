using System;
using System.Collections.Generic;
using Transportation.Transport;
using Transportation.TransportationFactory;

namespace Transportation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Eric", Driver.LicenseCategorys.D);
           
            List<Passenger> passengers = new List<Passenger>
            {
                new Passenger("Ember", 31, false),
                new Passenger("Mary", 10, false),
                new Passenger("Adam", 65, true),
                new Passenger("Vittorino", 35, false),

            };

            TransportationsFactory busFactory = new BusFactory();
            var bus = busFactory.VehicleIsReadyToGo("AA1234BC", passengers, driver1);
            Console.WriteLine(busFactory.VehicleIsReadyToGo("AA1234BC", passengers, driver1));

            Driver driver2 = new Driver("Itan", Driver.LicenseCategorys.B);
            TransportationsFactory taxiFactory = new TaxiFactory();
            var taxi = taxiFactory.VehicleIsReadyToGo("AA1234BC", passengers, driver2);
            Console.WriteLine(taxiFactory.VehicleIsReadyToGo("AA1234BC", passengers, driver2));
            Console.ReadKey();

        }
    }
}
