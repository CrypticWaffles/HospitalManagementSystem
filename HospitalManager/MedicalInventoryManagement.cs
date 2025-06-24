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
using static HospitalManager.PatientRecords;

namespace HospitalManager
{
    public partial class MedicalInventoryManagement : Form
    {
        public MedicalInventoryManagement()
        {
            InitializeComponent();
        }

        private void MedicalInventoryManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagerDataSetInventory.MedicalInventory' table. You can move, or remove it, as needed.
            this.medicalInventoryTableAdapter.Fill(this.hospitalManagerDataSetInventory.MedicalInventory);

        }
        int ItemID;
        string ItemName;
        string ItemType;
        int QuantityInStock;
        string Unit;
        DateTime LastUpdated;

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var inventory = new MedicalInventory
                {
                    ItemName = textBox_name.Text,
                    ItemType = textBox_type.Text,
                    QuantityInStock = Convert.ToInt32(textBox_stock.Text),
                    Unit = textBox_unit.Text,
                    LastUpdated = DateTime.Now,
                };

                using (var context = new InventoryContext())
                {
                    context.MedicalInventory.Add(inventory);
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
                using (var context = new InventoryContext())
                {
                    int id = ItemID;

                    // Finds the inventory by ID
                    var inventoryToUpdate = context.MedicalInventory.FirstOrDefault(I => I.ItemID == id);


                    if (inventoryToUpdate != null)
                    {
                        //Updates the inventory's properties
                        inventoryToUpdate.ItemName = textBox_name.Text;
                        inventoryToUpdate.ItemType = textBox_type.Text;
                        inventoryToUpdate.QuantityInStock = Convert.ToInt32(textBox_stock.Text);
                        inventoryToUpdate.Unit = textBox_unit.Text;
                        inventoryToUpdate.LastUpdated = DateTime.Now;

                        // Saves Changes to the Database
                        context.SaveChanges();
                    }
                }
                // Clear the textboxes after updating the inventory
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
                // Ensure a inventoryId has been selected before trying to delete
                if (ItemID != 0)
                {
                    using (var context = new InventoryContext())
                    {
                        int id = ItemID;

                        // Finds the inventory by ID
                        var inventoryToDelete = context.MedicalInventory.FirstOrDefault(I => I.ItemID == id);


                        if (inventoryToDelete != null)
                        {
                            // Remove the inventory from the database
                            context.MedicalInventory.Remove(inventoryToDelete);
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
                using (var context = new InventoryContext())
                {
                    // Get inventory that match the search term (case-insensitive)
                    var searchTerm = textBox_name.Text.ToLower();
                    var results = context.MedicalInventory
                        .Where(I => I.ItemName.ToLower().Contains(searchTerm)
                                 || I.ItemType.ToLower().Contains(searchTerm))
                        .ToList();

                    // Set the DataSource of the DataGridView to the search results
                    dataGridView_medicalInventory.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            HubForm mainForm = new HubForm();
            mainForm.Show();
            this.Hide();
        }

        private void dataGridView_medicalInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Checks if the clicked row is valid
                if (e.RowIndex >= 0)
                {
                    // Get the values from the clicked row
                    ItemID = Convert.ToInt32(dataGridView_medicalInventory.Rows[e.RowIndex].Cells["itemIDDataGridViewTextBoxColumn"].Value);
                    ItemName = dataGridView_medicalInventory.Rows[e.RowIndex].Cells["itemNameDataGridViewTextBoxColumn"].Value?.ToString();
                    ItemType = dataGridView_medicalInventory.Rows[e.RowIndex].Cells["itemTypeDataGridViewTextBoxColumn"].Value?.ToString();
                    QuantityInStock = Convert.ToInt32(dataGridView_medicalInventory.Rows[e.RowIndex].Cells["quantityInStockDataGridViewTextBoxColumn"].Value?.ToString());
                    Unit = dataGridView_medicalInventory.Rows[e.RowIndex].Cells["unitDataGridViewTextBoxColumn"].Value?.ToString();
                    LastUpdated = Convert.ToDateTime(dataGridView_medicalInventory.Rows[e.RowIndex].Cells["lastUpdatedDataGridViewTextBoxColumn"].Value);


                    // Set the values in the textboxes to edit them
                    textBox_name.Text = ItemName;
                    textBox_type.Text = ItemType;
                    textBox_stock.Text = QuantityInStock.ToString();
                    textBox_unit.Text = Unit;
                   
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
                using (var context = new InventoryContext())
                {
                    // Gets all inventory from the database
                    var inventoryList = context.MedicalInventory.ToList();

                    // Sets the datasource of the datagridview to the inventory list
                    dataGridView_medicalInventory.DataSource = inventoryList;
                }
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Class represents Inventory entity from the Inventory table in the database
        [Table("MedicalInventory")]
        public class MedicalInventory
        {
            [Key]
            public int ItemID { get; set; }
            public string ItemName { get; set; }
            public string ItemType { get; set; }
            public int QuantityInStock { get; set; }
            public string Unit { get; set; }
            public DateTime LastUpdated { get; set; }

        }

        // Database context for accessing inventory
        public class InventoryContext : DbContext
        {
            //Table of Inventory
            public DbSet<MedicalInventory> MedicalInventory { get; set; }

            // Sets the database connection string
            public InventoryContext()
                : base(@"Data Source=DESKTOP-8LO3E1T\SQLEXPRESS;Initial Catalog=HospitalManager;Integrated Security=True;TrustServerCertificate=True;")
            {

            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            // clear the values in the textboxes
            textBox_name.Text = "";
            textBox_type.Text = "";
            textBox_stock.Text = "";
            textBox_unit.Text = "";

            refresh_Click(sender, e);
        }

        private void MedicalInventoryManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            HubForm mainForm = new HubForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
