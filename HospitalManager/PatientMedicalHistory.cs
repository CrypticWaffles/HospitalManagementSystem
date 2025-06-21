using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HospitalManager.PatientMedicalHistory;
using static HospitalManager.PatientRecords;

namespace HospitalManager
{
    public partial class PatientMedicalHistory : Form
    {
        private PatientRecords patientRecords;
        public int SelectedPatient { get; }
        public string PatientFirstName { get; }
        public string PatientLastName { get; }

        public int HistoryId;
        public int PatientId;
        public DateTime RecordDate;
        public string Diagnosis;
        public string Treatment;
        public string Notes;


        public PatientMedicalHistory(int selectedPatient, string patientsFirstName, string patientsLastName)
        {
            InitializeComponent();
            SelectedPatient = selectedPatient;
            PatientFirstName = patientsFirstName;
            PatientLastName = patientsLastName;

        }

        public PatientMedicalHistory(int selectedPatient, string patientsFirstName, string patientsLastName, PatientRecords patientRecords)
        {
            InitializeComponent();
            SelectedPatient = selectedPatient;
            PatientFirstName = patientsFirstName;
            PatientLastName = patientsLastName;
            this.patientRecords = patientRecords;

        }

        private void PatientMedicalHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagerDataSet.MedicalHistories' table. You can move, or remove it, as needed.
            this.medicalHistoriesTableAdapter.FillByPatientID(this.hospitalManagerDataSet.MedicalHistories, SelectedPatient);

            label_patientName.Text = $"{PatientFirstName} {PatientLastName} Medical History";

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var patientHistory = new PatientHistory
                {
                    PatientId = SelectedPatient,
                    RecordDate = DateTime.Parse(textBox_recordDate.Text),
                    Diagnosis = textBox_diagnosis.Text,
                    Treatment = textBox_treatment.Text,
                    Notes = textBox_notes.Text
                };

                using (var context = new PatientHistoryContext())
                {
                    context.MedicalHistories.Add(patientHistory);
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

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PatientHistoryContext())
                {
                    int id = HistoryId;

                    // Finds the patient by ID
                    var historyToUpdate = context.MedicalHistories.FirstOrDefault(p => p.HistoryId == id);


                    if (historyToUpdate != null)
                    {
                        //Updates the History's properties
                        historyToUpdate.RecordDate = DateTime.Parse(textBox_recordDate.Text);
                        historyToUpdate.Diagnosis = textBox_diagnosis.Text;
                        historyToUpdate.Treatment = textBox_treatment.Text;
                        historyToUpdate.Notes = textBox_notes.Text;

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

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a HistoryId has been selected before trying to delete
                if (HistoryId != 0)
                {
                    using (var context = new PatientHistoryContext())
                    {
                        int id = HistoryId;

                        // Finds the History by ID
                        var historyToDelete = context.MedicalHistories.FirstOrDefault(h => h.HistoryId == id);

                        if (historyToDelete != null)
                        {
                            // Remove the History from the database
                            context.MedicalHistories.Remove(historyToDelete);
                            context.SaveChanges();
                        }
                    }

                    // Clear the textboxes after deletion
                    button_clear_Click_1(sender, e);

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
            string searchTerm = textBox_diagnosis.Text.ToLower();
            using (var context = new PatientHistoryContext())
            {
                var result = context.MedicalHistories
                    .Where(h => h.PatientId == SelectedPatient && h.Diagnosis.ToLower().Contains(searchTerm))
                    .ToList();

                dataGridView_medicalHistory.DataSource = result;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PatientHistoryContext())
                {
                    // Gets all History from the database
                    var historyList = context.MedicalHistories
                        .Where(h => h.PatientId == SelectedPatient)
                        .ToList();

                    // Sets the datasource of the datagridview to the patients list
                    dataGridView_medicalHistory.DataSource = historyList;
                }
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Class represents patients entity from the patients table in the database
        [Table("MedicalHistories")]
        public class PatientHistory
        {

            [Key]
            public int HistoryId { get; set; }
            public int PatientId { get; set; }
            public DateTime RecordDate { get; set; }
            public string Diagnosis { get; set; }
            public string Treatment { get; set; }
            public string Notes { get; set; }
        }


        // Database context for accessing patients
        public class PatientHistoryContext : DbContext
        {
            //Table of products
            public DbSet<PatientHistory> MedicalHistories { get; set; }

            // Sets the database connection string
            public PatientHistoryContext()
                : base(@"Data Source=DESKTOP-8LO3E1T\SQLEXPRESS;Initial Catalog=HospitalManager;Integrated Security=True;TrustServerCertificate=True;")
            {

            }
        }


        private void dataGridView_medicalHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Checks if the clicked row is valid
                if (e.RowIndex >= 0)
                {
                    // Get the values from the clicked row
                    HistoryId = Convert.ToInt32(dataGridView_medicalHistory.Rows[e.RowIndex].Cells["historyIdDataGridViewTextBoxColumn"].Value);
                    PatientId = Convert.ToInt32(dataGridView_medicalHistory.Rows[e.RowIndex].Cells["patientIdDataGridViewTextBoxColumn"].Value);
                    RecordDate = Convert.ToDateTime(dataGridView_medicalHistory.Rows[e.RowIndex].Cells["recordDateDataGridViewTextBoxColumn1"].Value);
                    Diagnosis = dataGridView_medicalHistory.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value?.ToString();
                    Treatment = dataGridView_medicalHistory.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value?.ToString();
                    Notes = dataGridView_medicalHistory.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value?.ToString();


                    // Set the values in the textboxes to edit them
                    textBox_recordDate.Text = RecordDate.ToShortDateString();
                    textBox_diagnosis.Text = Diagnosis;
                    textBox_treatment.Text = Treatment;
                    textBox_notes.Text = Notes;

                }

            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_recordDate.Clear();
            textBox_diagnosis.Clear();
            textBox_treatment.Clear();
            textBox_notes.Clear();
            HistoryId = 0;
        }

        private void PatientMedicalHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            patientRecords.Show();
        }
    }
}
