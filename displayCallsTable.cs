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
    public partial class displayCallsTable : Form
    {
        public displayCallsTable()
        {
            InitializeComponent();
        }

        private void callsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.callsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRDatabaseDataSet1);

        }

        private void displayCallsTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRDatabaseDataSet1.Calls' table. You can move, or remove it, as needed.
            this.callsTableAdapter.Fill(this.eRDatabaseDataSet1.Calls);

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
