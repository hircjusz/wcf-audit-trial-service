using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AuditTrialServer.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace AuditTrialServer.Helpers
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)

                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                  .ConnectionString(
                  @"Server=(local);initial CATALOG=AuditTrialService;
		Integrated Security=true;") // Modify your ConnectionString
                              .ShowSql()
                )
                .Mappings(m =>
                          m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
                              )
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg)
                                                .Execute(false, true))
                .BuildSessionFactory();
        }
    //    private static void InitializeSessionFactory()
    //    {
    //        _sessionFactory = Fluently.Configure()
    //            .Database(
    //  SQLiteConfiguration.Standard
    //    .UsingFile(@"C:\DATA\PRIVATE\WcfAuditTrial\AuditTrialServer\dbName.sdf")
    //)
    //            .Mappings(m =>
    //                      m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
    //                          )
    //            .ExposeConfiguration(cfg => new SchemaUpdate(cfg)
    //                                            .Execute(false, true))
    //            .BuildSessionFactory();
    //    }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
