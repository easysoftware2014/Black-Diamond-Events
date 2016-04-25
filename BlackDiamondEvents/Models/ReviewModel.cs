using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BDE.Domain.Contracts.Models;

namespace BlackDiamondEvents.Models
{
    public class ReviewModel : IReview
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
    }
}