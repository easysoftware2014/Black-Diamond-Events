using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE.Domain.Contracts.Models
{
    public interface IReview
    {
        long Id { get; set; }
        string Name { get; set; }
        string Contact { get; set; }
        string Comment { get; set; }
        DateTime Date { get; set; }
    }
}
