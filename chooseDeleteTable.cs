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
    public partial class chooseDeleteTable : Form
    {
        public chooseDeleteTable()
        {
            InitializeComponent();
        }

        private void insertDoctorsBtn_Click(object sender, EventArgs e)//delete not insert
        {
            this.Hide();
            deleteSelectDoctorID deleteSelectDoctorID = new deleteSelectDoctorID();
            deleteSelectDoctorID.ShowDialog();
            this.Close();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void insertPatientsBtn_Click(object sender, EventArgs e)//delete not insert
        {
            this.Hide();
            deleteSelectPatientID deleteSelectPatientID = new deleteSelectPatientID();
            deleteSelectPatientID.ShowDialog();
            this.Close();
        }

        private void deleteBillsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteSelectBillID deleteSelectBillID = new deleteSelectBillID();
            deleteSelectBillID.ShowDialog();
            this.Close();
        }

        private void deleteCallsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteSelectCallsID deleteSelectCallsID = new deleteSelectCallsID();
            deleteSelectCallsID.ShowDialog();
            this.Close();
        }

        private void deleteStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteSelectStaffID deleteSelectStaffID = new deleteSelectStaffID();
            deleteSelectStaffID.ShowDialog();
            this.Close();
        }
    }
}
