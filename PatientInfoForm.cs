using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Assistant.Domain;
namespace Clinic_Assistant
{
    public partial class PatientInfoForm : Form
    {
        public PatientInfoForm()
        {
            InitializeComponent();
        }
        public PatientInfoForm(int id)
        {
            var service = new PatientService();
            Patient patient = service.getPatientById(id);
            InitializeComponent();
            name_lbl.Text = patient.name;
            age_lbl.Text = patient.dateOfBirth != DateTime.MinValue ?
                service.dateofBirthToAge(patient.dateOfBirth).ToString() : "";
            gender_lbl.Text = patient.gender;
            phone_lbl.Text = patient.phone;
        }
    }
}
