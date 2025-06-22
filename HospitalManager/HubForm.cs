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
            SetupForm();
        }

        public HubForm(User user)
        {
            InitializeComponent();
            InitializeUserDatabase();
            currentUser = user;
            SetupForm();
        }

        public void SetupForm()
        {
            lbl_hi.Text = $"Logged in as: {currentUser.Username}.";
            lbl_role.Text = $"Role: {currentUser.Role}.";

            if (currentUser.Role != "Patient")
            {
                btn_analytics.Visible = true;
                button_patientRecords.Visible = true;
                button_appointments.Visible = true;
                button_inventory.Visible = true;
            }
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm(currentUser, this);
            chatForm.Show();
            this.Hide();
        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {
            AnalyticsForm analyticsForm = new AnalyticsForm(currentUser, this);
            analyticsForm.Show();
            this.Hide();
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

        private void button_patientRecords_Click(object sender, EventArgs e)
        {
            PatientRecords patientRecords = new PatientRecords();
            patientRecords.Show();
            this.Hide();
        }

        private void button_appointments_Click(object sender, EventArgs e)
        {
            AppointmentScheduling appointmentScheduling = new AppointmentScheduling();
            appointmentScheduling.Show();
            this.Hide();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            MedicalInventoryManagement medicalInventoryManagement = new MedicalInventoryManagement();
            medicalInventoryManagement.Show();
            this.Hide();
        }
    }
}
