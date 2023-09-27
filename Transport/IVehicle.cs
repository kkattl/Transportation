using System.Collections.Generic;
using Transportation.Transport;

namespace Transportation.Vehicle
{
    public interface IVehicle
    {
        string CarNumber { get; }
        List<Passenger> Passengers { get; }
        Driver Driver { get; }
        bool CanDepart();

    }
}
