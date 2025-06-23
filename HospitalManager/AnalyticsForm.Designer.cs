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
            this.dgv_patients = new System.Windows.Forms.DataGridView();
            this.btn_exportJson = new System.Windows.Forms.Button();
            this.btn_exportCsv = new System.Windows.Forms.Button();
            this.btn_exportXml = new System.Windows.Forms.Button();
            this.tbc_control = new System.Windows.Forms.TabControl();
            this.tbp_patients = new System.Windows.Forms.TabPage();
            this.tbp_inventory = new System.Windows.Forms.TabPage();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.btn_inventoryReport = new System.Windows.Forms.Button();
            this.cmb_invFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            this.tbc_control.SuspendLayout();
            this.tbp_patients.SuspendLayout();
            this.tbp_inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
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
            this.lbl_patientFilter.Location = new System.Drawing.Point(6, 3);
            this.lbl_patientFilter.Name = "lbl_patientFilter";
            this.lbl_patientFilter.Size = new System.Drawing.Size(124, 20);
            this.lbl_patientFilter.TabIndex = 0;
            this.lbl_patientFilter.Text = "Filter By Patient:";
            // 
            // cmb_patients
            // 
            this.cmb_patients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_patients.FormattingEnabled = true;
            this.cmb_patients.Location = new System.Drawing.Point(10, 27);
            this.cmb_patients.Name = "cmb_patients";
            this.cmb_patients.Size = new System.Drawing.Size(200, 28);
            this.cmb_patients.TabIndex = 1;
            this.cmb_patients.SelectedIndexChanged += new System.EventHandler(this.cmb_patients_SelectedIndexChanged);
            // 
            // btn_generalReport
            // 
            this.btn_generalReport.Location = new System.Drawing.Point(6, 424);
            this.btn_generalReport.Name = "btn_generalReport";
            this.btn_generalReport.Size = new System.Drawing.Size(144, 30);
            this.btn_generalReport.TabIndex = 2;
            this.btn_generalReport.Text = "Generate Report";
            this.btn_generalReport.UseVisualStyleBackColor = true;
            this.btn_generalReport.Click += new System.EventHandler(this.btn_generalReport_Click);
            // 
            // dgv_patients
            // 
            this.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patients.Location = new System.Drawing.Point(6, 61);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.RowHeadersWidth = 62;
            this.dgv_patients.RowTemplate.Height = 28;
            this.dgv_patients.Size = new System.Drawing.Size(780, 357);
            this.dgv_patients.TabIndex = 3;
            // 
            // btn_exportJson
            // 
            this.btn_exportJson.Location = new System.Drawing.Point(16, 514);
            this.btn_exportJson.Name = "btn_exportJson";
            this.btn_exportJson.Size = new System.Drawing.Size(150, 30);
            this.btn_exportJson.TabIndex = 4;
            this.btn_exportJson.Text = "Export as JSON";
            this.btn_exportJson.UseVisualStyleBackColor = true;
            this.btn_exportJson.Click += new System.EventHandler(this.btn_exportJson_Click);
            // 
            // btn_exportCsv
            // 
            this.btn_exportCsv.Location = new System.Drawing.Point(172, 514);
            this.btn_exportCsv.Name = "btn_exportCsv";
            this.btn_exportCsv.Size = new System.Drawing.Size(132, 30);
            this.btn_exportCsv.TabIndex = 4;
            this.btn_exportCsv.Text = "Export as CSV";
            this.btn_exportCsv.UseVisualStyleBackColor = true;
            this.btn_exportCsv.Click += new System.EventHandler(this.btn_exportCsv_Click);
            // 
            // btn_exportXml
            // 
            this.btn_exportXml.Location = new System.Drawing.Point(310, 514);
            this.btn_exportXml.Name = "btn_exportXml";
            this.btn_exportXml.Size = new System.Drawing.Size(132, 30);
            this.btn_exportXml.TabIndex = 4;
            this.btn_exportXml.Text = "Export as XML";
            this.btn_exportXml.UseVisualStyleBackColor = true;
            this.btn_exportXml.Click += new System.EventHandler(this.btn_exportXml_Click);
            // 
            // tbc_control
            // 
            this.tbc_control.Controls.Add(this.tbp_patients);
            this.tbc_control.Controls.Add(this.tbp_inventory);
            this.tbc_control.Location = new System.Drawing.Point(12, 12);
            this.tbc_control.Name = "tbc_control";
            this.tbc_control.SelectedIndex = 0;
            this.tbc_control.Size = new System.Drawing.Size(800, 496);
            this.tbc_control.TabIndex = 5;
            // 
            // tbp_patients
            // 
            this.tbp_patients.Controls.Add(this.dgv_patients);
            this.tbp_patients.Controls.Add(this.lbl_patientFilter);
            this.tbp_patients.Controls.Add(this.cmb_patients);
            this.tbp_patients.Controls.Add(this.btn_generalReport);
            this.tbp_patients.Location = new System.Drawing.Point(4, 29);
            this.tbp_patients.Name = "tbp_patients";
            this.tbp_patients.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_patients.Size = new System.Drawing.Size(792, 463);
            this.tbp_patients.TabIndex = 0;
            this.tbp_patients.Text = "Patient Reports";
            this.tbp_patients.UseVisualStyleBackColor = true;
            // 
            // tbp_inventory
            // 
            this.tbp_inventory.Controls.Add(this.dgv_inventory);
            this.tbp_inventory.Controls.Add(this.btn_inventoryReport);
            this.tbp_inventory.Controls.Add(this.cmb_invFilter);
            this.tbp_inventory.Controls.Add(this.label1);
            this.tbp_inventory.Location = new System.Drawing.Point(4, 29);
            this.tbp_inventory.Name = "tbp_inventory";
            this.tbp_inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_inventory.Size = new System.Drawing.Size(792, 463);
            this.tbp_inventory.TabIndex = 1;
            this.tbp_inventory.Text = "Inventory Analytics";
            this.tbp_inventory.UseVisualStyleBackColor = true;
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Location = new System.Drawing.Point(11, 65);
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.RowHeadersWidth = 62;
            this.dgv_inventory.RowTemplate.Height = 28;
            this.dgv_inventory.Size = new System.Drawing.Size(775, 356);
            this.dgv_inventory.TabIndex = 3;
            // 
            // btn_inventoryReport
            // 
            this.btn_inventoryReport.Location = new System.Drawing.Point(6, 427);
            this.btn_inventoryReport.Name = "btn_inventoryReport";
            this.btn_inventoryReport.Size = new System.Drawing.Size(140, 30);
            this.btn_inventoryReport.TabIndex = 2;
            this.btn_inventoryReport.Text = "Generate Report";
            this.btn_inventoryReport.UseVisualStyleBackColor = true;
            this.btn_inventoryReport.Click += new System.EventHandler(this.btn_inventoryReport_Click);
            // 
            // cmb_invFilter
            // 
            this.cmb_invFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_invFilter.FormattingEnabled = true;
            this.cmb_invFilter.Location = new System.Drawing.Point(11, 31);
            this.cmb_invFilter.Name = "cmb_invFilter";
            this.cmb_invFilter.Size = new System.Drawing.Size(200, 28);
            this.cmb_invFilter.TabIndex = 1;
            this.cmb_invFilter.SelectedIndexChanged += new System.EventHandler(this.cmb_invFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By Item Type:";
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 558);
            this.Controls.Add(this.tbc_control);
            this.Controls.Add(this.btn_exportXml);
            this.Controls.Add(this.btn_exportJson);
            this.Controls.Add(this.btn_exportCsv);
            this.Name = "AnalyticsForm";
            this.Text = "AnalyticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalyticsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).EndInit();
            this.tbc_control.ResumeLayout(false);
            this.tbp_patients.ResumeLayout(false);
            this.tbp_patients.PerformLayout();
            this.tbp_inventory.ResumeLayout(false);
            this.tbp_inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HospitalManagerDataSet hospitalManagerDataSet;
        private HospitalManagerDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private HospitalManagerDataSetTableAdapters.MedicalHistoriesTableAdapter medicalHistoriesTableAdapter;
        private System.Windows.Forms.Label lbl_patientFilter;
        private System.Windows.Forms.ComboBox cmb_patients;
        private System.Windows.Forms.Button btn_generalReport;
        private System.Windows.Forms.DataGridView dgv_patients;
        private System.Windows.Forms.Button btn_exportJson;
        private System.Windows.Forms.Button btn_exportCsv;
        private System.Windows.Forms.Button btn_exportXml;
        private System.Windows.Forms.TabControl tbc_control;
        private System.Windows.Forms.TabPage tbp_patients;
        private System.Windows.Forms.TabPage tbp_inventory;
        private System.Windows.Forms.ComboBox cmb_invFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.Button btn_inventoryReport;
    }
}