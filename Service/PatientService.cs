using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

      public DataTable  getAllPatients()         
      {
         var sess = SessionProvider.createSession();
         IQuery q = sess.CreateQuery("FROM Patient");
         var list = q.List<Domain.Patient>();
         DataTable dt = new DataTable();
         dt.Columns.Add("ID").DataType = typeof(int);
         dt.Columns.Add("Name");
         dt.Columns.Add("Phone");
         dt.Columns.Add("Gender");
         dt.Columns.Add("Age");

         foreach (var item in list)
         {
            if (item.dateOfBirth != DateTime.MinValue)
            {
               DateTime dob = item.dateOfBirth;
               int age = dateofBirthToAge(dob);
               item.age = age;
            }
            dt.Rows.Add(item.id, item.name, item.phone, item.gender, item.age.ToString());
         }
         return dt;
      }

      public Patient getPatientById(int id)
      {
          var sess = SessionProvider.createSession();
          IQuery q = sess.CreateQuery("FROM Patient where id = "+ id.ToString());
          return q.List<Domain.Patient>().First();
      }

      public void deletePatient(int id)
      {
         var sess = SessionProvider.createSession();
         Patient patient = sess.Get<Patient>(id);
         sess.Delete(patient);
         sess.Flush();
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
