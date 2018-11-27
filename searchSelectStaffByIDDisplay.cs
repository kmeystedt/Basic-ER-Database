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
    public partial class searchSelectStaffByIDDisplay : Form
    {
        public searchSelectStaffByIDDisplay()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f;

        private void searchSelectStaffByIDDisplay_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["searchSelectStaffID"];
            IDlbl.Text = ((searchSelectStaffID)f).idChoiceTb.Text;

            staffTableAdapter.selectByID(eRDatabaseDataSet1.Staff, int.Parse(IDlbl.Text));
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

       
    }
}
