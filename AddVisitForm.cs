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
        public int visit_id;
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
            save_visit_btn.Visible = true;
            
        }
        public AddVisitForm(PatientInfoForm form, int pId,int vId)
        {
            InitializeComponent();
            owner = form;
            patient_id = pId;
            visit_id = vId;
            save_edits_btn.Visible = true;
            fillFormFromVisit();

        }

        void fillFormFromVisit()
        {
            VisitService visitService = new VisitService();
            Visit visit = visitService.getVisitById(visit_id);
            complaint_textBox.Text = visit.complaint;
            diagnosis_textBox.Text = visit.diagnosis;
            tooth_textBox.Text = visit.tooth;
            treatmet_textBox.Text = visit.treatment;
            cost_num.Value = (int)visit.cost;
            paid_num.Value = (int)visit.paid;

        }

        private void saveVisitBtn_Click(object sender, EventArgs e)
        {
            VisitService visitService = new VisitService();
            visitService.addVisit(createVisitFromForm(), patient_id);
            owner.fillGridView();
            this.Close();
        }

        private Visit createVisitFromForm()
        {
            return new Visit()
            {
                date = date_dateTimePicker.Value.Date,
                complaint = complaint_textBox.Text,
                diagnosis = diagnosis_textBox.Text,

                tooth = tooth_textBox.Text,
                treatment = treatmet_textBox.Text,


                cost = Decimal.ToInt32(cost_num.Value),
                paid = Decimal.ToInt32(paid_num.Value),
                remaining = Decimal.ToInt32(remaining_num.Value),

            };
        }

        private void save_edits_btn_Click(object sender, EventArgs e)
        {
            VisitService visitService = new VisitService();
            visitService.update(visit_id, createVisitFromForm());
            owner.fillGridView();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cost_num_ValueChanged(object sender, EventArgs e)
        {
           remaining_num.Value = cost_num.Value - paid_num.Value;
        }

        private void paid_num_ValueChanged(object sender, EventArgs e)
        {
           remaining_num.Value = cost_num.Value - paid_num.Value;
        }

        private void save_edits_btn_Click_1(object sender, EventArgs e)
        {
            VisitService visitService = new VisitService();
            visitService.update(visit_id, createVisitFromForm());
            owner.fillGridView();
            this.Close();
        }
    }
}
