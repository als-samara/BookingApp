using BookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Flight.Domain.Aircrafts.Models
{
    // Aircraft is a type of Aggregate that uses a long type identifier as its primary key.
    public class Aircraft : Aggregate<long>
    {
        // Properties of the aircraft can only be defined within the class due to their private setters.
        public string Name { get; private set; }

        public string Model { get; private set; }

        // Static method to create a new Aircraft instance, which initializes its properties and returns the created Aircraft.
        public static Aircraft Create(long id, string name, string model) 
        {
            var aircraft = new Aircraft 
            {  
                Id = id,
                Name = name, 
                Model = model 
            };

            return aircraft;
        }
    }
}
