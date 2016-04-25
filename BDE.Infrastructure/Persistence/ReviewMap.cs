using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BDE.Domain.Entities;


namespace BDE.Infrastructure.Persistence
{
    public class ReviewMap: ClassMap<Review>
    {
        public ReviewMap()
        {
            Table("[Review]");

            Map(x => x.Comment).Column("comment");
            Map(x => x.Contact).Column("contact");
            Map(x => x.Date).Column("date");
            Map(x => x.Name).Column("name");

        }
    }

   
}
