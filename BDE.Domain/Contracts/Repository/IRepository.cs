using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace BDE.Domain.Contracts.Repository
{
    public interface IRepository <T>
    {
        T Get(long id);
        T Load(long id);
        long Save(T entity);
        void SaveOrUpdate(T entity);
        void Delete(T entity);
        IList<T> FindBySpecification(ICriteriaSpecification<T> specification);
        T FindById(ICriteriaSpecification<T> specification);
        IList<T> GetAllRecords();
        long FindCountBySpecification(ICriteriaSpecification<T> specification);
        string FindStringBySpecification(ICriteriaSpecification<T> specification);
        void Update(T entity);
        ISession Session { get; }
        T FirstOrDefault(ICriteriaSpecification<T> specification);
    }
}
