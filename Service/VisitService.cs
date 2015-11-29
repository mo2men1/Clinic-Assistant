using Clinic_Assistant.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Assistant.Service
{
    class VisitService
    {
        public void addVisit(Visit visit, int patient_id)
        {
            var sess = SessionProvider.createSession();
            PatientService patientService = new PatientService();
            Patient p = patientService.getPatientById(patient_id);
            visit.patient = p;
            sess.Save(visit);
            sess.Flush();
        }

        public Visit getVisitById(int id)
        {
            var sess = SessionProvider.createSession();
            IQuery q = sess.CreateQuery("FROM Visit where id = " + id.ToString());
            return q.List<Domain.Visit>().First();
        }

        public void update(int id, Visit v)
        {
            var sess = SessionProvider.createSession();
            IQuery q = sess.CreateQuery("FROM Visit where id = " + id.ToString());
            Visit visit = q.List<Domain.Visit>().First();
            visit.date = v.date;
            visit.complaint = v.complaint;
            visit.diagnosis = v.diagnosis;
            visit.tooth = v.tooth;
            visit.treatment = v.treatment;
            visit.cost = v.cost;
            visit.paid = v.paid;
            sess.Update(visit);
            sess.Flush();
        }

        public IList<Visit> getVisitsByPatientId(int patient_id)
        {
            PatientService patientService = new PatientService();
            Patient p = patientService.getPatientById(patient_id);
            return p.visits;
        }

        public DataTable getVisitsTable(int patient_id, Dictionary<int, int> dictIndexId)
        {
            var list = getVisitsByPatientId(patient_id);
            DataTable dt = new DataTable();

            dt.Columns.Add("ID").DataType = typeof(int);

            dt.Columns.Add("Date");
            dt.Columns.Add("Complaint");
            dt.Columns.Add("Diagnosis");

            dt.Columns.Add("Tooth");
            dt.Columns.Add("Treatment");


            dt.Columns.Add("Cost");
            dt.Columns.Add("Paid");
            dt.Columns.Add("Remaining");

            int n = 1;
            dictIndexId.Clear();
            foreach (var i in list)
            {
                dictIndexId.Add(n, i.id);
                dt.Rows.Add(n, i.date, i.complaint, i.diagnosis,
                            i.tooth, i.treatment,
                            i.cost, i.paid, i.remaining);
                n++;
            }
            return dt;
        }
    }
}
