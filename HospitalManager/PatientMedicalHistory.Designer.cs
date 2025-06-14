﻿namespace HospitalManager
{
    partial class PatientMedicalHistory
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_medicalHistory = new System.Windows.Forms.DataGridView();
            this.textBox_recordDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_patientName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_notes = new System.Windows.Forms.TextBox();
            this.textBox_treatment = new System.Windows.Forms.TextBox();
            this.textBox_diagnosis = new System.Windows.Forms.TextBox();
            this.hospitalManagerDataSet = new HospitalManager.HospitalManagerDataSet();
            this.medicalHistoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalHistoriesTableAdapter = new HospitalManager.HospitalManagerDataSetTableAdapters.MedicalHistoriesTableAdapter();
            this.recordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medicalHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_medicalHistory
            // 
            this.dataGridView_medicalHistory.AutoGenerateColumns = false;
            this.dataGridView_medicalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_medicalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordDateDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView_medicalHistory.DataSource = this.medicalHistoriesBindingSource;
            this.dataGridView_medicalHistory.Location = new System.Drawing.Point(43, 78);
            this.dataGridView_medicalHistory.Name = "dataGridView_medicalHistory";
            this.dataGridView_medicalHistory.RowHeadersWidth = 62;
            this.dataGridView_medicalHistory.RowTemplate.Height = 28;
            this.dataGridView_medicalHistory.Size = new System.Drawing.Size(713, 277);
            this.dataGridView_medicalHistory.TabIndex = 0;
            // 
            // textBox_recordDate
            // 
            this.textBox_recordDate.Location = new System.Drawing.Point(196, 390);
            this.textBox_recordDate.Name = "textBox_recordDate";
            this.textBox_recordDate.Size = new System.Drawing.Size(338, 26);
            this.textBox_recordDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record Date";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(692, 533);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(83, 30);
            this.button_back.TabIndex = 24;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(673, 383);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(83, 33);
            this.button_edit.TabIndex = 23;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(573, 383);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(84, 33);
            this.button_add.TabIndex = 22;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(672, 435);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(84, 33);
            this.button_search.TabIndex = 21;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(573, 435);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(83, 33);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // label_patientName
            // 
            this.label_patientName.AutoSize = true;
            this.label_patientName.Location = new System.Drawing.Point(368, 31);
            this.label_patientName.Name = "label_patientName";
            this.label_patientName.Size = new System.Drawing.Size(21, 20);
            this.label_patientName.TabIndex = 25;
            this.label_patientName.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Treatment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Diagnosis";
            // 
            // textBox_notes
            // 
            this.textBox_notes.Location = new System.Drawing.Point(196, 533);
            this.textBox_notes.Name = "textBox_notes";
            this.textBox_notes.Size = new System.Drawing.Size(338, 26);
            this.textBox_notes.TabIndex = 29;
            // 
            // textBox_treatment
            // 
            this.textBox_treatment.Location = new System.Drawing.Point(196, 485);
            this.textBox_treatment.Name = "textBox_treatment";
            this.textBox_treatment.Size = new System.Drawing.Size(338, 26);
            this.textBox_treatment.TabIndex = 30;
            // 
            // textBox_diagnosis
            // 
            this.textBox_diagnosis.Location = new System.Drawing.Point(196, 438);
            this.textBox_diagnosis.Name = "textBox_diagnosis";
            this.textBox_diagnosis.Size = new System.Drawing.Size(338, 26);
            this.textBox_diagnosis.TabIndex = 31;
            // 
            // hospitalManagerDataSet
            // 
            this.hospitalManagerDataSet.DataSetName = "HospitalManagerDataSet";
            this.hospitalManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalHistoriesBindingSource
            // 
            this.medicalHistoriesBindingSource.DataMember = "MedicalHistories";
            this.medicalHistoriesBindingSource.DataSource = this.hospitalManagerDataSet;
            // 
            // medicalHistoriesTableAdapter
            // 
            this.medicalHistoriesTableAdapter.ClearBeforeFill = true;
            // 
            // recordDateDataGridViewTextBoxColumn
            // 
            this.recordDateDataGridViewTextBoxColumn.DataPropertyName = "RecordDate";
            this.recordDateDataGridViewTextBoxColumn.HeaderText = "RecordDate";
            this.recordDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recordDateDataGridViewTextBoxColumn.Name = "recordDateDataGridViewTextBoxColumn";
            this.recordDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            this.diagnosisDataGridViewTextBoxColumn.Width = 150;
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            this.treatmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 150;
            // 
            // PatientMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.textBox_diagnosis);
            this.Controls.Add(this.textBox_treatment);
            this.Controls.Add(this.textBox_notes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_patientName);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_recordDate);
            this.Controls.Add(this.dataGridView_medicalHistory);
            this.Name = "PatientMedicalHistory";
            this.Text = "PatientMedicalHistory";
            this.Load += new System.EventHandler(this.PatientMedicalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medicalHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_medicalHistory;
        private System.Windows.Forms.TextBox textBox_recordDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_patientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_notes;
        private System.Windows.Forms.TextBox textBox_treatment;
        private System.Windows.Forms.TextBox textBox_diagnosis;
        private HospitalManagerDataSet hospitalManagerDataSet;
        private System.Windows.Forms.BindingSource medicalHistoriesBindingSource;
        private HospitalManagerDataSetTableAdapters.MedicalHistoriesTableAdapter medicalHistoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}