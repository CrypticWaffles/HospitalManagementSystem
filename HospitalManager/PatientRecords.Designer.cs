namespace HospitalManager
{
    partial class PatientRecords
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
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagerDataSet = new HospitalManager.HospitalManagerDataSet();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_dob = new System.Windows.Forms.TextBox();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_medicalHistory = new System.Windows.Forms.Button();
            this.patientsTableAdapter = new HospitalManager.HospitalManagerDataSetTableAdapters.PatientsTableAdapter();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_clear = new System.Windows.Forms.Button();
            this.dataGridView_patientRecords = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagerDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagerDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.hospitalManagerDataSet;
            // 
            // hospitalManagerDataSet
            // 
            this.hospitalManagerDataSet.DataSetName = "HospitalManagerDataSet";
            this.hospitalManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(494, 440);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(83, 33);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(593, 440);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(84, 33);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(494, 388);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(84, 33);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(594, 388);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(83, 33);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(165, 395);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(246, 26);
            this.textBox_lastName.TabIndex = 5;
            // 
            // textBox_dob
            // 
            this.textBox_dob.Location = new System.Drawing.Point(165, 444);
            this.textBox_dob.Name = "textBox_dob";
            this.textBox_dob.Size = new System.Drawing.Size(246, 26);
            this.textBox_dob.TabIndex = 6;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(165, 496);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(246, 26);
            this.textBox_gender.TabIndex = 7;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(165, 549);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(246, 26);
            this.textBox_address.TabIndex = 8;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(165, 594);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(246, 26);
            this.textBox_phoneNumber.TabIndex = 9;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(165, 352);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(246, 26);
            this.textBox_firstName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "DOB mm/dd/yyyy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Name";
            // 
            // button_upload
            // 
            this.button_upload.Location = new System.Drawing.Point(495, 542);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(83, 30);
            this.button_upload.TabIndex = 18;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_medicalHistory
            // 
            this.button_medicalHistory.Location = new System.Drawing.Point(475, 490);
            this.button_medicalHistory.Name = "button_medicalHistory";
            this.button_medicalHistory.Size = new System.Drawing.Size(229, 30);
            this.button_medicalHistory.TabIndex = 19;
            this.button_medicalHistory.Text = "View Patient Medical History";
            this.button_medicalHistory.UseVisualStyleBackColor = true;
            this.button_medicalHistory.Click += new System.EventHandler(this.button_medicalHistory_Click);
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn1
            // 
            this.dateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn1.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn1.Name = "dateOfBirthDataGridViewTextBoxColumn1";
            this.dateOfBirthDataGridViewTextBoxColumn1.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            this.phoneNumberDataGridViewTextBoxColumn1.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.Width = 150;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(594, 542);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(83, 30);
            this.button_clear.TabIndex = 21;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dataGridView_patientRecords
            // 
            this.dataGridView_patientRecords.AutoGenerateColumns = false;
            this.dataGridView_patientRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patientRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView_patientRecords.DataSource = this.patientsBindingSource3;
            this.dataGridView_patientRecords.Location = new System.Drawing.Point(29, 60);
            this.dataGridView_patientRecords.Name = "dataGridView_patientRecords";
            this.dataGridView_patientRecords.RowHeadersWidth = 62;
            this.dataGridView_patientRecords.RowTemplate.Height = 28;
            this.dataGridView_patientRecords.Size = new System.Drawing.Size(724, 269);
            this.dataGridView_patientRecords.TabIndex = 22;
            this.dataGridView_patientRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientRecords_CellContentClick);
            this.dataGridView_patientRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientRecords_CellContentClick);
            this.dataGridView_patientRecords.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientRecords_CellContentClick);
            this.dataGridView_patientRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientRecords_CellContentClick);
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // patientsBindingSource3
            // 
            this.patientsBindingSource3.DataMember = "Patients";
            this.patientsBindingSource3.DataSource = this.hospitalManagerDataSet;
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 668);
            this.Controls.Add(this.dataGridView_patientRecords);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_medicalHistory);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.textBox_phoneNumber);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_gender);
            this.Controls.Add(this.textBox_dob);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_delete);
            this.Name = "PatientRecords";
            this.Text = "PatientRecords";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientRecords_FormClosed);
            this.Load += new System.EventHandler(this.PatientRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_dob;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_medicalHistory;
        private HospitalManagerDataSet hospitalManagerDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private HospitalManagerDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DataGridView dataGridView_patientRecords;
        private System.Windows.Forms.BindingSource hospitalManagerDataSet2BindingSource;
        //private HospitalManagerDataSet2 hospitalManagerDataSet2;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        //private HospitalManagerDataSet2TableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientsBindingSource2;
        private System.Windows.Forms.BindingSource hospitalManagerDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource patientsBindingSource3;
    }
}