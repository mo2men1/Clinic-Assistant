using Clinic_Assistant.Domain;
using System;
using System.Collections.Generic;
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
    }
}
