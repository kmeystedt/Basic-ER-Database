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
    public partial class searchSelectCallByID : Form
    {
        public searchSelectCallByID()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f;

        private void searchSelectCallByID_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["searchSelectCallID"];
            IDlbl.Text = ((searchSelectCallID)f).idChoiceTb.Text;

            callsTableAdapter.selectByID(eRDatabaseDataSet1.Calls, int.Parse(IDlbl.Text));
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
