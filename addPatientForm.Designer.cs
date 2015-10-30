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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.addDisease_txt = new System.Windows.Forms.TextBox();
         this.addDisease_btn = new System.Windows.Forms.Button();
         this.disease_checklist = new System.Windows.Forms.CheckedListBox();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // name_txt
         // 
         this.name_txt.Location = new System.Drawing.Point(75, 42);
         this.name_txt.Name = "name_txt";
         this.name_txt.Size = new System.Drawing.Size(278, 20);
         this.name_txt.TabIndex = 0;
         // 
         // phone_txt
         // 
         this.phone_txt.Location = new System.Drawing.Point(75, 68);
         this.phone_txt.Name = "phone_txt";
         this.phone_txt.Size = new System.Drawing.Size(137, 20);
         this.phone_txt.TabIndex = 1;
         // 
         // name_lbl
         // 
         this.name_lbl.AutoSize = true;
         this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.name_lbl.Location = new System.Drawing.Point(16, 45);
         this.name_lbl.Name = "name_lbl";
         this.name_lbl.Size = new System.Drawing.Size(53, 17);
         this.name_lbl.TabIndex = 3;
         this.name_lbl.Text = "Name :";
         // 
         // phone_lbl
         // 
         this.phone_lbl.AutoSize = true;
         this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.phone_lbl.Location = new System.Drawing.Point(12, 71);
         this.phone_lbl.Name = "phone_lbl";
         this.phone_lbl.Size = new System.Drawing.Size(53, 16);
         this.phone_lbl.TabIndex = 4;
         this.phone_lbl.Text = "Phone :";
         // 
         // gender_lbl
         // 
         this.gender_lbl.AutoSize = true;
         this.gender_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gender_lbl.Location = new System.Drawing.Point(12, 97);
         this.gender_lbl.Name = "gender_lbl";
         this.gender_lbl.Size = new System.Drawing.Size(59, 16);
         this.gender_lbl.TabIndex = 5;
         this.gender_lbl.Text = "Gender :";
         // 
         // save_btn
         // 
         this.save_btn.Location = new System.Drawing.Point(327, 378);
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
         this.gender_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gender_ComboBox.FormattingEnabled = true;
         this.gender_ComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
         this.gender_ComboBox.Location = new System.Drawing.Point(75, 94);
         this.gender_ComboBox.Name = "gender_ComboBox";
         this.gender_ComboBox.Size = new System.Drawing.Size(100, 23);
         this.gender_ComboBox.TabIndex = 7;
         // 
         // age_lbl
         // 
         this.age_lbl.AutoSize = true;
         this.age_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.age_lbl.Location = new System.Drawing.Point(194, 97);
         this.age_lbl.Name = "age_lbl";
         this.age_lbl.Size = new System.Drawing.Size(39, 16);
         this.age_lbl.TabIndex = 8;
         this.age_lbl.Text = "Age :";
         // 
         // age_text
         // 
         this.age_text.Location = new System.Drawing.Point(234, 96);
         this.age_text.Name = "age_text";
         this.age_text.Size = new System.Drawing.Size(119, 20);
         this.age_text.TabIndex = 9;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.addDisease_txt);
         this.groupBox1.Controls.Add(this.addDisease_btn);
         this.groupBox1.Controls.Add(this.disease_checklist);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.Location = new System.Drawing.Point(16, 136);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(391, 207);
         this.groupBox1.TabIndex = 10;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Medical History";
         // 
         // addDisease_txt
         // 
         this.addDisease_txt.Location = new System.Drawing.Point(96, 175);
         this.addDisease_txt.Name = "addDisease_txt";
         this.addDisease_txt.Size = new System.Drawing.Size(282, 21);
         this.addDisease_txt.TabIndex = 2;
         // 
         // addDisease_btn
         // 
         this.addDisease_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addDisease_btn.Location = new System.Drawing.Point(6, 174);
         this.addDisease_btn.Name = "addDisease_btn";
         this.addDisease_btn.Size = new System.Drawing.Size(75, 23);
         this.addDisease_btn.TabIndex = 1;
         this.addDisease_btn.Text = "Add new";
         this.addDisease_btn.UseVisualStyleBackColor = true;
         this.addDisease_btn.Click += new System.EventHandler(this.addDisease_btn_Click);
         // 
         // disease_checklist
         // 
         this.disease_checklist.CheckOnClick = true;
         this.disease_checklist.FormattingEnabled = true;
         this.disease_checklist.Location = new System.Drawing.Point(13, 20);
         this.disease_checklist.MultiColumn = true;
         this.disease_checklist.Name = "disease_checklist";
         this.disease_checklist.Size = new System.Drawing.Size(365, 148);
         this.disease_checklist.Sorted = true;
         this.disease_checklist.TabIndex = 0;
         // 
         // AddPatientForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(414, 413);
         this.Controls.Add(this.groupBox1);
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
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox disease_checklist;
        private System.Windows.Forms.TextBox addDisease_txt;
        private System.Windows.Forms.Button addDisease_btn;
    }
}