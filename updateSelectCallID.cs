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
    public partial class updateSelectCallID : Form
    {
        public updateSelectCallID()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateCallForm updateCallForm = new updateCallForm();
            updateCallForm.ShowDialog();
            this.Close();
        }
    }
}
