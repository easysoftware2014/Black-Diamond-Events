using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Contracts.Repository;
using BDE.Domain.Entities;
using BDE.Infrastructure.Implementation.Criteria;
using NHibernate;

namespace BDE.Infrastructure.Implementation.Repository
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(ISession session) : base(session)
        {
        }

        public IList<Review> GetReviews()
        {
            return GetAllRecords();
        }

        public IList<Review> GetReviewsByDate(DateTime date)
        {
            return FindBySpecification(new GetReviewsByDateCriteria(date));
        }

        public Review GetReviewById(long id)
        {
            return FindById(new GetReviewByIdCriteria(id));
        }
    }
}
