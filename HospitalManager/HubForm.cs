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
    public partial class HubForm : Form
    {
        // reference to the current user
        private User currentUser;

        // Constructors
        // Default constructor that initializes the HubForm.
        public HubForm()
        {
            InitializeComponent();
        }

        public HubForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {

        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {

        }
    }
}
