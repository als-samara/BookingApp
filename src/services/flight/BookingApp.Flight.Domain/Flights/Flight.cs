using BookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Flight.Domain.Flights
{
    // Flight is a type of Aggregate that uses a long type identifier as its primary key.
    public class Flight : Aggregate<long>
    {
        // Properties of the flight can only be defined within the class due to their private setters.
        public string FlightNumber { get; private set; }
        public long AircraftId { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public long DepartureAirportId { get; private set; }
        public DateTime ArriveDate { get; private set; }
        public long ArriveAirportId { get; private set; }
        public decimal DurationMinutes { get; private set; }
        public DateTime FlightDate { get; private set; }
        public FlightStatus Status { get; private set; }
        public decimal Price { get; private set; }

        // Static method to create a new Flight instance, which initializes its properties and returns the created Flight.
        public static Flight Create(long id, string flightNumber, long aircraftId,
           long departureAirportId, DateTime departureDate, DateTime arriveDate,
           long arriveAirportId, decimal durationMinutes, DateTime flightDate, FlightStatus status,
           decimal price, bool isDeleted = false)
        {
            var flight = new Flight
            {
                Id = id,
                FlightNumber = flightNumber,
                AircraftId = aircraftId,
                DepartureAirportId = departureAirportId,
                DepartureDate = departureDate,
                ArriveDate = arriveDate,
                ArriveAirportId = arriveAirportId,
                DurationMinutes = durationMinutes,
                FlightDate = flightDate,
                Status = status,
                Price = price,
                IsDeleted = isDeleted,
            };


            return flight;
        }

    }
}
