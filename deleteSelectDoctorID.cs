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
    public partial class deleteSelectDoctorID : Form
    {
        public deleteSelectDoctorID()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idChoiceTb.Text);
            var sql = "DELETE FROM Doctors WHERE Doctor_Id = @id";

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
            displayDoctorsTable displayDoctorsTable = new displayDoctorsTable();
            displayDoctorsTable.ShowDialog();
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
