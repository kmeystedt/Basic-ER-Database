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
    public partial class searchDoctorByIDDisplay : Form
    {
        public searchDoctorByIDDisplay()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f;

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void selectDoctorDisplay_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["searchSelectDoctorID"];
            IDlbl.Text = ((searchSelectDoctorID)f).idChoiceTb.Text;

            doctorsTableAdapter.selectByID(eRDatabaseDataSet1.Doctors, int.Parse(IDlbl.Text));
        }
    }
}
