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
            dt.Columns.Add("purpose");
            foreach (var item in list)
            {
                dt.Rows.Add(item.id.ToString(), item.purpose);
            }
            return dt;
        }
    }
}
