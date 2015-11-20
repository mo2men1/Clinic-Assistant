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
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.diagnosis_textBox = new System.Windows.Forms.TextBox();
         this.tooth_textBox = new System.Windows.Forms.TextBox();
         this.treatmet_textBox = new System.Windows.Forms.TextBox();
         this.cost_num = new System.Windows.Forms.NumericUpDown();
         this.paid_num = new System.Windows.Forms.NumericUpDown();
         this.remaining_num = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)(this.cost_num)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.paid_num)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.remaining_num)).BeginInit();
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
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(14, 162);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(31, 13);
         this.label8.TabIndex = 11;
         this.label8.Text = "Cost:";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(14, 214);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(60, 13);
         this.label9.TabIndex = 12;
         this.label9.Text = "Remaining:";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(14, 188);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(31, 13);
         this.label10.TabIndex = 13;
         this.label10.Text = "Paid:";
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
         // cost_num
         // 
         this.cost_num.Location = new System.Drawing.Point(101, 160);
         this.cost_num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.cost_num.Name = "cost_num";
         this.cost_num.Size = new System.Drawing.Size(120, 20);
         this.cost_num.TabIndex = 7;
         this.cost_num.ValueChanged += new System.EventHandler(this.cost_num_ValueChanged);
         // 
         // paid_num
         // 
         this.paid_num.Location = new System.Drawing.Point(102, 186);
         this.paid_num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.paid_num.Name = "paid_num";
         this.paid_num.Size = new System.Drawing.Size(120, 20);
         this.paid_num.TabIndex = 9;
         this.paid_num.ValueChanged += new System.EventHandler(this.paid_num_ValueChanged);
         // 
         // remaining_num
         // 
         this.remaining_num.Location = new System.Drawing.Point(101, 212);
         this.remaining_num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.remaining_num.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
         this.remaining_num.Name = "remaining_num";
         this.remaining_num.Size = new System.Drawing.Size(120, 20);
         this.remaining_num.TabIndex = 10;
         // 
         // AddVisitForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(326, 365);
         this.Controls.Add(this.remaining_num);
         this.Controls.Add(this.paid_num);
         this.Controls.Add(this.cost_num);
         this.Controls.Add(this.treatmet_textBox);
         this.Controls.Add(this.tooth_textBox);
         this.Controls.Add(this.diagnosis_textBox);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.date_dateTimePicker);
         this.Controls.Add(this.saveVisitBtn);
         this.Controls.Add(this.complaint_textBox);
         this.Controls.Add(this.label2);
         this.Name = "AddVisitForm";
         this.Text = "AddVisitForm";
         ((System.ComponentModel.ISupportInitialize)(this.cost_num)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.paid_num)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.remaining_num)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox complaint_textBox;
        private System.Windows.Forms.Button saveVisitBtn;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox diagnosis_textBox;
        private System.Windows.Forms.TextBox tooth_textBox;
        private System.Windows.Forms.TextBox treatmet_textBox;
        private System.Windows.Forms.NumericUpDown cost_num;
        private System.Windows.Forms.NumericUpDown paid_num;
        private System.Windows.Forms.NumericUpDown remaining_num;
    }
}