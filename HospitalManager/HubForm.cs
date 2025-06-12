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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManager
{
    public partial class HubForm : Form
    {
        // reference to the current user
        private User currentUser;

        // MongoDB collection for users
        IMongoCollection<User> usersCollection;

        // Constructors
        // Default constructor that initializes the HubForm.
        public HubForm()
        {
            InitializeComponent();
            InitializeUserDatabase();
            var filter = Builders<User>.Filter.Eq("username", "admin");
            currentUser = usersCollection.Find(filter).FirstOrDefault();
            lbl_hi.Text = $"Logged in as: {currentUser.Username}.";
            PatientRegistration();
        }

        public HubForm(User user)
        {
            InitializeComponent();
            InitializeUserDatabase();
            currentUser = user;
            lbl_hi.Text = $"Logged in as: {currentUser.Username}.";
            PatientRegistration();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {

        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {

        }

        // Initializes the MongoDB database connection and retrieves the users collection.
        public void InitializeUserDatabase()
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

        public void PatientRegistration()
        {
            if (currentUser.Role == "Patient" && currentUser.Registered == false)
            {
                MessageBox.Show("Please register as a patient before proceeding.", "Registration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
