using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Contracts;
using BDE.Domain.Entities;
using NHibernate;
using NHibernate.Criterion;

namespace BDE.Infrastructure.Implementation.Criteria
{
    public class GetReviewsByDateCriteria : ICriteriaSpecification<Review>
    {
        private readonly DateTime _date;

        public GetReviewsByDateCriteria(DateTime date)
        {
            _date = date;
        }
        public ICriteria Criteria(ISession session)
        {
            var date = new DateTime(2016,04,26);
            
            return session.CreateCriteria(typeof (Review)).Add(Restrictions.Eq("date", _date));


        }
    }
}
