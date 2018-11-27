using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergancy_Room_Database
{
    public partial class searchSelectDoctorID : Form
    {
        public searchSelectDoctorID()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchDoctorByIDDisplay selectDoctorDisplay = new searchDoctorByIDDisplay();
            selectDoctorDisplay.ShowDialog();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void searchSelectDoctorID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRDatabaseDataSet1.Doctors' table. You can move, or remove it, as needed.
            
        }

     
    }
}
