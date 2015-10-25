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
        public PatientInfoForm(Patient patient)
        {
            InitializeComponent();
            name_lbl.Text = patient.name;
            //age_lbl.Text = patient.age.ToString(); must check if it's null
            gender_lbl.Text = patient.gender;
            phone_lbl.Text = patient.phone;
        }
    }
}
