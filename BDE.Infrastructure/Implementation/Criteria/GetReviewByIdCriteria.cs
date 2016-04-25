using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Contracts;
using BDE.Domain.Entities;
using NHibernate;
using NHibernate.Criterion;

namespace BDE.Infrastructure.Implementation.Criteria
{
    public class GetReviewByIdCriteria : ICriteriaSpecification<Review>
    {
        private readonly long _id;

        public GetReviewByIdCriteria(long id)
        {
            _id = id;
        }
        public ICriteria Criteria(ISession session)
        {
            var criteria = session.CreateCriteria(typeof (Review));
            criteria.Add(Restrictions.Eq("id", _id));

            return criteria;
        }
    }
}
