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

        public IList<Visit> getVisitsByPatientId(int patient_id)
        {
            PatientService patientService = new PatientService();
            Patient p = patientService.getPatientById(patient_id);
            return p.visits;
        }

        public DataTable getVisitsTable(int patient_id)
        {
            var list = getVisitsByPatientId(patient_id);
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");

            dt.Columns.Add("Date");
            dt.Columns.Add("Complaint");
            dt.Columns.Add("Diagnosis");

            dt.Columns.Add("Tooth");
            dt.Columns.Add("Treatment");

            dt.Columns.Add("Date Diagnosed");
            dt.Columns.Add("Date Completed");

            dt.Columns.Add("Cost");
            dt.Columns.Add("A.D.");
            dt.Columns.Add("Paid");
            dt.Columns.Add("Remaining");

            foreach (var i in list)
            {
                dt.Rows.Add(i.id.ToString(), i.date, i.complaint, i.diagnosis,
                            i.tooth, i.treatment,
                            i.dateDiagnosed, i.dateCompleted,
                            i.cost, i.ad, i.paid, i.remaining);
            }
            return dt;
        }
    }
}
