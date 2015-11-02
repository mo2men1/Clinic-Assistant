namespace Clinic_Assistant
{
   partial class Home
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
            this.addPatient_btn = new System.Windows.Forms.Button();
            this.patients_dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.patients_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPatient_btn
            // 
            this.addPatient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatient_btn.Location = new System.Drawing.Point(442, 352);
            this.addPatient_btn.Name = "addPatient_btn";
            this.addPatient_btn.Size = new System.Drawing.Size(115, 43);
            this.addPatient_btn.TabIndex = 0;
            this.addPatient_btn.Text = "Add";
            this.addPatient_btn.UseVisualStyleBackColor = true;
            this.addPatient_btn.Click += new System.EventHandler(this.addPatient_btn_Click);
            // 
            // patients_dataGridView
            // 
            this.patients_dataGridView.AllowUserToAddRows = false;
            this.patients_dataGridView.AllowUserToDeleteRows = false;
            this.patients_dataGridView.AllowUserToOrderColumns = true;
            this.patients_dataGridView.AllowUserToResizeRows = false;
            this.patients_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.patients_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patients_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patients_dataGridView.Location = new System.Drawing.Point(13, 51);
            this.patients_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.patients_dataGridView.Name = "patients_dataGridView";
            this.patients_dataGridView.ReadOnly = true;
            this.patients_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.patients_dataGridView.RowHeadersVisible = false;
            this.patients_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patients_dataGridView.Size = new System.Drawing.Size(543, 294);
            this.patients_dataGridView.TabIndex = 2;
            this.patients_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patients_dataGridView_CellContentClick);
            this.patients_dataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patients_dataGridView_KeyPress);
            // 
            // delete_btn
            // 
            this.delete_btn.Enabled = false;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(321, 352);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(115, 45);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search :";
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(69, 21);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(487, 21);
            this.search_txt.TabIndex = 4;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(569, 407);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.patients_dataGridView);
            this.Controls.Add(this.addPatient_btn);
            this.Name = "Home";
            this.Text = "Clinic Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.patients_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button addPatient_btn;
      private System.Windows.Forms.DataGridView patients_dataGridView;
      private System.Windows.Forms.Button delete_btn;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox search_txt;
   }
}

