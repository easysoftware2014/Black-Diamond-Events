using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Contracts.Repository;
using BDE.Domain.Contracts.Services;
using BDE.Domain.Entities;

namespace BDE.Infrastructure.Implementation.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public long Save(Review review)
        {
            using (var trans = _reviewRepository.Session.BeginTransaction())
            {
                var id = _reviewRepository.Save(review);
                trans.Commit();

                return id;
            }
        }
        public void SaveOrUpdate(Review review)
        {
            using (var trans = _reviewRepository.Session.BeginTransaction())
            {
                _reviewRepository.SaveOrUpdate(review);
                trans.Commit();
            }
        }
        public IList<Review> GetReviews()
        {
            return _reviewRepository.GetReviews();
        }

        public IList<Review> GetByDateCriteria(DateTime date)
        {
            return _reviewRepository.GetReviewsByDate(date);
        }

        public IList<Review> GetReviewsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Review GetReviewById(long id)
        {
            return _reviewRepository.GetReviewById(id);
        }
    }
}
