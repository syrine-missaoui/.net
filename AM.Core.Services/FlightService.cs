using System.Reflection;
using AM.Core.Domain;

namespace AM.Core.Services
{
    public class FlightService:IFlightService
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates= new List<DateTime>();
            foreach(var flight in Flights)
            {
                if (flight.Destination == destination) {

                    dates.Add(flight.FlightDate);
                }
            }
            return dates;
        }

        public void GetFlights(string filterType, string filterValue)
        {
            PropertyInfo  p;
            foreach(PropertyInfo prop in typeof(Flight).GetProperties()) {
            
                if(prop.Name== filterType)
                {
                    p= prop;
                }
                
            }
            List<Flight> listflight= new List<Flight>();
            foreach(Flight f in listflight) {

                if (f.Destination == filterValue) {
                
                    listflight.Add(f);
                }
                Console.WriteLine(listflight);
            }
        }

       


        //TP2.Q7
        public void ShowFlightDetails(Plane p)
        {
            //Methode Extension
            Console.WriteLine(Flights.Where(f => f.MyPlane.PlaneId ==p.PlaneId)
                .Select(f => f.Destination + " " + f.FlightDate));
            //Methode LINQ Intégré
            var result = from f in Flights
                         where f.MyPlane.PlaneId == p.PlaneId
                         select new { f.Destination, f.FlightDate };
            foreach(var r in result)
            {
                Console.WriteLine(r.Destination + " " + r.FlightDate);
            }
        }

        //TP2.Q8
        public int GetWeeklyFlightNumber(DateTime date)
        {
            return Flights.Where(f => f.FlightDate>=date 
            && f.FlightDate<date.AddDays(7))
                .Count();
        }

        //TP2.Q9
        public double GetDurationAverage(string destination)
        {
            return Flights.Where(f => f.Destination == destination)
                .Average(f => f.EstimatedDuration);
        }

        //TP2.Q10
        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(f => f.EstimatedDuration).ToList();
        }

        //TP2.Q11
        public IList<Passenger> GetThreeOlderTravellers(Flight f)
        {
            return f.Passengers.OrderByDescending(p => p.Age).Take(3).ToList();
        }

        public void ShowGroupedFlights()
        {
            var result = from f in Flights
                         group f by f.Destination;

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach(var f in group)
                {
                    Console.WriteLine(f);
                }
            }
        }

        //TP2.Q13.b
        public Passenger GetSeniorPassenger(IFlightService.GetScore meth)
        {

            //return Flights.Select(f => f.Passengers.MaxBy(p => meth(p)))
              //  .MaxBy(p => meth(p));
            return Flights.SelectMany(f =>f.Passengers).MaxBy(p => meth(p));
            //Select Many puts the list of lists in a single list 
        }
    }
}