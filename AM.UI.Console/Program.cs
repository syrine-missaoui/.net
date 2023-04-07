// See https://aka.ms/new-console-template for more information
using AM.Core.Domain;
using AM.Core.Services;
using static AM.Core.Services.IFlightService;
using AM.Core.Extensions;
using AM.Data;

Console.WriteLine("Hello, World!");
////TP 1.Question7
//Plane plane= new Plane();
//plane.Capacity = 300;
//plane.ManufactureDate = new DateTime(2000, 1, 1);
//plane.MyPlaneType = PlaneType.Boeing;
////TP 1.Question8
//Plane plane1 = new Plane(PlaneType.Airbus, 100, new DateTime(2001, 9, 12));
////TP 1.Question9
//Plane plane2 = new Plane()
//{
//    Capacity = 100,
//    ManufactureDate = new DateTime(2011, 2, 14)
//};
////TP1.Question12.B
//Passenger passenger = new Passenger();
//Passenger staff =new Staff();
//Passenger traveller = new Traveller();
//Console.WriteLine(passenger.GetPassengerType());
//Console.WriteLine(staff.GetPassengerType());
//Console.WriteLine(traveller.GetPassengerType());
////TP1.Question13.C
//int calculatedAge = 0;
//passenger.GetAge(new DateTime(2000, 1, 1), ref calculatedAge);
//Console.WriteLine(calculatedAge);
//passenger.BirthDate = new DateTime(2000, 1, 1);
////passenger.GetAge(passenger);
////Console.WriteLine(passenger.Age);
//IFlightService flightService = new FlightService();
////TP2.Q13.c 
//GetScore meth1 = delegate (Passenger p)
//{
//    return p.Flights.Count;
//};
//GetScore meth2 = delegate (Passenger p)
//{
//    return p.Flights.Where(f => f.Destination == "Tunisie" || f.Departure == "Tunisie")
//    .Count();
//};
//Passenger pSenior1 =flightService.GetSeniorPassenger(meth1);
//Passenger pSenior2 = flightService.GetSeniorPassenger(meth2);
////TP2.Q14
//Flight flight= new Flight();
//flight.GetDelay();

//tp3 Q8
Plane p = new Plane()
{
    Capacity = 200,
    ManufactureDate = new DateTime(2000, 01, 01),
    MyPlaneType = PlaneType.Airbus
};

Flight f=new Flight() { 
  Comment="comment",
  Departure="Paris",
  Destination="Tunisie",
  EffectiveArrival=new DateTime(2023,03,10,10,0,0),
  EstimatedDuration=60,
  FlightDate=new DateTime(2023, 03, 10, 8, 0, 0),
 MyPlane=p
  };

AMContext context=new AMContext();
context.Add(f);
context.Add(p);
context.SaveChanges();
