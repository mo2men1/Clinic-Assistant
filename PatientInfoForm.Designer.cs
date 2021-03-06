﻿namespace Clinic_Assistant
{
    partial class PatientInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.gender_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.medicalHistory_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.visits_dataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.CostSum_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PaidSum_txt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RemainingSum_txt = new System.Windows.Forms.Label();
            this.edit_visit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visits_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone:";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(174, 25);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Size = new System.Drawing.Size(176, 20);
            this.name_txt.TabIndex = 8;
            // 
            // age_txt
            // 
            this.age_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txt.Location = new System.Drawing.Point(402, 25);
            this.age_txt.Name = "age_txt";
            this.age_txt.ReadOnly = true;
            this.age_txt.Size = new System.Drawing.Size(71, 21);
            this.age_txt.TabIndex = 9;
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(723, 25);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.ReadOnly = true;
            this.phone_txt.Size = new System.Drawing.Size(163, 21);
            this.phone_txt.TabIndex = 10;
            // 
            // gender_txt
            // 
            this.gender_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_txt.Location = new System.Drawing.Point(550, 25);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.ReadOnly = true;
            this.gender_txt.Size = new System.Drawing.Size(100, 21);
            this.gender_txt.TabIndex = 11;
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(73, 25);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(36, 21);
            this.id_txt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID:";
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(576, 358);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(114, 28);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.Text = "Delete Patient";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Medical History :";
            // 
            // medicalHistory_txt
            // 
            this.medicalHistory_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicalHistory_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalHistory_txt.Location = new System.Drawing.Point(148, 51);
            this.medicalHistory_txt.Multiline = true;
            this.medicalHistory_txt.Name = "medicalHistory_txt";
            this.medicalHistory_txt.ReadOnly = true;
            this.medicalHistory_txt.Size = new System.Drawing.Size(277, 42);
            this.medicalHistory_txt.TabIndex = 16;
            this.medicalHistory_txt.Text = " None.";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(816, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Visit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // visits_dataGridView
            // 
            this.visits_dataGridView.AllowUserToAddRows = false;
            this.visits_dataGridView.AllowUserToDeleteRows = false;
            this.visits_dataGridView.AllowUserToOrderColumns = true;
            this.visits_dataGridView.AllowUserToResizeRows = false;
            this.visits_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.visits_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.visits_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visits_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits_dataGridView.Location = new System.Drawing.Point(37, 112);
            this.visits_dataGridView.MultiSelect = false;
            this.visits_dataGridView.Name = "visits_dataGridView";
            this.visits_dataGridView.ReadOnly = true;
            this.visits_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.visits_dataGridView.RowHeadersVisible = false;
            this.visits_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visits_dataGridView.Size = new System.Drawing.Size(849, 218);
            this.visits_dataGridView.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sum of costs: ";
            // 
            // CostSum_txt
            // 
            this.CostSum_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CostSum_txt.AutoSize = true;
            this.CostSum_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostSum_txt.Location = new System.Drawing.Point(117, 345);
            this.CostSum_txt.Name = "CostSum_txt";
            this.CostSum_txt.Size = new System.Drawing.Size(0, 15);
            this.CostSum_txt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Paid: ";
            // 
            // PaidSum_txt
            // 
            this.PaidSum_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaidSum_txt.AutoSize = true;
            this.PaidSum_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidSum_txt.Location = new System.Drawing.Point(117, 370);
            this.PaidSum_txt.Name = "PaidSum_txt";
            this.PaidSum_txt.Size = new System.Drawing.Size(0, 15);
            this.PaidSum_txt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(221, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Remaining: ";
            // 
            // RemainingSum_txt
            // 
            this.RemainingSum_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemainingSum_txt.AutoSize = true;
            this.RemainingSum_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingSum_txt.Location = new System.Drawing.Point(301, 372);
            this.RemainingSum_txt.Name = "RemainingSum_txt";
            this.RemainingSum_txt.Size = new System.Drawing.Size(0, 15);
            this.RemainingSum_txt.TabIndex = 24;
            // 
            // edit_visit_btn
            // 
            this.edit_visit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_visit_btn.Enabled = false;
            this.edit_visit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_visit_btn.Location = new System.Drawing.Point(696, 358);
            this.edit_visit_btn.Name = "edit_visit_btn";
            this.edit_visit_btn.Size = new System.Drawing.Size(114, 28);
            this.edit_visit_btn.TabIndex = 25;
            this.edit_visit_btn.Text = "Edit Visit";
            this.edit_visit_btn.UseVisualStyleBackColor = true;
            this.edit_visit_btn.Click += new System.EventHandler(this.edit_visit_btn_Click);
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 398);
            this.Controls.Add(this.edit_visit_btn);
            this.Controls.Add(this.RemainingSum_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PaidSum_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CostSum_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.visits_dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.medicalHistory_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.gender_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(928, 436);
            this.Name = "PatientInfoForm";
            this.Text = "Patient Info";
            ((System.ComponentModel.ISupportInitialize)(this.visits_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox gender_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox medicalHistory_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView visits_dataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CostSum_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PaidSum_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RemainingSum_txt;
        private System.Windows.Forms.Button edit_visit_btn;

    }
}