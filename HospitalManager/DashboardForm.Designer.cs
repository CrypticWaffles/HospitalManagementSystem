namespace HospitalManager
{
    partial class DashboardForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_patient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_heartRate = new System.Windows.Forms.Label();
            this.lbl_bloodPressure = new System.Windows.Forms.Label();
            this.lbl_sp02 = new System.Windows.Forms.Label();
            this.lbl_beds = new System.Windows.Forms.Label();
            this.lbl_emergencies = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_temp);
            this.groupBox1.Controls.Add(this.lbl_sp02);
            this.groupBox1.Controls.Add(this.lbl_bloodPressure);
            this.groupBox1.Controls.Add(this.lbl_heartRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_patient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Monitoring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_emergencies);
            this.groupBox2.Controls.Add(this.lbl_beds);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dashboard";
            // 
            // cmb_patient
            // 
            this.cmb_patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_patient.FormattingEnabled = true;
            this.cmb_patient.Location = new System.Drawing.Point(116, 33);
            this.cmb_patient.Name = "cmb_patient";
            this.cmb_patient.Size = new System.Drawing.Size(150, 28);
            this.cmb_patient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // lbl_heartRate
            // 
            this.lbl_heartRate.AutoSize = true;
            this.lbl_heartRate.Location = new System.Drawing.Point(7, 79);
            this.lbl_heartRate.Name = "lbl_heartRate";
            this.lbl_heartRate.Size = new System.Drawing.Size(92, 20);
            this.lbl_heartRate.TabIndex = 2;
            this.lbl_heartRate.Text = "Heart Rate:";
            // 
            // lbl_bloodPressure
            // 
            this.lbl_bloodPressure.AutoSize = true;
            this.lbl_bloodPressure.Location = new System.Drawing.Point(7, 117);
            this.lbl_bloodPressure.Name = "lbl_bloodPressure";
            this.lbl_bloodPressure.Size = new System.Drawing.Size(121, 20);
            this.lbl_bloodPressure.TabIndex = 2;
            this.lbl_bloodPressure.Text = "Blood Pressure:";
            // 
            // lbl_sp02
            // 
            this.lbl_sp02.AutoSize = true;
            this.lbl_sp02.Location = new System.Drawing.Point(11, 161);
            this.lbl_sp02.Name = "lbl_sp02";
            this.lbl_sp02.Size = new System.Drawing.Size(51, 20);
            this.lbl_sp02.TabIndex = 4;
            this.lbl_sp02.Text = "Sp02:";
            // 
            // lbl_beds
            // 
            this.lbl_beds.AutoSize = true;
            this.lbl_beds.Location = new System.Drawing.Point(26, 36);
            this.lbl_beds.Name = "lbl_beds";
            this.lbl_beds.Size = new System.Drawing.Size(50, 20);
            this.lbl_beds.TabIndex = 4;
            this.lbl_beds.Text = "Beds:";
            // 
            // lbl_emergencies
            // 
            this.lbl_emergencies.AutoSize = true;
            this.lbl_emergencies.Location = new System.Drawing.Point(26, 79);
            this.lbl_emergencies.Name = "lbl_emergencies";
            this.lbl_emergencies.Size = new System.Drawing.Size(106, 20);
            this.lbl_emergencies.TabIndex = 4;
            this.lbl_emergencies.Text = "Emergencies:";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Location = new System.Drawing.Point(11, 196);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(104, 20);
            this.lbl_temp.TabIndex = 4;
            this.lbl_temp.Text = "Temperature:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_bloodPressure;
        private System.Windows.Forms.Label lbl_heartRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_patient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_sp02;
        private System.Windows.Forms.Label lbl_emergencies;
        private System.Windows.Forms.Label lbl_beds;
        private System.Windows.Forms.Label lbl_temp;
    }
}