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
using Clinic_Assistant.Service;
namespace Clinic_Assistant
{
    public partial class PatientInfoForm : Form
    {
        public Patient patient;
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
            patient = service.getPatientById(id);
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

            VisitService visitService = new VisitService();
            IList<Visit> visitList = visitService.getVisitsByPatientId(id);
            fillGridView();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            owner.delete_patient();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVisitForm form = new AddVisitForm(this, patient.id);
            form.Show();
        }

        public void fillGridView()
        {
            var visitService = new VisitService();

            var data = visitService.getVisitsTable(patient.id);
            visits_dataGridView.DataSource = data;
            visits_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            visits_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            visits_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            visits_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            visits_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            visits_dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            visits_dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            visits_dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            visits_dataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //patients_dataGridView.Sort(patients_dataGridView.Columns["Name"], ListSortDirection.Ascending);
        }
    }
}
