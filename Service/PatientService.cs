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
         var sess = SessionProvider.createSession();
         sess.Save(p);
         sess.Flush();
      }

      public IList <Patient> getPatient()
      {
         var sess = SessionProvider.createSession();
         IQuery q = sess.CreateQuery("FROM Patient");
         return  q.List<Domain.Patient>();
      }
   }
}
