using System.Collections.Generic;
using Transportation.Transport;
using Transportation.Vehicle;

namespace Transportation.TransportationFactory
{
    public abstract class TransportationsFactory
    {
        public abstract IVehicle VehicleIsReadyToGo(string carNumber, List<Passenger> passengers, Driver driver);
    }
}
