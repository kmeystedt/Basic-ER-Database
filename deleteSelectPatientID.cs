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
    public partial class deleteSelectPatientID : Form
    {
        public deleteSelectPatientID()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idChoiceTb.Text);
            var sql = "DELETE FROM Patients WHERE Patient_Id = @id";

            string connectionString = Emergancy_Room_Database.Properties.Settings.Default.ERDatabaseConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Hide();
            displayPatientTable displayPatientTable = new displayPatientTable();
            displayPatientTable.ShowDialog();
            this.Close();
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
