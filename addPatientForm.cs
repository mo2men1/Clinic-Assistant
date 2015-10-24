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
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patient = new Domain.Patient
            {
                name = textBox1.Text,
                phone = textBox2.Text,
                gender = textBox3.Text,
            };
            PatientService patientService = new PatientService();
            patientService.save(patient);
        }
    }
}
