using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Entities;

namespace BDE.Domain.Contracts.Services
{
    public interface IReviewService
    {
        long Save(Review review);
        IList<Review> GetReviews();
        IList<Review> GetByDateCriteria(DateTime date);
        IList<Review> GetReviewsByName(string name);
        Review GetReviewById(long id);
        void SaveOrUpdate(Review review);
    }
}
