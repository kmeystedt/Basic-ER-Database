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
    public partial class updateSelectStaffID : Form
    {
        public updateSelectStaffID()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateStaffFormcs updateStaffFormcs = new updateStaffFormcs();
            updateStaffFormcs.ShowDialog();
        }
    }
}
