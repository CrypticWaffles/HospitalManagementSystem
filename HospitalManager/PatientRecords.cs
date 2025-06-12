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
    public partial class PatientRecords : Form
    {
        public PatientRecords()
        {
            InitializeComponent();
        }

        private void PatientRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagerDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.hospitalManagerDataSet.Patients);

        }
    }
}
