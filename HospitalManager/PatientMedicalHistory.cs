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
    public partial class PatientMedicalHistory : Form
    {
        public PatientMedicalHistory()
        {
            InitializeComponent();
        }

        private void PatientMedicalHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagerDataSet.MedicalHistories' table. You can move, or remove it, as needed.
            this.medicalHistoriesTableAdapter.Fill(this.hospitalManagerDataSet.MedicalHistories);

        }
    }
}
