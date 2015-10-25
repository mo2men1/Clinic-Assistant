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
         if (p.age != null)
         {
            int age = (int)p.age;
            p.dateOfBirth = ageToDateOfBirth(age);
            p.age = null;
         }
         var sess = SessionProvider.createSession();
         sess.Save(p);
         sess.Flush();
      }

      public object  getPatient()         //Type object to return AnonymousType
      {
         var sess = SessionProvider.createSession();
         IQuery q = sess.CreateQuery("FROM Patient");
          IList<Domain.Patient> list = q.List<Domain.Patient>();
          foreach (Patient p in list)
          {
             if (p.dateOfBirth != DateTime.MinValue)
             {
                DateTime dob = p.dateOfBirth;
                int age = dateofBirthToAge(dob);
                p.age = age;
             }
          }
          var reducedList = list.Select(e => new { e.id, e.name,e.phone, e.gender, e.age }).ToList();
          return reducedList;
      }

      public Patient getPatientById(int id)
      {
          var sess = SessionProvider.createSession();
          IQuery q = sess.CreateQuery("FROM Patient where id = "+ id.ToString());
          return q.List<Domain.Patient>().First();
      }

      public int dateofBirthToAge(DateTime dob)
      {
         DateTime d = DateTime.Today;
         int age = d.Year - dob.Year;
         return age;
      }

      private DateTime ageToDateOfBirth(int age)
      {
         DateTime d = DateTime.Today;
         d = d.AddYears(-age);
         return d;
      }
   }
}
