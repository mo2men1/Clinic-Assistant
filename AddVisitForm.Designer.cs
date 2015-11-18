namespace Clinic_Assistant
{
    partial class AddVisitForm
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
         this.label2 = new System.Windows.Forms.Label();
         this.complaint_textBox = new System.Windows.Forms.TextBox();
         this.saveVisitBtn = new System.Windows.Forms.Button();
         this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.label1 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.diagnosis_textBox = new System.Windows.Forms.TextBox();
         this.tooth_textBox = new System.Windows.Forms.TextBox();
         this.treatmet_textBox = new System.Windows.Forms.TextBox();
         this.dateDiagnosedDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
         this.dateCompletedDateTimePicker3 = new System.Windows.Forms.DateTimePicker();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
         this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
         this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 51);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Complaint:";
         // 
         // complaint_textBox
         // 
         this.complaint_textBox.Location = new System.Drawing.Point(102, 51);
         this.complaint_textBox.Name = "complaint_textBox";
         this.complaint_textBox.Size = new System.Drawing.Size(200, 20);
         this.complaint_textBox.TabIndex = 1;
         this.complaint_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // saveVisitBtn
         // 
         this.saveVisitBtn.Location = new System.Drawing.Point(227, 330);
         this.saveVisitBtn.Name = "saveVisitBtn";
         this.saveVisitBtn.Size = new System.Drawing.Size(75, 23);
         this.saveVisitBtn.TabIndex = 11;
         this.saveVisitBtn.Text = "Save";
         this.saveVisitBtn.UseVisualStyleBackColor = true;
         this.saveVisitBtn.Click += new System.EventHandler(this.saveVisitBtn_Click);
         // 
         // date_dateTimePicker
         // 
         this.date_dateTimePicker.Location = new System.Drawing.Point(102, 25);
         this.date_dateTimePicker.Name = "date_dateTimePicker";
         this.date_dateTimePicker.Size = new System.Drawing.Size(200, 20);
         this.date_dateTimePicker.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(33, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Date:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 159);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(87, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Date Diagnosed:";
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 131);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(58, 13);
         this.label4.TabIndex = 7;
         this.label4.Text = "Treatment:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 104);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(38, 13);
         this.label5.TabIndex = 8;
         this.label5.Text = "Tooth:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(12, 78);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(56, 13);
         this.label6.TabIndex = 9;
         this.label6.Text = "Diagnosis:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(12, 185);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(86, 13);
         this.label7.TabIndex = 10;
         this.label7.Text = "Date Completed:";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(12, 211);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(31, 13);
         this.label8.TabIndex = 11;
         this.label8.Text = "Cost:";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(12, 289);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(60, 13);
         this.label9.TabIndex = 12;
         this.label9.Text = "Remaining:";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(12, 263);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(31, 13);
         this.label10.TabIndex = 13;
         this.label10.Text = "Paid:";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(14, 237);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(31, 13);
         this.label11.TabIndex = 14;
         this.label11.Text = "A.D.:";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(146, 330);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 15;
         this.button1.Text = "Add X-Ray";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // diagnosis_textBox
         // 
         this.diagnosis_textBox.Location = new System.Drawing.Point(102, 78);
         this.diagnosis_textBox.Name = "diagnosis_textBox";
         this.diagnosis_textBox.Size = new System.Drawing.Size(200, 20);
         this.diagnosis_textBox.TabIndex = 2;
         // 
         // tooth_textBox
         // 
         this.tooth_textBox.Location = new System.Drawing.Point(102, 104);
         this.tooth_textBox.Name = "tooth_textBox";
         this.tooth_textBox.Size = new System.Drawing.Size(200, 20);
         this.tooth_textBox.TabIndex = 3;
         // 
         // treatmet_textBox
         // 
         this.treatmet_textBox.Location = new System.Drawing.Point(102, 131);
         this.treatmet_textBox.Name = "treatmet_textBox";
         this.treatmet_textBox.Size = new System.Drawing.Size(200, 20);
         this.treatmet_textBox.TabIndex = 4;
         // 
         // dateDiagnosedDateTimePicker2
         // 
         this.dateDiagnosedDateTimePicker2.Location = new System.Drawing.Point(102, 157);
         this.dateDiagnosedDateTimePicker2.Name = "dateDiagnosedDateTimePicker2";
         this.dateDiagnosedDateTimePicker2.Size = new System.Drawing.Size(200, 20);
         this.dateDiagnosedDateTimePicker2.TabIndex = 5;
         // 
         // dateCompletedDateTimePicker3
         // 
         this.dateCompletedDateTimePicker3.Location = new System.Drawing.Point(104, 183);
         this.dateCompletedDateTimePicker3.Name = "dateCompletedDateTimePicker3";
         this.dateCompletedDateTimePicker3.Size = new System.Drawing.Size(200, 20);
         this.dateCompletedDateTimePicker3.TabIndex = 6;
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(104, 211);
         this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
         this.numericUpDown1.TabIndex = 7;
         // 
         // numericUpDown2
         // 
         this.numericUpDown2.Location = new System.Drawing.Point(104, 237);
         this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.numericUpDown2.Name = "numericUpDown2";
         this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
         this.numericUpDown2.TabIndex = 8;
         // 
         // numericUpDown3
         // 
         this.numericUpDown3.Location = new System.Drawing.Point(104, 263);
         this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.numericUpDown3.Name = "numericUpDown3";
         this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
         this.numericUpDown3.TabIndex = 9;
         // 
         // numericUpDown4
         // 
         this.numericUpDown4.Location = new System.Drawing.Point(104, 289);
         this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.numericUpDown4.Name = "numericUpDown4";
         this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
         this.numericUpDown4.TabIndex = 10;
         // 
         // AddVisitForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(326, 365);
         this.Controls.Add(this.numericUpDown4);
         this.Controls.Add(this.numericUpDown3);
         this.Controls.Add(this.numericUpDown2);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.dateCompletedDateTimePicker3);
         this.Controls.Add(this.dateDiagnosedDateTimePicker2);
         this.Controls.Add(this.treatmet_textBox);
         this.Controls.Add(this.tooth_textBox);
         this.Controls.Add(this.diagnosis_textBox);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.date_dateTimePicker);
         this.Controls.Add(this.saveVisitBtn);
         this.Controls.Add(this.complaint_textBox);
         this.Controls.Add(this.label2);
         this.Name = "AddVisitForm";
         this.Text = "AddVisitForm";
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox complaint_textBox;
        private System.Windows.Forms.Button saveVisitBtn;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox diagnosis_textBox;
        private System.Windows.Forms.TextBox tooth_textBox;
        private System.Windows.Forms.TextBox treatmet_textBox;
        private System.Windows.Forms.DateTimePicker dateDiagnosedDateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateCompletedDateTimePicker3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}