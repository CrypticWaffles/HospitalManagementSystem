namespace HospitalManager
{
    partial class AnalyticsForm
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
            this.hospitalManagerDataSet = new HospitalManager.HospitalManagerDataSet();
            this.patientsTableAdapter = new HospitalManager.HospitalManagerDataSetTableAdapters.PatientsTableAdapter();
            this.medicalHistoriesTableAdapter = new HospitalManager.HospitalManagerDataSetTableAdapters.MedicalHistoriesTableAdapter();
            this.lbl_patientFilter = new System.Windows.Forms.Label();
            this.cmb_patients = new System.Windows.Forms.ComboBox();
            this.btn_generalReport = new System.Windows.Forms.Button();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.btn_exportJson = new System.Windows.Forms.Button();
            this.btn_exportCsv = new System.Windows.Forms.Button();
            this.btn_exportXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalManagerDataSet
            // 
            this.hospitalManagerDataSet.DataSetName = "HospitalManagerDataSet";
            this.hospitalManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // medicalHistoriesTableAdapter
            // 
            this.medicalHistoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_patientFilter
            // 
            this.lbl_patientFilter.AutoSize = true;
            this.lbl_patientFilter.Location = new System.Drawing.Point(13, 13);
            this.lbl_patientFilter.Name = "lbl_patientFilter";
            this.lbl_patientFilter.Size = new System.Drawing.Size(124, 20);
            this.lbl_patientFilter.TabIndex = 0;
            this.lbl_patientFilter.Text = "Filter By Patient:";
            // 
            // cmb_patients
            // 
            this.cmb_patients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_patients.FormattingEnabled = true;
            this.cmb_patients.Location = new System.Drawing.Point(17, 37);
            this.cmb_patients.Name = "cmb_patients";
            this.cmb_patients.Size = new System.Drawing.Size(121, 28);
            this.cmb_patients.TabIndex = 1;
            this.cmb_patients.SelectedIndexChanged += new System.EventHandler(this.cmb_patients_SelectedIndexChanged);
            // 
            // btn_generalReport
            // 
            this.btn_generalReport.Location = new System.Drawing.Point(12, 425);
            this.btn_generalReport.Name = "btn_generalReport";
            this.btn_generalReport.Size = new System.Drawing.Size(212, 30);
            this.btn_generalReport.TabIndex = 2;
            this.btn_generalReport.Text = "Generate General Report";
            this.btn_generalReport.UseVisualStyleBackColor = true;
            this.btn_generalReport.Click += new System.EventHandler(this.btn_generalReport_Click);
            // 
            // dgv_report
            // 
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Location = new System.Drawing.Point(12, 71);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.RowHeadersWidth = 62;
            this.dgv_report.RowTemplate.Height = 28;
            this.dgv_report.Size = new System.Drawing.Size(689, 348);
            this.dgv_report.TabIndex = 3;
            // 
            // btn_exportJson
            // 
            this.btn_exportJson.Location = new System.Drawing.Point(12, 461);
            this.btn_exportJson.Name = "btn_exportJson";
            this.btn_exportJson.Size = new System.Drawing.Size(132, 30);
            this.btn_exportJson.TabIndex = 4;
            this.btn_exportJson.Text = "Export as JSON";
            this.btn_exportJson.UseVisualStyleBackColor = true;
            this.btn_exportJson.Click += new System.EventHandler(this.btn_exportJson_Click);
            // 
            // btn_exportCsv
            // 
            this.btn_exportCsv.Location = new System.Drawing.Point(150, 461);
            this.btn_exportCsv.Name = "btn_exportCsv";
            this.btn_exportCsv.Size = new System.Drawing.Size(132, 30);
            this.btn_exportCsv.TabIndex = 4;
            this.btn_exportCsv.Text = "Export as CSV";
            this.btn_exportCsv.UseVisualStyleBackColor = true;
            this.btn_exportCsv.Click += new System.EventHandler(this.btn_exportCsv_Click);
            // 
            // btn_exportXml
            // 
            this.btn_exportXml.Location = new System.Drawing.Point(288, 461);
            this.btn_exportXml.Name = "btn_exportXml";
            this.btn_exportXml.Size = new System.Drawing.Size(132, 30);
            this.btn_exportXml.TabIndex = 4;
            this.btn_exportXml.Text = "Export as XML";
            this.btn_exportXml.UseVisualStyleBackColor = true;
            this.btn_exportXml.Click += new System.EventHandler(this.btn_exportXml_Click);
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 503);
            this.Controls.Add(this.btn_exportXml);
            this.Controls.Add(this.btn_exportCsv);
            this.Controls.Add(this.btn_exportJson);
            this.Controls.Add(this.dgv_report);
            this.Controls.Add(this.btn_generalReport);
            this.Controls.Add(this.cmb_patients);
            this.Controls.Add(this.lbl_patientFilter);
            this.Name = "AnalyticsForm";
            this.Text = "AnalyticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalyticsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HospitalManagerDataSet hospitalManagerDataSet;
        private HospitalManagerDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private HospitalManagerDataSetTableAdapters.MedicalHistoriesTableAdapter medicalHistoriesTableAdapter;
        private System.Windows.Forms.Label lbl_patientFilter;
        private System.Windows.Forms.ComboBox cmb_patients;
        private System.Windows.Forms.Button btn_generalReport;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.Button btn_exportJson;
        private System.Windows.Forms.Button btn_exportCsv;
        private System.Windows.Forms.Button btn_exportXml;
    }
}