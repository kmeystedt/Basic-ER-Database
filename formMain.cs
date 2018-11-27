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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void displayTableBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            choiceDisplayTable displayTableChoice = new choiceDisplayTable();
            displayTableChoice.ShowDialog();
            this.Close();
        }

        private void insertTableBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseInsertTable chooseInsertTable = new chooseInsertTable();
            chooseInsertTable.ShowDialog();
            this.Close();
        }

        private void updateTableBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseUpdateTable chooseUpdateTable = new chooseUpdateTable();
            chooseUpdateTable.ShowDialog();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteFromTableBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseDeleteTable chooseDeleteTable = new chooseDeleteTable();
            chooseDeleteTable.ShowDialog();
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseSearchDatabase chooseSearchDatabase = new chooseSearchDatabase();
            chooseSearchDatabase.ShowDialog();
            this.Close();
        }
    }
}
