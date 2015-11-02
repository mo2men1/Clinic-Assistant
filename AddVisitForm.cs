using Clinic_Assistant.Domain;
using Clinic_Assistant.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Assistant
{
    public partial class AddVisitForm : Form
    {
        public int patient_id;
        public AddVisitForm()
        {
            InitializeComponent();
        }

        PatientInfoForm owner;
        public AddVisitForm(PatientInfoForm form, int id)
        {
            InitializeComponent();
            owner = form;
            patient_id = id;
        }

        private void saveVisitBtn_Click(object sender, EventArgs e)
        {
            
            Visit visit = new Visit()
            {
                date = date_dateTimePicker.Value,
                complaint = complaint_textBox.Text,
                diagnosis = diagnosis_textBox.Text,

                tooth = tooth_textBox.Text,
                treatment = treatmet_textBox.Text,

                dateDiagnosed = dateDiagnosedDateTimePicker2.Value,
                dateCompleted = dateDiagnosedDateTimePicker2.Value,

                cost = Decimal.ToInt32(numericUpDown1.Value),
                ad = Decimal.ToInt32(numericUpDown2.Value),
                paid = Decimal.ToInt32(numericUpDown3.Value),
                remaining = Decimal.ToInt32(numericUpDown4.Value),

            };
            VisitService visitService = new VisitService();
            visitService.addVisit(visit, patient_id);
            owner.fillGridView();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
