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
    public partial class chooseSearchDatabase : Form
    {
        public chooseSearchDatabase()
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

        private void searchDoctorsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchSelectDoctorID searchSelectDoctorID = new searchSelectDoctorID();
            searchSelectDoctorID.ShowDialog();
            this.Close();
        }

        private void searchPatientsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchSelectPatientsID searchSelectPatientsID = new searchSelectPatientsID();
            searchSelectPatientsID.ShowDialog();
            this.Close();
        }

        private void searchStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchSelectStaffID searchSelectStaffID = new searchSelectStaffID();
            searchSelectStaffID.ShowDialog();
            this.Close();
        }

        private void searchBillsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchSelectBillID searchSelectBillID = new searchSelectBillID();
            searchSelectBillID.ShowDialog();
            this.Close();
        }

        private void searchCallsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchSelectCallID searchSelectCallID = new searchSelectCallID();
            searchSelectCallID.ShowDialog();
            this.Close();
        }

        private void searchRoomsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchSelectRoomID searchSelectRoomID = new searchSelectRoomID();
            searchSelectRoomID.ShowDialog();
            this.Close();
        }
    }
}
