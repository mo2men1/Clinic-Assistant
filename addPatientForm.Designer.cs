namespace Clinic_Assistant
{
    partial class AddPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.name_txt = new System.Windows.Forms.TextBox();
         this.phone_txt = new System.Windows.Forms.TextBox();
         this.name_lbl = new System.Windows.Forms.Label();
         this.phone_lbl = new System.Windows.Forms.Label();
         this.gender_lbl = new System.Windows.Forms.Label();
         this.save_btn = new System.Windows.Forms.Button();
         this.gender_ComboBox = new System.Windows.Forms.ComboBox();
         this.age_lbl = new System.Windows.Forms.Label();
         this.age_text = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // name_txt
         // 
         this.name_txt.Location = new System.Drawing.Point(75, 42);
         this.name_txt.Name = "name_txt";
         this.name_txt.Size = new System.Drawing.Size(197, 20);
         this.name_txt.TabIndex = 0;
         this.name_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // phone_txt
         // 
         this.phone_txt.Location = new System.Drawing.Point(75, 68);
         this.phone_txt.Name = "phone_txt";
         this.phone_txt.Size = new System.Drawing.Size(197, 20);
         this.phone_txt.TabIndex = 1;
         // 
         // name_lbl
         // 
         this.name_lbl.AutoSize = true;
         this.name_lbl.Location = new System.Drawing.Point(12, 45);
         this.name_lbl.Name = "name_lbl";
         this.name_lbl.Size = new System.Drawing.Size(35, 13);
         this.name_lbl.TabIndex = 3;
         this.name_lbl.Text = "Name";
         // 
         // phone_lbl
         // 
         this.phone_lbl.AutoSize = true;
         this.phone_lbl.Location = new System.Drawing.Point(12, 71);
         this.phone_lbl.Name = "phone_lbl";
         this.phone_lbl.Size = new System.Drawing.Size(38, 13);
         this.phone_lbl.TabIndex = 4;
         this.phone_lbl.Text = "Phone";
         // 
         // gender_lbl
         // 
         this.gender_lbl.AutoSize = true;
         this.gender_lbl.Location = new System.Drawing.Point(12, 97);
         this.gender_lbl.Name = "gender_lbl";
         this.gender_lbl.Size = new System.Drawing.Size(42, 13);
         this.gender_lbl.TabIndex = 5;
         this.gender_lbl.Text = "Gender";
         // 
         // save_btn
         // 
         this.save_btn.Location = new System.Drawing.Point(197, 227);
         this.save_btn.Name = "save_btn";
         this.save_btn.Size = new System.Drawing.Size(75, 23);
         this.save_btn.TabIndex = 6;
         this.save_btn.Text = "Save";
         this.save_btn.UseVisualStyleBackColor = true;
         this.save_btn.Click += new System.EventHandler(this.button1_Click);
         // 
         // gender_ComboBox
         // 
         this.gender_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.gender_ComboBox.FormattingEnabled = true;
         this.gender_ComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
         this.gender_ComboBox.Location = new System.Drawing.Point(75, 94);
         this.gender_ComboBox.Name = "gender_ComboBox";
         this.gender_ComboBox.Size = new System.Drawing.Size(100, 21);
         this.gender_ComboBox.TabIndex = 7;
         // 
         // age_lbl
         // 
         this.age_lbl.AutoSize = true;
         this.age_lbl.Location = new System.Drawing.Point(12, 128);
         this.age_lbl.Name = "age_lbl";
         this.age_lbl.Size = new System.Drawing.Size(26, 13);
         this.age_lbl.TabIndex = 8;
         this.age_lbl.Text = "Age";
         // 
         // age_text
         // 
         this.age_text.Location = new System.Drawing.Point(75, 125);
         this.age_text.Name = "age_text";
         this.age_text.Size = new System.Drawing.Size(197, 20);
         this.age_text.TabIndex = 9;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(91, 171);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 10;
         this.label1.Text = "label1";
         // 
         // AddPatientForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 262);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.age_text);
         this.Controls.Add(this.age_lbl);
         this.Controls.Add(this.gender_ComboBox);
         this.Controls.Add(this.save_btn);
         this.Controls.Add(this.gender_lbl);
         this.Controls.Add(this.phone_lbl);
         this.Controls.Add(this.name_lbl);
         this.Controls.Add(this.phone_txt);
         this.Controls.Add(this.name_txt);
         this.Name = "AddPatientForm";
         this.Text = "AddPatientForm";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox gender_ComboBox;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.TextBox age_text;
        private System.Windows.Forms.Label label1;
    }
}