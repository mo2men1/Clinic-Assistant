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
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
            fillCheckBoxList();
        }

        Home owner;
        public AddPatientForm(Home _owner)
        {
           owner = _owner;
           InitializeComponent();
           fillCheckBoxList();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            var patient = new Domain.Patient
            {
                name = name_txt.Text,
                phone = phone_txt.Text,
                gender = gender_ComboBox.Text,
                age = Convert.ToInt32(age_text.Text),
                medical_history = getCheckedItems(),
            };
          
            PatientService patientService = new PatientService();
            patientService.save(patient);

            
            
            owner.Fill_GridView();
            this.Close();
        }

        private void fillCheckBoxList()
        {
           DiseaseService diseasesrvc = new DiseaseService();
           var list = diseasesrvc.getAllDiseases();
           disease_checklist.DataSource = list;
        }

        private void addDisease_btn_Click(object sender, EventArgs e)
        {
           var disease = new Disease
           {
              disease = addDisease_txt.Text
           };

           DiseaseService ds = new DiseaseService();
           ds.addDisease(disease);

           fillCheckBoxList();
           addDisease_txt.Clear();
        }

       private string getCheckedItems()
        {
           string str = "";
           var checkeditems = disease_checklist.CheckedItems;
           foreach (object itemchecked in checkeditems)
           {
              str += itemchecked.ToString() + ", ";
           }
           str = str.Substring(0, str.Length - 2);
           str += ".";
           return str;

        }
        

    }
}
