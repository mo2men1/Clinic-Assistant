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

         PatientService patientService = new PatientService();
         var list = patientService.getPatient();
         patients_dataGridView.DataSource = list.ToList();


      }

     

      private void addPatient_btn_Click(object sender, EventArgs e)
      {
         AddPatientForm form = new AddPatientForm(this);
         form.Show();
      }

      public void Update_GridView() {
         PatientService patientService = new PatientService();
         var list = patientService.getPatient();
         patients_dataGridView.DataSource = list.ToList();
      }

   }
}
