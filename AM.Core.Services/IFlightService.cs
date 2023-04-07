using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public interface IFlightService
    {
        //TP2.Q13.a
        public delegate int GetScore(Passenger p);
        IList<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);

        /// <summary>
        /// Affiche les date et les destination des vols d'un avion donné
        /// </summary>
        /// <param name="p"></param>
        void ShowFlightDetails(Plane p);

        int GetWeeklyFlightNumber(DateTime date);

        double GetDurationAverage(string destination);

        IList<Flight> SortFlights();

        IList<Passenger> GetThreeOlderTravellers(Flight f);

        void ShowGroupedFlights();
        Passenger GetSeniorPassenger(GetScore meth);

    }
}
