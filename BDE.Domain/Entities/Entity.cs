using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Contracts;

namespace BDE.Domain.Entities
{
    public class Entity : IEntity
    {
        public long Id { get; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime ModifiedAt { get; set; }

        public bool IsTransient()
        {
            return Id.Equals(default(long));
        }
    }
}
