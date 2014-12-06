using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditTrialServer.Entities;
using FluentNHibernate.Mapping;

namespace AuditTrialServer.Mappings
{
    public class AuditTrialRecordMap:ClassMap<AuditTrialRecord>
    {

        public AuditTrialRecordMap() {

            Id(x => x.Id);
            Map(x => x.Description);
        }

    }
}
