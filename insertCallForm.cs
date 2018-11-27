using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergancy_Room_Database
{
    public partial class insertCallForm : Form
    {
        public insertCallForm()
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

        private void insertBtn_Click(object sender, EventArgs e)
        {
            var sql = "INSERT INTO Calls (Fname, Mint, Lname, Address, Reason_for_call) " +
                      "VALUES (@firstName, @middleInt, @lastName, @address, @reason);";

            string connectionString = Emergancy_Room_Database.Properties.Settings.Default.ERDatabaseConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@firstName", fNameTB.Text);
                    cmd.Parameters.AddWithValue("@middleInt", MITB.Text);
                    cmd.Parameters.AddWithValue("@lastName", lNameTB.Text);
                    cmd.Parameters.AddWithValue("@address", addressTB.Text);
                    cmd.Parameters.AddWithValue("@reason", reasonTB.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Hide();
            displayCallsTable displayCallsTable = new displayCallsTable();
            displayCallsTable.ShowDialog();
            this.Close();
        }
    }
}
