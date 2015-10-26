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
   public partial class Home : Form
   {
      public Home()
      {
         InitializeComponent();

      }

      protected override void OnLoad(EventArgs e)
      {
         Fill_GridView();
         patients_dataGridView.ClearSelection();
         patients_dataGridView.SelectionChanged += new EventHandler(patients_dataGridView_SelectionChanged);
      }
     

      private void addPatient_btn_Click(object sender, EventArgs e)
      {
         AddPatientForm form = new AddPatientForm(this);
         form.Show();
      }

      private object queryPatientDb()
      {
         PatientService patientService = new PatientService();
         return patientService.getPatient();
      }


      public void Fill_GridView()
      {
         var data = queryPatientDb();
         var listBinding = new BindingSource();
         listBinding.DataSource = data;
         patients_dataGridView.DataSource = listBinding;
         patients_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         patients_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         patients_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         patients_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         patients_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

      }
      private void patients_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
          DataGridViewRow row = this.patients_dataGridView.Rows[e.RowIndex];
          PatientInfoForm form = new PatientInfoForm(Int32.Parse(row.Cells["id"].Value.ToString()));
          form.Show();
      }

      private void patients_dataGridView_SelectionChanged(object sender, EventArgs e)
      {
         delete_btn.Enabled = true;
      }

      private void delete_btn_Click(object sender, EventArgs e)
      {
         string name = patients_dataGridView.CurrentRow.Cells["name"].Value.ToString();
         DialogResult dialogresult = MessageBox.Show(
            "Are you sure you want to delete patient \""+name+"\" from the database?",
            "Confirm delete", MessageBoxButtons.OKCancel);
         
         if(dialogresult == DialogResult.OK) {
            int id = Int32.Parse(patients_dataGridView.CurrentRow.Cells["id"].Value.ToString());
            PatientService patientservice = new PatientService();
            patientservice.deletePatient(id);
            patients_dataGridView.Rows.Remove(patients_dataGridView.CurrentRow);
         }
      }

   }
}
