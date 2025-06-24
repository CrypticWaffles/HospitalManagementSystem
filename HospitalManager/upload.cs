using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HospitalManager
{
    public partial class upload : Form
    {
        public upload()
        {
            InitializeComponent();
        }

        string filePath = "";

        private void btn_browse_Click(object sender, EventArgs e)
        {
            // Open file dialog to select file for import
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;  // Get selected file path
                    txtb_browse.Text = filePath;  // Display file path in text box
                }
            }
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
             ImportData(); // Call ImportData method
        }

        // Insert data into SQL table using SQLBulkCopy
        private void InsertDataIntoSQL(DataTable dataTable)
        {
            // Connect to the database
            using (SqlConnection dbConnection = new SqlConnection(@"Data Source=DESKTOP-8LO3E1T\SQLEXPRESS;Initial Catalog=HospitalManager;Integrated Security=True;TrustServerCertificate=True;"))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    string destinationTable = cbox_tabletype.SelectedItem.ToString();
                    s.DestinationTableName = destinationTable;

                    // Map columns between DataTable and SQL table
                    foreach (var column in dataTable.Columns)
                    {
                        s.ColumnMappings.Add(column.ToString(), column.ToString());
                    }

                    // Insert data into SQL
                    s.WriteToServer(dataTable);
                }
                dbConnection.Close();
            }
        }

        // Handle the data import based on file type (CSV, JSON, XML)
        private void ImportData()
        {
            // Check if file path is empty
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please select a file to import.");
                return;
            }

            // Get file extension to determine file type
            string extension = Path.GetExtension(filePath).ToLower();

            // Process CSV file
            if (extension == ".csv")
            {
                DataTable data = new DataTable();
                try
                {
                    // Read CSV file
                    using (TextFieldParser csvReader = new TextFieldParser(filePath))
                    {
                        csvReader.SetDelimiters(",");
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        string[] colFields = csvReader.ReadFields();

                        // Add columns to DataTable
                        foreach (string colField in colFields)
                        {
                            DataColumn dataColumn = new DataColumn(colField);
                            data.Columns.Add(dataColumn);
                        }

                        // Add rows to DataTable
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            data.Rows.Add(fieldData);
                        }
                    }

                    // Display data in DataGridView and insert into SQL
                    DataGridView.DataSource = data;
                    InsertDataIntoSQL(data);
                    MessageBox.Show("Everything went great!"); // Notify success
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString()); // Handle error
                }
            }
            // Process JSON file
            else if (extension == ".json")
            {
                try
                {
                    string file = txtb_browse.Text.ToString();
                    string jsonData = System.IO.File.ReadAllText(file);

                    // Deserialize JSON data into a list of dictionaries
                    var records = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonData);

                    DataTable dataTable = new DataTable();

                    // Add columns to DataTable based on JSON keys
                    foreach (string key in records[0].Keys)
                    {
                        dataTable.Columns.Add(key);
                    }

                    // Add rows to DataTable
                    foreach (var record in records)
                    {
                        var row = dataTable.NewRow();
                        foreach (var key in record.Keys)
                        {
                            row[key] = record[key] ?? DBNull.Value; // Handle missing values
                        }
                        dataTable.Rows.Add(row);
                    }

                    // Display data in DataGridView and insert into SQL
                    DataGridView.DataSource = dataTable;
                    InsertDataIntoSQL(dataTable);
                    MessageBox.Show("JSON Data added"); // Notify success
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading JSON file: " + ex.Message); // Handle error
                }
            }
            else
            {
                MessageBox.Show("Incorrect file type submitted"); // Handle unsupported file type
            }
        }

        private void upload_FormClosed(object sender, FormClosedEventArgs e)
        {
            PatientRecords mainForm = new PatientRecords();
            mainForm.Show();
            this.Hide();
        }
    }
}
