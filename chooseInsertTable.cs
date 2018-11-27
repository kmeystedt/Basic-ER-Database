using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergancy_Room_Database
{
    public partial class chooseInsertTable : Form
    {
        public chooseInsertTable()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void insertDoctorsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            insertDoctorForm insertDoctorForm = new insertDoctorForm();
            insertDoctorForm.ShowDialog();
            this.Close();
        }

        private void insertPatientsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            insertPatientForm insertPatientForm = new insertPatientForm();
            insertPatientForm.ShowDialog();
            this.Close();
        }

        private void insertStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            insertStaffForm insertStaffForm = new insertStaffForm();
            insertStaffForm.ShowDialog();
            this.Close();
        }

        private void insertBillsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            insertBillForm insertBillForm = new insertBillForm();
            insertBillForm.ShowDialog();
            this.Close();
        }

        private void insertCallsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            insertCallForm insertCallForm = new insertCallForm();
            insertCallForm.ShowDialog();
            this.Close();
        }

        private void insertRoomsBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
