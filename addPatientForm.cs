﻿using System;
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

        Home owner;
        public AddPatientForm(Home _owner)
        {
           owner = _owner;
           InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patient = new Domain.Patient
            {
                name = name_txt.Text,
                phone = phone_txt.Text,
                gender = gender_ComboBox.Text,
                age = Convert.ToInt32(age_text.Text), 
            };
          
            PatientService patientService = new PatientService();
            patientService.save(patient);

            
            //label1.Text = ageToDateOfBirth(21).ToString("yyyy");
            owner.Fill_GridView();
            this.Close();
        }

        

    }
}
