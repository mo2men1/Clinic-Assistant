using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using Clinic_Assistant.Domain;
namespace Clinic_Assistant
{
   class PatientService
   {
      public void save(Patient p)
      {
         var cfg = new Configuration();
         cfg.Configure();
         cfg.AddAssembly(typeof(Domain.Patient).Assembly);

         // Get ourselves an NHibernate Session
         var sessions = cfg.BuildSessionFactory();
         var sess = sessions.OpenSession();

         sess.Save(p);
         sess.Flush();
      }

      public IList <Patient> getPatient()
      {
         var cfg = new Configuration();
         cfg.Configure();
         cfg.AddAssembly(typeof(Domain.Patient).Assembly);

         var sessions = cfg.BuildSessionFactory();
         var sess = sessions.OpenSession();

         IQuery q = sess.CreateQuery("FROM Patient");
         return  q.List<Domain.Patient>();
        // list.ToList().ForEach(p => Console.WriteLine(p.name));
      }
   }
}
