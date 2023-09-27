using System.CodeDom;
using System.Collections.Generic;
using Transportation.Vehicle;

namespace Transportation.Transport
{
    public class Taxi : IVehicle
    {
        private int _capacity = 4;
        public string CarNumber { get;  set; }
        public List<Passenger> Passengers { get; set; }
        public Driver Driver { get; set; }

        public Taxi(string carNumber, List<Passenger> рassengers, Driver driver) 
        {
            CarNumber = carNumber;
            Passengers = рassengers;
            Driver = driver;    
        }
      
        public string InstallationOfChildSeats()
        {
            int amountOfChildren = 0;
            foreach (var p in Passengers)
            {
                if (p.Age <= 12)
                {
                    amountOfChildren++;
                }
            }
            return $"Instal {amountOfChildren} chealdren car seats";
        }
        public bool CanDepart()
        {
            return Passengers.Count > 0 && Passengers.Count <= _capacity && Driver.LicenseCategory == Driver.LicenseCategorys.B;
        }
        public override string ToString()
        {
            return $"Taxi on the road:\nNumber: {CarNumber}\nDriver: {Driver}\nInformation:\n{InstallationOfChildSeats()}\n";
        }
    }
}
