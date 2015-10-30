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
   class DiseaseService
   {
      public IList<string> getAllDiseases()
      {
         var sess = SessionProvider.createSession();
         IQuery q = sess.CreateQuery("From Disease");
         var list = q.List<Domain.Disease>();
         IList<string> diseaseList = list.Select(e => new { e.disease }.disease.ToString()).ToList();
         return diseaseList;
      }

      public void addDisease(Disease d)
      {
         var sess = SessionProvider.createSession();
         sess.Save(d);
         sess.Flush();
      }
   }
}
