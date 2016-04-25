using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDE.Domain.Contracts.Services;
using BDE.Domain.Entities;
using BDE.Infrastructure.Implementation.Services;
using BlackDiamondEvents.Models;

namespace BlackDiamondEvents.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public ReviewController() { }

        public ActionResult Index()
        {
            ViewBag.Reviews = _reviewService.GetReviews();

            return View(" ");
        }
        [HttpPost]
        public ActionResult Review(ReviewModel model)
        {
            var review = new Review
            {
                Name = model.Name,
                Comment = model.Comment,
                Contact = model.Contact,
                Date = DateTime.Now,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };
            
            _reviewService.SaveOrUpdate(review);
            //if (success == 1)
            //{
            //    TempData["Success"] = "Saved Successfully";
            //}
            //TempData["Failed"] = "Failed to save";
            
            return RedirectToAction("index","Home");
        }
    }
}