using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static HospitalManager.PatientRecords;
using System.Data.Entity;

namespace HospitalManager
{
    public partial class PatientRecords : Form
    {
        public PatientRecords()
        {
            InitializeComponent();
        }
        int PatientID;
        string FirstName;
        string LastName;
        DateTime DateOfBirth;
        string Gender;
        string PhoneNumber;
        string Address;


        private void PatientRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagerDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.hospitalManagerDataSet.Patients);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var patient = new Patient
                {
                    FirstName = textBox_firstName.Text,
                    LastName = textBox_lastName.Text,
                    DateOfBirth = DateTime.Parse(textBox_dob.Text),
                    Gender = textBox_gender.Text,
                    PhoneNumber = textBox_phoneNumber.Text,
                    Address = textBox_address.Text
                };

                using (var context = new PatientsContext())
                {
                    context.Patients.Add(patient);
                    context.SaveChanges();
                }


                button_clear_Click(sender, e);
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

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PatientsContext())
                {
                    int id = PatientID;

                    // Finds the patient by ID
                    var patientToUpdate = context.Patients.FirstOrDefault(p => p.PatientID == id);


                    if (patientToUpdate != null)
                    {
                        //Updates the patient's properties
                        patientToUpdate.FirstName = textBox_firstName.Text;
                        patientToUpdate.LastName = textBox_lastName.Text;
                        patientToUpdate.DateOfBirth = DateTime.Parse(textBox_dob.Text);
                        patientToUpdate.Gender = textBox_gender.Text;
                        patientToUpdate.PhoneNumber = textBox_phoneNumber.Text;
                        patientToUpdate.Address = textBox_address.Text;

                        // Saves Changes to the Database
                        context.SaveChanges();
                    }
                }
                // Clear the textboxes after updating the patient
                button_clear_Click(sender, e);
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a PatientID has been selected before trying to delete
                if (PatientID != 0)
                {
                    using (var context = new PatientsContext())
                    {
                        int id = PatientID;

                        // Finds the patient by ID
                        var patientToDelete = context.Patients.FirstOrDefault(p => p.PatientID == id);


                        if (patientToDelete != null)
                        {
                            // Remove the patient from the database
                            context.Patients.Remove(patientToDelete);
                            context.SaveChanges();
                        }
                    }

                    // Clear the textboxes after deletion
                    button_clear_Click(sender, e);

                    // Show success message
                    MessageBox.Show("Product deleted successfully.");

                }
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

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PatientsContext())
                {
                    // Get patient that match the search term (case-insensitive)
                    var searchTerm = textBox_firstName.Text.ToLower();
                    var results = context.Patients
                        .Where(p => p.FirstName.ToLower().Contains(searchTerm)
                                 || p.LastName.ToLower().Contains(searchTerm))
                        .ToList();

                    // Set the DataSource of the DataGridView to the search results
                    dataGridView_patientRecords.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_medicalHistory_Click(object sender, EventArgs e)
        {
            int selectedPatient = PatientID;
            string patientsFirstName = FirstName;
            string patientsLastName = LastName;

            PatientMedicalHistory mainForm = new PatientMedicalHistory(selectedPatient, patientsFirstName, patientsLastName);
            mainForm.Show();
            this.Hide();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            HubForm mainForm = new HubForm();
            mainForm.Show();
            this.Hide();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_patientRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Checks if the clicked row is valid
                if (e.RowIndex >= 0)
                {
                    // Get the values from the clicked row
                    PatientID = Convert.ToInt32(dataGridView_patientRecords.Rows[e.RowIndex].Cells["patientIDDataGridViewTextBoxColumn"].Value);
                    FirstName = dataGridView_patientRecords.Rows[e.RowIndex].Cells["firstNameDataGridViewTextBoxColumn"].Value?.ToString();
                    LastName = dataGridView_patientRecords.Rows[e.RowIndex].Cells["lastNameDataGridViewTextBoxColumn"].Value?.ToString();
                    DateOfBirth = Convert.ToDateTime(dataGridView_patientRecords.Rows[e.RowIndex].Cells["dateOfBirthDataGridViewTextBoxColumn"].Value);
                    Gender = dataGridView_patientRecords.Rows[e.RowIndex].Cells["genderDataGridViewTextBoxColumn"].Value?.ToString();
                    PhoneNumber = dataGridView_patientRecords.Rows[e.RowIndex].Cells["phoneNumberDataGridViewTextBoxColumn"].Value?.ToString();
                    Address = dataGridView_patientRecords.Rows[e.RowIndex].Cells["addressDataGridViewTextBoxColumn"].Value?.ToString();


                    // Set the values in the textboxes to edit them
                    textBox_firstName.Text = FirstName;
                    textBox_lastName.Text = LastName;
                    textBox_dob.Text = DateOfBirth.ToString();
                    textBox_gender.Text = Gender;
                    textBox_phoneNumber.Text = PhoneNumber;
                    textBox_address.Text = Address;
                }

            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PatientsContext())
                {
                    // Gets all patients from the database
                    var patientList = context.Patients.ToList();

                    // Sets the datasource of the datagridview to the patients list
                    dataGridView_patientRecords.DataSource = patientList;
                }
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Class represents patients entity from the patients table in the database
        public class Patient
        {
            public int PatientID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }

        }

        // Database context for accessing patients
        public class PatientsContext : DbContext
        {
            //Table of products
            public DbSet<Patient> Patients { get; set; }

            // Sets the database connection string
            public PatientsContext()
                : base(@"Data Source=DESKTOP-8LO3E1T\SQLEXPRESS;Initial Catalog=HospitalManager;Integrated Security=True;TrustServerCertificate=True;")
            {

            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            // clear the values in the textboxes
            textBox_firstName.Text = "";
            textBox_lastName.Text = "";
            textBox_dob.Text = "";
            textBox_gender.Text = "";
            textBox_phoneNumber.Text = "";
            textBox_address.Text = "";

            refresh_Click(sender, e);
        }
    }
}
