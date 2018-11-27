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
    public partial class displayBillsTable : Form
    {
        public displayBillsTable()
        {
            InitializeComponent();
        }

        private void billsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRDatabaseDataSet1);

        }

        private void displayBillsTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRDatabaseDataSet1.Bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.eRDatabaseDataSet1.Bills);

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
