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
         ((System.ComponentModel.ISupportInitialize)(this.patients_dataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // addPatient_btn
         // 
         this.addPatient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addPatient_btn.Location = new System.Drawing.Point(494, 152);
         this.addPatient_btn.Name = "addPatient_btn";
         this.addPatient_btn.Size = new System.Drawing.Size(115, 43);
         this.addPatient_btn.TabIndex = 0;
         this.addPatient_btn.Text = "Add";
         this.addPatient_btn.UseVisualStyleBackColor = true;
         this.addPatient_btn.Click += new System.EventHandler(this.addPatient_btn_Click);
         // 
         // patients_dataGridView
         // 
         this.patients_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.patients_dataGridView.Location = new System.Drawing.Point(36, 108);
         this.patients_dataGridView.Name = "patients_dataGridView";
         this.patients_dataGridView.Size = new System.Drawing.Size(416, 326);
         this.patients_dataGridView.TabIndex = 1;
         // 
         // Home
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(649, 493);
         this.Controls.Add(this.patients_dataGridView);
         this.Controls.Add(this.addPatient_btn);
         this.Name = "Home";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.patients_dataGridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button addPatient_btn;
      private System.Windows.Forms.DataGridView patients_dataGridView;
   }
}

