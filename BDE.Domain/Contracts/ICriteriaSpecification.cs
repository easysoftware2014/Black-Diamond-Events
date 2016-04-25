using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace BDE.Domain.Contracts
{
    public interface ICriteriaSpecification <T>
    {
        ICriteria Criteria(ISession session);
    }
}
