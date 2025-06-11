using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManager
{
    // This class represents the start form of the application.
    // It serves as the entry point for the application and allows users to navigate through the application.
    public partial class StartForm : Form
    {   
        public StartForm()
        {
            InitializeComponent();
        }

        // This method is called when the login button is clicked.
        // It opens the login form and hides the start form.
        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(this);
            login.Show();
            this.Hide();
        }

        // This method is called when the register button is clicked.
        // It opens the registration form and hides the start form.
        private void btn_register_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm(this);
            registration.Show();
            this.Hide();
        }

        // This method is called when the skip button is clicked.
        // It allows users to skip the login process and continue to the main application.
        private void btn_skip_Click(object sender, EventArgs e)
        {
            HubForm hubForm = new HubForm();
            hubForm.Show();
            this.Hide();
        }
    }
}
