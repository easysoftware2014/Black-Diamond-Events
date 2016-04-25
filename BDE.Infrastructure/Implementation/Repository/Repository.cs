using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Domain.Contracts;
using BDE.Domain.Contracts.Repository;
using NHibernate;
using NHibernate.Linq;

namespace BDE.Infrastructure.Implementation.Repository
{
    public class Repository <T> : IRepository<T> where T : IEntity
    {
        private readonly ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }
        public ISession Session
        {
            get
            {
                return _session;
            }
        }

        public T Get(long id)
        {
            return Session.Get<T>(Convert.ToInt64(id));
        }

        public T Load(long id)
        {
            return Session.Load<T>(id);
        }

        public long Save(T entity)
        {
            return Convert.ToInt64(Session.Save(entity));
        }

        public void SaveOrUpdate(T entity)
        {
            Session.SaveOrUpdate(entity);
        }

        public void Delete(T entity)
        {
            Session.Delete(entity);
        }

        public IList<T> FindBySpecification(ICriteriaSpecification<T> specification)
        {
            return specification.Criteria(_session).List<T>();
        }

        public T FindById(ICriteriaSpecification<T> specification)
        {
            return specification.Criteria(_session).UniqueResult<T>();
        }

        public IList<T> GetAllRecords()
        {
            return _session.Query<T>().ToList();
        }

        public long FindCountBySpecification(ICriteriaSpecification<T> specification)
        {
            var count = specification.Criteria(_session).UniqueResult<long>();
            return count;
        }

        public string FindStringBySpecification(ICriteriaSpecification<T> specification)
        {
            return specification.Criteria(_session).UniqueResult<string>();
        }

        public void Update(T entity)
        {
            Session.Update(entity); ;
        }
        public T FirstOrDefault(ICriteriaSpecification<T> specification)
        {
            throw new NotImplementedException();
        }
    }
}
