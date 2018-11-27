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
    public partial class updateCallForm : Form
    {
        public updateCallForm()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f;

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDlbl.Text);
            var sql = "UPDATE Calls SET Fname = @firstName, Mint = @middleInt, Lname = @lastName, Address = @address, Reason_for_call = @reason WHERE Call_Id = @id";

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
                    cmd.Parameters.AddWithValue("@reason", reasonForCallTB.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Hide();
            displayCallsTable displayCallsTable = new displayCallsTable();
            displayCallsTable.ShowDialog();
            this.Close();
        }

        private void updateCallForm_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["updateSelectCallID"];
            IDlbl.Text = ((updateSelectCallID)f).idChoiceTb.Text;
        }
    }
}
