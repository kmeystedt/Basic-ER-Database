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
    public partial class displayStaffTable : Form
    {
        public displayStaffTable()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRDatabaseDataSet1);

        }

        private void displayStaffTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRDatabaseDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.eRDatabaseDataSet1.Staff);

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
