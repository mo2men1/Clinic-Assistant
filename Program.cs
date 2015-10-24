using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Clinic_Assistant
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
        // Application.EnableVisualStyles();
         //Application.SetCompatibleTextRenderingDefault(false);
         //Application.Run(new Form1());

         var patient = new Domain.Patient
            {
               name = "someone",
               phone = "012-3203",
               gender = "male",
            };

         PatientService patientService = new PatientService();
         patientService.save(patient);

         var list = patientService.getPatient();

        /* IQuery q = sess.CreateQuery("FROM Patient");
         var list = q.List<Domain.Patient>();*/
         list.ToList().ForEach(p => Console.WriteLine(p.name));
      }
   }
}
