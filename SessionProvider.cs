using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;



namespace Clinic_Assistant
{
   public class SessionProvider
   {
      public ISession createSession() {
      var cfg = new Configuration();
         cfg.Configure();
         cfg.AddAssembly(typeof(Domain.Patient).Assembly);

         // Get ourselves an NHibernate Session
         var sessions = cfg.BuildSessionFactory();
         var sess = sessions.OpenSession();

         return sess;
      }
   }
}
