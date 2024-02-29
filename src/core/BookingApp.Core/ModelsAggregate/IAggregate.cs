using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Core.ModelsAggregate
{
    // any class that implements IAggregate<T> should also implement IAggregate
    // This interface defines a property Id of type T, which is used to uniquely identify an object.
    public interface IAggregate<out T> : IAggregate
    {
        T Id { get; }
    }

    // This is an empty interface. It does not contain any members
    // and is often used as a marker to identify a certain type of class
    public interface IAggregate
    {

    }
}
