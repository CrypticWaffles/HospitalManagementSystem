using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json; 
using System.Xml;     
using System.Configuration; 

namespace HospitalManager 
{
    public partial class AnalyticsForm : Form
    {
        private User currentUser;
        private HubForm hubForm;
        private string connectionString = ConfigurationManager.ConnectionStrings["HospitalManager.Properties.Settings.HospitalManagerConnectionString"].ConnectionString;

        // Constructor without parameter
        public AnalyticsForm()
        {
            InitializeComponent();
        }

        // Constructor with parameters
        public AnalyticsForm(User user, HubForm hubForm)
        {
            InitializeComponent();
            currentUser = user;
            this.hubForm = hubForm;
            LoadPatientData(); 
        }

        // Event handler for form closing
        private void AnalyticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hubForm.Show();
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

                    DataRow allPatientsRow = dt.NewRow();
                    allPatientsRow["PatientId"] = DBNull.Value;
                    allPatientsRow["FirstName"] = "All";
                    allPatientsRow["LastName"] = "Patients";
                    allPatientsRow["FullName"] = "All Patients"; 
                    dt.Rows.InsertAt(allPatientsRow, 0);

                    cmb_patients.DataSource = dt;
                    cmb_patients.DisplayMember = "FullName"; 
                    cmb_patients.ValueMember = "PatientId"; // Use PatientId as the actual value
                    cmb_patients.SelectedIndex = 0; // Select "All Patients" by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for patient selection in the ComboBox
        private void cmb_patients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_patients.SelectedValue != null)
            {
                object selectedValue = cmb_patients.SelectedValue;

                if (selectedValue == DBNull.Value || (cmb_patients.SelectedItem is DataRowView drv && drv["PatientId"] == DBNull.Value))
                {
                    GenerateGeneralReport();
                }
                else
                {
                    int patientId = Convert.ToInt32(selectedValue);
                    GeneratePatientReport(patientId);
                }
            }
        }

        // Method to generate a report for a specific patient
        private void GeneratePatientReport(int patientId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Join Patients and MedicalHistories to get a comprehensive report
                    string query = @"
                        SELECT
                            P.PatientId,
                            P.FirstName,
                            P.LastName,
                            P.DateOfBirth,
                            P.Gender,
                            P.PhoneNumber,
                            P.Address,
                            MH.RecordDate,
                            MH.Diagnosis,
                            MH.Treatment,
                            MH.Notes
                        FROM
                            dbo.Patients AS P
                        INNER JOIN
                            dbo.MedicalHistories AS MH ON P.PatientId = MH.PatientId
                        WHERE
                            P.PatientId = @PatientId
                        ORDER BY
                            MH.RecordDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    da.SelectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.TableName = "PatientReport";
                    dgv_report.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating patient report: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to generate a general report on all trends
        private void GenerateGeneralReport()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // This query gives a general overview of all medical histories
                    string query = @"
                        SELECT
                            P.PatientId,
                            P.FirstName,
                            P.LastName,
                            MH.RecordDate,
                            MH.Diagnosis,
                            MH.Treatment,
                            COUNT(MH.HistoryId) OVER (PARTITION BY MH.Diagnosis) AS DiagnosisCount,
                            COUNT(MH.HistoryId) OVER (PARTITION BY MH.Treatment) AS TreatmentCount
                        FROM
                            dbo.Patients AS P
                        INNER JOIN
                            dbo.MedicalHistories AS MH ON P.PatientId = MH.PatientId
                        ORDER BY
                            P.LastName, P.FirstName, MH.RecordDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.TableName = "GeneralReport";
                    dgv_report.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating general report: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Generate General Report" button
        private void btn_generalReport_Click(object sender, EventArgs e)
        {
            GenerateGeneralReport();
        }

        // Method to export data to JSON
        private void btn_exportJson_Click(object sender, EventArgs e)
        {
            if (dgv_report.DataSource == null)
            {
                MessageBox.Show("No data to export.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = (DataTable)dgv_report.DataSource;
                string json = JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Save JSON Report";
                saveFileDialog.FileName = "Report.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Report exported successfully as JSON.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to JSON: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to export data to CSV
        private void btn_exportCsv_Click(object sender, EventArgs e)
        {
            if (dgv_report.DataSource == null)
            {
                MessageBox.Show("No data to export.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = (DataTable)dgv_report.DataSource;
                StringWriter sw = new StringWriter();

                // Write header row
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName);
                    if (i < dt.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();

                // Write data rows
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        // Handle potential commas in data by enclosing in quotes
                        string value = dr[i].ToString();
                        if (value.Contains(","))
                        {
                            value = $"\"{value.Replace("\"", "\"\"")}\""; // Escape double quotes
                        }
                        sw.Write(value);
                        if (i < dt.Columns.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save CSV Report";
                saveFileDialog.FileName = "Report.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, sw.ToString());
                    MessageBox.Show("Report exported successfully as CSV.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to export data to XML
        private void btn_exportXml_Click(object sender, EventArgs e)
        {
            if (dgv_report.DataSource == null)
            {
                MessageBox.Show("No data to export.", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = (DataTable)dgv_report.DataSource;
                dt.TableName = "ReportData";
                StringWriter sw = new StringWriter();
                dt.WriteXml(sw, XmlWriteMode.WriteSchema);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = "Save XML Report";
                saveFileDialog.FileName = "Report.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, sw.ToString());
                    MessageBox.Show("Report exported successfully as XML.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to XML: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
