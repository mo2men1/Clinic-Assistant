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
               medicalHistory_txt.Text = patient.medical_history + ".";
            }
            else
            {
               medicalHistory_txt.Text = "None.";
            }

            fillGridView();
            edit_visit_btn.Enabled = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(owner.delete_patient())
               this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVisitForm form = new AddVisitForm(this, patient.id);
            form.ShowDialog();
        }

        public void fillGridView()
        {
           var visits = QueryVisits();
           visits_dataGridView.DataSource = visits;
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

       DataTable QueryVisits()
        {
          var visitService = new VisitService();
          var data = visitService.getVisitsTable(patient.id);


          int nVisits = data.Rows.Count;
          float paid = 0, costs = 0;
          for (int i = 0; i < nVisits; i++)
          {
             paid += float.Parse(data.Rows[i]["Paid"].ToString());
             costs += float.Parse(data.Rows[i]["Cost"].ToString());
          }
          float remaining = costs - paid;

          CostSum_txt.Text = costs.ToString();
          PaidSum_txt.Text = paid.ToString();
          RemainingSum_txt.Text = remaining.ToString();

          return data;
        }

       private void edit_visit_btn_Click(object sender, EventArgs e)
       {
           int visitId = Int32.Parse(visits_dataGridView.CurrentRow.Cells["id"].Value.ToString());
           AddVisitForm form = new AddVisitForm(this, patient.id, visitId);
           form.ShowDialog();
       }
    }
}
