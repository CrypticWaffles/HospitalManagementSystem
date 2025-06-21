using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HospitalManager.PatientMedicalHistory;
using static HospitalManager.PatientRecords;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManager
{
    public partial class AppointmentScheduling : Form
    {
        public AppointmentScheduling()
        {
            InitializeComponent();
        }

        public int UsersId;
        public int AppointmentId;
        public int UserId;
        public string DoctorName;
        public string DoctorSpecialty;
        public DateTime StartTime;
        public string Status;
        public string Notes;

        private void AppointmetScheduling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagerDataSetAppointments.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hospitalManagerDataSetAppointments.users);

        }

        private void dataGridView_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Checks if the clicked row is valid
                if (e.RowIndex >= 0)
                {
                    // Get the values from the clicked row
                    UsersId = Convert.ToInt32(dataGridView_user.Rows[e.RowIndex].Cells["usersIdDataGridViewTextBoxColumn"].Value);
                }

                // Clear appointment details (optional)
                button_clear_Click_1(sender, e);

                // Refresh appointment grid for this user
                using (var context = new appointmentsContext())
                {
                    var appointmentsList = context.appointments
                        .Where(h => h.userId == UsersId)
                        .ToList();

                    dataGridView_appointment.DataSource = appointmentsList;

                }
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }

            // TODO: This line of code loads data into the 'hospitalManagerDataSetAppointments.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.FillBy(this.hospitalManagerDataSetAppointments.appointments, UsersId);
        }

        private void dataGridView_appointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Checks if the clicked row is valid
                if (e.RowIndex >= 0)
                {
                    // Get the values from the clicked row
                    AppointmentId = Convert.ToInt32(dataGridView_appointment.Rows[e.RowIndex].Cells["appointmentIdDataGridViewTextBoxColumn"].Value);
                    UserId = Convert.ToInt32(dataGridView_appointment.Rows[e.RowIndex].Cells["userIdDataGridViewTextBoxColumn"].Value);
                    DoctorName = dataGridView_appointment.Rows[e.RowIndex].Cells["doctorNameDataGridViewTextBoxColumn"].Value?.ToString();
                    DoctorSpecialty = dataGridView_appointment.Rows[e.RowIndex].Cells["doctorSpecialtyDataGridViewTextBoxColumn"].Value?.ToString();
                    StartTime = Convert.ToDateTime(dataGridView_appointment.Rows[e.RowIndex].Cells["startTimeDataGridViewTextBoxColumn"].Value);
                    Status = dataGridView_appointment.Rows[e.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value?.ToString();
                    Notes = dataGridView_appointment.Rows[e.RowIndex].Cells["notesDataGridViewTextBoxColumn"].Value?.ToString();

                    // Set the values in the textboxes to edit them
                    textBox_doctorName.Text = DoctorName;
                    textBox_doctorSpecialty.Text = DoctorSpecialty;
                    textBox_startTime.Text = StartTime.ToShortDateString(); ;
                    textBox_notes.Text = Notes;
                    comboBox_status.Text = Status;

                    comboBox_status.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var appointments = new appointments
                {
                    userId = UsersId,
                    doctorName = textBox_doctorName.Text,
                    doctorSpecialty = textBox_doctorSpecialty.Text,
                    startTime = DateTime.Parse(textBox_startTime.Text),
                    status = comboBox_status.Text,
                    notes = textBox_notes.Text
                };

                using (var context = new appointmentsContext())
                {
                    context.appointments.Add(appointments);
                    context.SaveChanges();
                }


                button_clear_Click_1(sender, e);
            }
            catch (Exception ex)
            {
                // Show the error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                // Call the refresh method to reload the data
                refresh_Click(sender, e);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new appointmentsContext())
                {
                    int id = UserId;

                    // Finds the patient by ID
                    var appointmentsToUpdate = context.appointments.FirstOrDefault(p => p.appointmentId == AppointmentId);


                    if (appointmentsToUpdate != null)
                    {
                        //Updates the History's properties
                        appointmentsToUpdate.userId = UserId;
                        appointmentsToUpdate.doctorName = textBox_doctorName.Text;
                        appointmentsToUpdate.doctorSpecialty = textBox_doctorSpecialty.Text;
                        appointmentsToUpdate.startTime = DateTime.Parse(textBox_startTime.Text);
                        appointmentsToUpdate.status = comboBox_status.Text;
                        appointmentsToUpdate.notes = textBox_notes.Text;
                        // Saves Changes to the Database
                        context.SaveChanges();
                    }
                }
                // Clear the textboxes after updating the patient
                button_clear_Click_1(sender, e);
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Call the refresh method to reload the data
                refresh_Click(sender, e);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            HubForm mainForm = new HubForm();
            mainForm.Show();
            this.Hide();
        }
        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_doctorName.Clear();
            textBox_doctorSpecialty.Clear();
            textBox_startTime.Clear();
            textBox_notes.Clear();
            comboBox_status.Enabled = false;
        }
        // Class represents patients entity from the patients table in the database
        [Table("appointments")]
        public class appointments
        {

            [Key]
            public int appointmentId { get; set; }
            public int userId { get; set; }
            public DateTime startTime { get; set; }
            public string doctorName { get; set; }
            public string doctorSpecialty { get; set; }
            public string status { get; set; }
            public string notes { get; set; }
        }


        // Database context for accessing patients
        public class appointmentsContext : DbContext
        {
            //Table of products
            public DbSet<appointments> appointments { get; set; }

            // Sets the database connection string
            public appointmentsContext()
                : base(@"Data Source=DESKTOP-8LO3E1T\SQLEXPRESS;Initial Catalog=HospitalManager;Integrated Security=True;TrustServerCertificate=True;")
            {

            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new appointmentsContext())
                {
                    // Gets all History from the database
                    var appointmentsList = context.appointments
                        .Where(h => h.userId == UsersId)
                        .ToList();


                    // Sets the datasource of the datagridview to the patients list
                    dataGridView_appointment.DataSource = appointmentsList;
                }
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
