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
            this.dataGridView_patientRecords = new System.Windows.Forms.DataGridView();
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
            this.hospitalManagerDataSet = new HospitalManager.HospitalManagerDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new HospitalManager.HospitalManagerDataSetTableAdapters.PatientsTableAdapter();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView_patientRecords.DataSource = this.patientsBindingSource;
            this.dataGridView_patientRecords.Location = new System.Drawing.Point(35, 64);
            this.dataGridView_patientRecords.Name = "dataGridView_patientRecords";
            this.dataGridView_patientRecords.RowHeadersWidth = 62;
            this.dataGridView_patientRecords.RowTemplate.Height = 28;
            this.dataGridView_patientRecords.Size = new System.Drawing.Size(667, 219);
            this.dataGridView_patientRecords.TabIndex = 0;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(465, 395);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(83, 33);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(564, 395);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(84, 33);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(465, 343);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(84, 33);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(565, 343);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(83, 33);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(136, 350);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(246, 26);
            this.textBox_lastName.TabIndex = 5;
            // 
            // textBox_dob
            // 
            this.textBox_dob.Location = new System.Drawing.Point(136, 399);
            this.textBox_dob.Name = "textBox_dob";
            this.textBox_dob.Size = new System.Drawing.Size(246, 26);
            this.textBox_dob.TabIndex = 6;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(136, 451);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(246, 26);
            this.textBox_gender.TabIndex = 7;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(136, 504);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(246, 26);
            this.textBox_address.TabIndex = 8;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(136, 549);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(246, 26);
            this.textBox_phoneNumber.TabIndex = 9;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(136, 307);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(246, 26);
            this.textBox_firstName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Name";
            // 
            // button_upload
            // 
            this.button_upload.Location = new System.Drawing.Point(510, 487);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(83, 30);
            this.button_upload.TabIndex = 18;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            // 
            // button_medicalHistory
            // 
            this.button_medicalHistory.Location = new System.Drawing.Point(446, 445);
            this.button_medicalHistory.Name = "button_medicalHistory";
            this.button_medicalHistory.Size = new System.Drawing.Size(229, 30);
            this.button_medicalHistory.TabIndex = 19;
            this.button_medicalHistory.Text = "View Patient Medical History";
            this.button_medicalHistory.UseVisualStyleBackColor = true;
            // 
            // hospitalManagerDataSet
            // 
            this.hospitalManagerDataSet.DataSetName = "HospitalManagerDataSet";
            this.hospitalManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.hospitalManagerDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
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
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(619, 574);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(83, 30);
            this.button_back.TabIndex = 20;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 616);
            this.Controls.Add(this.button_back);
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
            this.Controls.Add(this.dataGridView_patientRecords);
            this.Name = "PatientRecords";
            this.Text = "PatientRecords";
            this.Load += new System.EventHandler(this.PatientRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_patientRecords;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_back;
    }
}