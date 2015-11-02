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

        public AddVisitForm(int id)
        {
            InitializeComponent();
            patient_id = id;
            label1.Text = id.ToString();
        }

        private void saveVisitBtn_Click(object sender, EventArgs e)
        {
            
            Visit visit = new Visit()
            {
                purpose = textBox1.Text,
            };
            VisitService visitService = new VisitService();
            visitService.addVisit(visit, patient_id);
            this.Close();
        }
    }
}
