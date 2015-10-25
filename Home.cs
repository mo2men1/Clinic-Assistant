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
   public partial class Home : Form
   {
      public Home()
      {
         InitializeComponent();

         Update_GridView();
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

      public void Update_GridView() {
         var data = queryPatientDb();
         Fill_GridView(data);
      }

      private void Fill_GridView(object list)
      {
         patients_dataGridView.DataSource = list;
         patients_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         patients_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         patients_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         patients_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         patients_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


      }

   }
}
