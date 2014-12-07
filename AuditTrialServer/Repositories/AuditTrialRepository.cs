using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditTrialServer.Entities;
using NHibernate.Linq;

namespace AuditTrialServer.Repositories
{
    public class AuditTrialRepository:NHibernateRepository<AuditTrialRecord>,IAuditTrialRepository
    {

        public IList<AuditTrialRecord> GetAllRecords() {

            return _session.Query<AuditTrialRecord>().ToList();
        }


    }

    public interface IAuditTrialRepository {

        IList<AuditTrialRecord> GetAllRecords();
    
    }
}
