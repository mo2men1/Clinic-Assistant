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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Domain.Patient).Assembly);

            // Get ourselves an NHibernate Session
            var sessions = cfg.BuildSessionFactory();
            var sess = sessions.OpenSession();

            // Create the database schema
            new SchemaExport(cfg).Create(true, true);

            // Create a Product...
            var patient = new Domain.Patient
            {
                name = "someone",
                phone = "012-3203",
            };

            // And save it to the database
            sess.Save(patient);
            sess.Flush();

            IQuery q = sess.CreateQuery("FROM Patient");
            var list = q.List<Domain.Patient>();
            list.ToList().ForEach(p => Console.WriteLine(p.name));
        }
    }
}
