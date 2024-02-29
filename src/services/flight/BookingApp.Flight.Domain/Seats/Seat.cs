using BookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Flight.Domain.Seats
{
    // Seat is a type of Aggregate that uses a long type identifier as its primary key.
    public class Seat : Aggregate<long>
    {
        // Properties of the flight can only be defined within the class due to their private setters.
        public string SeatNumber { get; private set; }
        public SeatType Type { get; private set; }
        public SeatClass Class { get; private set; }
        public long FlightId { get; private set; }

        // Static method to create a new Seat instance, which initializes its properties and returns the created Seat.
        public static Seat Create(long id, string seatNumber, SeatType type, SeatClass seatClass, long flightId)
        {
            var seat = new Seat()
            {
                Id = id,
                Class = seatClass,
                Type = type,
                SeatNumber = seatNumber,
                FlightId = flightId
            };
            return seat;
        }

        // Marks a seat as reserved and updates its modification time.
        // Returns a completed Task with the modified seat.
        public Task<Seat> ReserveSeat(Seat seat)
        {
            seat.IsDeleted = true;
            seat.LastModified = DateTime.UtcNow;

            // return Task.FromResult(this);
            return Task.FromResult(seat);
        }
    }
}
