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
    public partial class chooseUpdateTable : Form
    {
        public chooseUpdateTable()
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

        private void insertDoctorsBtn_Click(object sender, EventArgs e)//update not insert
        {
            this.Hide();
            updateSelectDoctorIDcs updateSelectDoctorIDcs = new updateSelectDoctorIDcs();
            updateSelectDoctorIDcs.ShowDialog();
            this.Close();
        }

        private void insertPatientsBtn_Click(object sender, EventArgs e)//update not insert
        {
            this.Hide();
            updateSelectPatientID updateSelectPatientID = new updateSelectPatientID();
            updateSelectPatientID.ShowDialog();
            this.Close();
        }

        private void updateStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateSelectStaffID updateSelectStaffID = new updateSelectStaffID();
            updateSelectStaffID.ShowDialog();
            this.Close();
        }

        private void updateBillsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateSelectBillID updateSelectBillID = new updateSelectBillID();
            updateSelectBillID.ShowDialog();
            this.Close();
        }

        private void updateCallsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateSelectCallID updateSelectCallID = new updateSelectCallID();
            updateSelectCallID.ShowDialog();
            this.Close();
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateSelectRoomID updateSelectRoomID = new updateSelectRoomID();
            updateSelectRoomID.ShowDialog();
            this.Close();
        }
    }
}
