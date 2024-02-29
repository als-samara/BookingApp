using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Core.ModelsAggregate
{
    public abstract class Entity
    {
        // date and time of creation
        public DateTime? CreatedAt { get; set; }

        //user id who creates the object
        public long? CreatedBy { get; set; }

        //last modification date and time 
        public DateTime? LastModified { get; set; }

        // user id from who last modified the object
        public long? LastModifiedBy { get; set; }

        // indicates if the id was deleted
        public bool IsDeleted { get; set; }
    }
}
