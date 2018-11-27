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
    public partial class displayDoctorsTable : Form
    {
        public displayDoctorsTable()
        {
            InitializeComponent();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRDatabaseDataSet1);

        }

        private void displayDoctorsTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRDatabaseDataSet1.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.eRDatabaseDataSet1.Doctors);

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
