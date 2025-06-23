using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManager
{
    public partial class DashboardForm : Form
    {
        // Reference to the HubForm
        private HubForm hubForm;
        // SignalR connection to the chat hub
        private HubConnection connection;
        // Connection string to the SQL Server database
        private string connectionString = ConfigurationManager.ConnectionStrings["HospitalManager.Properties.Settings.HospitalManagerConnectionString"].ConnectionString;

        // Constructor that initializes the dashboard form with a reference to the HubForm.
        public DashboardForm(HubForm hubForm)
        {
            InitializeComponent();
            InitializeSignalR();
            LoadPatientData();
            this.hubForm = hubForm;
        }

        // Method to load patient data into the ComboBox
        private void LoadPatientData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Concat First and Last Names for better display in ComboBox
                    string query = "SELECT PatientId, FirstName, LastName, FirstName + ' ' + LastName AS FullName FROM dbo.Patients ORDER BY LastName, FirstName";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmb_patient.DataSource = dt;
                    cmb_patient.DisplayMember = "FullName";
                    cmb_patient.ValueMember = "PatientId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initializes the SignalR connection to the chat hub and sets up the event handler for receiving messages.
        private async void InitializeSignalR()
        {
            // Create a new HubConnection to the chat hub
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7203/dashboardhub")
                .Build();

            connection.On<int>("UpdateHeartRate", (heartRate) =>
            {
                // Invoke the UI thread to update the heart rate label
                Invoke((Action)(() =>
                {
                    lbl_heartRate.Text = $"Heart Rate: {heartRate} bpm";
                }));
            });

            connection.On<string>("UpdateBloodPressure", (bloodPressure) =>
            {
                // Invoke the UI thread to update the blood pressure label
                Invoke((Action)(() =>
                {
                    lbl_bloodPressure.Text = $"Blood Pressure: {bloodPressure} mmHg";
                }));
            });

            connection.On<int>("UpdateSpO2", (sp02) =>
            {
                Invoke((Action)(() =>
                {
                    lbl_sp02.Text = $"SpO2: {sp02}%";
                }));
            });

            connection.On<int>("UpdateTemperature", (temperature) =>
            {
                // Invoke the UI thread to update the temperature label
                Invoke((Action)(() =>
                {
                    lbl_temp.Text = $"Temperature: {temperature} °C";
                }));
            });

            connection.On<int, int>("UpdateBedStatus", (occupiedBeds, totalBeds) =>
            {
                // Invoke the UI thread to update the bed status label
                Invoke((Action)(() =>
                {
                    lbl_beds.Text = $"Occupied Beds: {occupiedBeds} / {totalBeds}";
                }));
            });

            connection.On<int>("UpdateEmergencies", (emergencies) =>
            {
                // Invoke the UI thread to update the emergencies label
                Invoke((Action)(() =>
                {
                    lbl_emergencies.Text = $"Emergencies: {emergencies}";
                }));
            });

            try
            {
                await connection.StartAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start SignalR connection: {ex.Message}");
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hubForm.Show();
        }
    }
}
