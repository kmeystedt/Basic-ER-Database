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
    public partial class choiceDisplayTable : Form
    {
        public choiceDisplayTable()
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

        private void displayDoctorsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            displayDoctorsTable displayDoctorsTable = new displayDoctorsTable();
            displayDoctorsTable.ShowDialog();
            this.Close();
        }

        private void displayPatientsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            displayPatientTable displayPatientTable = new displayPatientTable();
            displayPatientTable.ShowDialog();
            this.Close();
        }

        private void displayStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            displayStaffTable displayStaffTable = new displayStaffTable();
            displayStaffTable.ShowDialog();
            this.Close();
        }

        private void displayBillsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            displayBillsTable displayBillsTable = new displayBillsTable();
            displayBillsTable.ShowDialog();
            this.Close();
        }

        private void displayCallsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            displayCallsTable displayCallsTable = new displayCallsTable();
            displayCallsTable.ShowDialog();
            this.Close();
        }

        private void displayRoomsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            displayRoomsTable displayRoomsTable = new displayRoomsTable();
            displayRoomsTable.ShowDialog();
            this.Close();
        }
    }
}
