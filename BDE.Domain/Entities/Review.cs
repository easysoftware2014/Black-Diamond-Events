using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Contracts;

namespace BDE.Domain.Entities
{
    public class Review : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Contact { get; set; }
        public virtual string Comment { get; set; }
        public virtual DateTime Date { get; set; }

       
    }
}
