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

        Home owner;
        public PatientInfoForm(int id, Home _owner)
        {
            InitializeComponent();
            owner = _owner; 
            var service = new PatientService();
            Patient patient = service.getPatientById(id);
            name_txt.Text = patient.name;
            id_txt.Text = patient.id.ToString();
            age_txt.Text = patient.dateOfBirth != DateTime.MinValue ?
                service.dateofBirthToAge(patient.dateOfBirth).ToString() : "";
            gender_txt.Text = patient.gender;
            phone_txt.Text = patient.phone;
            if (patient.medical_history != null)
            {
               medicalHistory_txt.Text = patient.medical_history;
            }
            else
            {
               medicalHistory_txt.Text = "None.";
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
           
            owner.delete_patient();
            this.Close();
           
        }


        
    }
}
