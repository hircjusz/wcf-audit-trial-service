using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditTrialServer.Entities
{
    public  class AuditTrialRecord
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }

    }
}
