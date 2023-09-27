using System.Collections.Generic;
using Transportation.Vehicle;

namespace Transportation.Transport
{
    public class Bus : IVehicle
    {
        private readonly int _capacity = 30;
        public string CarNumber { get; set; }
        public List<Passenger> Passengers { get; set; }
        public Driver Driver { get; set;}

        public Bus(string carNumber, List<Passenger> passengers, Driver driver) 
        {
            CarNumber = carNumber;
            Passengers = passengers;
            Driver = driver;
        }
        
        public string TypeOfTicket()
        {
            int childrenTicketsCount = 0;
            int disabledPeoplesTicketsCount = 0;
            int ticketsCount = 0;
            int basePrixForOneTicket = 8;
            int prixForTicketWithDiscount = 4;

            foreach (var p in Passengers)
            {
                if (p.Age <= 12)
                {
                    childrenTicketsCount++;
                }
                else if (p.HasPreferential == true)
                {
                    disabledPeoplesTicketsCount++;
                }
                else
                {
                    ticketsCount++;
                }  
            }

            int earningsRegularTickets = ticketsCount * basePrixForOneTicket;
            int earningsDiscountrdTickets = disabledPeoplesTicketsCount * prixForTicketWithDiscount;
            int totalEarnigs = earningsRegularTickets + earningsDiscountrdTickets;

            return $"Amount of childrens: {childrenTicketsCount}\nAmount of dpreferentialed peopels: {disabledPeoplesTicketsCount}\n" +
                $"Amount of other passenger: {ticketsCount}\nEarnings from regular ticket: {earningsRegularTickets}\n" +
                $"Earnings from ticket with discount: {earningsDiscountrdTickets}\nTotal earnings: {totalEarnigs}";
        }
        
        public bool CanDepart()
        {
            return Passengers.Count > 0 && Passengers.Count <= _capacity && Driver.LicenseCategory == Driver.LicenseCategorys.D;
        }

        public override string ToString()
        {
            return $"Bus on the road:\nNumber: {CarNumber}\nDriver: {Driver}\nInformation:\n{TypeOfTicket()}\n";
        }
    }
}
