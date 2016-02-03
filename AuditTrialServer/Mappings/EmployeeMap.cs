using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AuditTrialServer.Entities;
using FluentNHibernate.Mapping;

namespace AuditTrialServer.Mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            References(x => x.Store);
        }
    }
}
