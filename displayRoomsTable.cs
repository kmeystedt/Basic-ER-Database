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
    public partial class displayRoomsTable : Form
    {
        public displayRoomsTable()
        {
            InitializeComponent();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRDatabaseDataSet1);

        }

        private void displayRoomsTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRDatabaseDataSet1.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.eRDatabaseDataSet1.Room);

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }
    }
}
