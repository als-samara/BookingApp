using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Core.ModelsAggregate
{
    // This class represents a base class for aggregate entities in the domain model.
    // It inherits from the Entity class and implements the IAggregate interface.
    // All entities that inherit from this class must have an `Id` property of type `TId` as their primary key.
    public abstract class Aggregate<TId> : Entity, IAggregate<TId>
    {
        // implemented property from interface used to uniquely identify an Aggregate object
        public TId Id { get; protected set; }
    }
}
