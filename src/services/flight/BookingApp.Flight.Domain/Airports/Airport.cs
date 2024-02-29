using BookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Flight.Domain.Airports
{
    // Airport is a type of Aggregate that uses a long type identifier as its primary key.
    public class Airport : Aggregate<long>
    {
        // Properties of the airport can only be defined within the class due to their private setters.
        public string Name { get; private set; }

        public string Address { get; private set; }

        public string Code { get; private set; }

        // Static method to create a new Airport instance, which initializes its properties and returns the created Airport.
        public static Airport Create(long id, string name, string address, string code)
        {
            var airport = new Airport()
            { 
              Id = id,
              Address = address, 
              Name = name, 
              Code = code 
            };

            return airport;
        }
    }
}
