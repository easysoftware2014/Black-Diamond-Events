using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Entities;

namespace BDE.Domain.Contracts.Repository
{
    public interface IReviewRepository : IRepository<Review>
    {
        IList<Review> GetReviews();
        IList<Review> GetReviewsByDate(DateTime date);
        Review GetReviewById(long id);

    }
}
