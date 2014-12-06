using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace AuditTrialServer.Repositories
{
    public class NHibernateRepository<TEntity> where TEntity :class, IRepository<TEntity> 
    {
        ISession _session;

        public NHibernateRepository(ISession session)
        {
            _session = session;
        }

        protected ISession Session { get { return _session; } }

        public TEntity GetById(string id)
        {
            return _session.Get<TEntity>(id);
        }

        public void Create(TEntity entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Update(TEntity entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
        }
    }


    public interface IRepository<TEntity> where TEntity : class
    {

        TEntity GetById(string id);


        void Create(TEntity entity);


        void Update(TEntity entity);


        void Delete(TEntity entity);

    }
}
