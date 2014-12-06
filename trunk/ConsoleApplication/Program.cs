using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditTrialServer.Helpers;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var item = new AuditTrialServer.Entities.AuditTrialRecord() {Description = "One" };
                    session.Save(item);
                    transaction.Commit();
                    Console.WriteLine("Department Created: " + item.Description);
                    Console.ReadKey();
                }
            }
        }
    }
}
