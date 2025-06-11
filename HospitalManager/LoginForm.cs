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
    // This class represents the login form of the application.
    // It allows users to log in with their username and password.
    public partial class LoginForm : Form
    {
        // Reference to initial Starting page
        private StartForm startPage;

        // MongoDB collection for users
        IMongoCollection<User> usersCollection;

        // Constructors
        // Default constructor that initializes the login form.
        public LoginForm()
        {
            InitializeComponent();
        }

        // Constructor that initializes the login form and sets up the database connection.
        public LoginForm(StartForm form)
        {
            InitializeComponent();
            InitializeDatabase();
            startPage = form;
        }

        // This method is called when the login button is clicked.
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Get the username and password from the text boxes.
            string username = txt_username.Text;
            string password = txt_password.Text;

            // Check if the username and password are not empty.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the user in the database.
            var user = usersCollection.Find(u => u.Username == username && u.Password == password).FirstOrDefault();

            // If the user is found, show a success message and close the login form.
            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HubForm hubForm = new HubForm(user);
                hubForm.Show();
                this.Close();
            }
            else
            {
                // If the user is not found, show an error message.
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
