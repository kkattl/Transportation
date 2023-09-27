using System;
using System.Collections.Generic;
using Transportation.Transport;
using Transportation.Vehicle;

namespace Transportation.TransportationFactory
{
    public class TaxiFactory : TransportationsFactory
    {
        public override IVehicle VehicleIsReadyToGo(string carNumber, List<Passenger> passengers, Driver driver)
        {
            Taxi veichle = new Taxi(carNumber, passengers, driver);
           
            if (veichle.CanDepart() == true)
            {
                return veichle;
            }
            else
            {
                throw new ArgumentException("");
            }
        }
    }
}
