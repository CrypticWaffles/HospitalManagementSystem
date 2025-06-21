namespace HospitalManager
{
    partial class AppointmentScheduling
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
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.usersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagerDataSetAppointments = new HospitalManager.HospitalManagerDataSetAppointments();
            this.dataGridView_appointment = new System.Windows.Forms.DataGridView();
            this.appointmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSpecialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagerDataSetAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_doctorName = new System.Windows.Forms.TextBox();
            this.textBox_notes = new System.Windows.Forms.TextBox();
            this.textBox_startTime = new System.Windows.Forms.TextBox();
            this.textBox_doctorSpecialty = new System.Windows.Forms.TextBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.usersTableAdapter = new HospitalManager.HospitalManagerDataSetAppointmentsTableAdapters.usersTableAdapter();
            this.appointmentsTableAdapter = new HospitalManager.HospitalManagerDataSetAppointmentsTableAdapters.appointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSetAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSetAppointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AutoGenerateColumns = false;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView_user.DataSource = this.usersBindingSource;
            this.dataGridView_user.Location = new System.Drawing.Point(30, 74);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowHeadersWidth = 62;
            this.dataGridView_user.RowTemplate.Height = 28;
            this.dataGridView_user.Size = new System.Drawing.Size(518, 391);
            this.dataGridView_user.TabIndex = 15;
            this.dataGridView_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellContentClick);
            this.dataGridView_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellContentClick);
            // 
            // usersIdDataGridViewTextBoxColumn
            // 
            this.usersIdDataGridViewTextBoxColumn.DataPropertyName = "usersId";
            this.usersIdDataGridViewTextBoxColumn.HeaderText = "usersId";
            this.usersIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usersIdDataGridViewTextBoxColumn.Name = "usersIdDataGridViewTextBoxColumn";
            this.usersIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.hospitalManagerDataSetAppointments;
            // 
            // hospitalManagerDataSetAppointments
            // 
            this.hospitalManagerDataSetAppointments.DataSetName = "HospitalManagerDataSetAppointments";
            this.hospitalManagerDataSetAppointments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_appointment
            // 
            this.dataGridView_appointment.AutoGenerateColumns = false;
            this.dataGridView_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_appointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorSpecialtyDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView_appointment.DataSource = this.appointmentsBindingSource;
            this.dataGridView_appointment.Location = new System.Drawing.Point(597, 74);
            this.dataGridView_appointment.Name = "dataGridView_appointment";
            this.dataGridView_appointment.RowHeadersWidth = 62;
            this.dataGridView_appointment.RowTemplate.Height = 28;
            this.dataGridView_appointment.Size = new System.Drawing.Size(515, 391);
            this.dataGridView_appointment.TabIndex = 29;
            this.dataGridView_appointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_appointment_CellContentClick);
            this.dataGridView_appointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_appointment_CellContentClick);
            // 
            // appointmentIdDataGridViewTextBoxColumn
            // 
            this.appointmentIdDataGridViewTextBoxColumn.DataPropertyName = "appointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.HeaderText = "appointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.appointmentIdDataGridViewTextBoxColumn.Name = "appointmentIdDataGridViewTextBoxColumn";
            this.appointmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "doctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "doctorName";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // doctorSpecialtyDataGridViewTextBoxColumn
            // 
            this.doctorSpecialtyDataGridViewTextBoxColumn.DataPropertyName = "doctorSpecialty";
            this.doctorSpecialtyDataGridViewTextBoxColumn.HeaderText = "doctorSpecialty";
            this.doctorSpecialtyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.doctorSpecialtyDataGridViewTextBoxColumn.Name = "doctorSpecialtyDataGridViewTextBoxColumn";
            this.doctorSpecialtyDataGridViewTextBoxColumn.Width = 150;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "startTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 150;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "appointments";
            this.appointmentsBindingSource.DataSource = this.hospitalManagerDataSetAppointmentsBindingSource;
            // 
            // hospitalManagerDataSetAppointmentsBindingSource
            // 
            this.hospitalManagerDataSetAppointmentsBindingSource.DataSource = this.hospitalManagerDataSetAppointments;
            this.hospitalManagerDataSetAppointmentsBindingSource.Position = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(199, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Patient Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(734, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Appointment Information";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(1019, 537);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(93, 32);
            this.button_back.TabIndex = 32;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(794, 537);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(93, 32);
            this.button_add.TabIndex = 33;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(902, 537);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(93, 32);
            this.button_update.TabIndex = 34;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Doctor Name";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(790, 492);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(56, 20);
            this.labe.TabIndex = 36;
            this.labe.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Doctor Specialty";
            // 
            // textBox_doctorName
            // 
            this.textBox_doctorName.Location = new System.Drawing.Point(128, 489);
            this.textBox_doctorName.Name = "textBox_doctorName";
            this.textBox_doctorName.Size = new System.Drawing.Size(271, 26);
            this.textBox_doctorName.TabIndex = 40;
            // 
            // textBox_notes
            // 
            this.textBox_notes.Location = new System.Drawing.Point(499, 540);
            this.textBox_notes.Name = "textBox_notes";
            this.textBox_notes.Size = new System.Drawing.Size(271, 26);
            this.textBox_notes.TabIndex = 41;
            // 
            // textBox_startTime
            // 
            this.textBox_startTime.Location = new System.Drawing.Point(499, 489);
            this.textBox_startTime.Name = "textBox_startTime";
            this.textBox_startTime.Size = new System.Drawing.Size(271, 26);
            this.textBox_startTime.TabIndex = 42;
            // 
            // textBox_doctorSpecialty
            // 
            this.textBox_doctorSpecialty.Location = new System.Drawing.Point(137, 543);
            this.textBox_doctorSpecialty.Name = "textBox_doctorSpecialty";
            this.textBox_doctorSpecialty.Size = new System.Drawing.Size(262, 26);
            this.textBox_doctorSpecialty.TabIndex = 43;
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Booked",
            "Canceled",
            "Completed"});
            this.comboBox_status.Location = new System.Drawing.Point(861, 487);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(189, 28);
            this.comboBox_status.TabIndex = 45;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // AppointmentScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 596);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.textBox_doctorSpecialty);
            this.Controls.Add(this.textBox_startTime);
            this.Controls.Add(this.textBox_notes);
            this.Controls.Add(this.textBox_doctorName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_appointment);
            this.Controls.Add(this.dataGridView_user);
            this.Name = "AppointmentScheduling";
            this.Text = "AppointmetScheduling";
            this.Load += new System.EventHandler(this.AppointmetScheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSetAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagerDataSetAppointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.BindingSource hospitalManagerDataSetAppointmentsBindingSource;
        private HospitalManagerDataSetAppointments hospitalManagerDataSetAppointments;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HospitalManagerDataSetAppointmentsTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_appointment;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private HospitalManagerDataSetAppointmentsTableAdapters.appointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSpecialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_doctorName;
        private System.Windows.Forms.TextBox textBox_notes;
        private System.Windows.Forms.TextBox textBox_startTime;
        private System.Windows.Forms.TextBox textBox_doctorSpecialty;
        private System.Windows.Forms.ComboBox comboBox_status;
    }
}