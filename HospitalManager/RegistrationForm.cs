using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManager
{
    public partial class RegistrationForm : Form
    {
        // Reference to the initial Starting page
        StartForm startPage;

        // MongoDB collection for users
        IMongoCollection<User> usersCollection;

        // Constructors
        // Default constructor that initializes the registration form.
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public RegistrationForm(StartForm start)
        {
            InitializeComponent();
            InitializeDatabase();
            startPage = start;
        }

        // Initializes the MongoDB database connection and retrieves the users collection.
        public void InitializeDatabase()
        {
            // Get connectionstring from app config
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

            // Get name of the database from conenction string
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;

            var mongoClient = new MongoClient(connectionString);

            // Get the database
            var database = mongoClient.GetDatabase(databaseName);

            // Get collection
            usersCollection = database.GetCollection<User>("users");
        }

        // This method is called when the register button is clicked.
        // Handles user registration by validating input fields, checking for existing usernames, and creating a new user object.
        private void btn_register_Click(object sender, EventArgs e)
        {
            // Get user informtation from text boxes
            string username = txt_username.Text;
            string password = txt_password.Text;
            string email = txt_email.Text;
            string role = cmb_role.SelectedItem?.ToString();

            // Check if all fields are filled
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username already exists
            var existingUser = usersCollection.Find(u => u.Username == username).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new user object
            User newUser = new User
            {
                Username = username,
                Password = password,
                Email = email,
                Role = role
            };

            // Insert the new user into the database
            try
            {
                usersCollection.InsertOne(newUser);
                MessageBox.Show("Registration successful! You can now log in.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm(startPage);
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while registering: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
