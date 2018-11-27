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
    public partial class updateStaffFormcs : Form
    {
        public updateStaffFormcs()
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

        private void updateStaffFormcs_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["updateSelectStaffID"];
            IDlbl.Text = ((updateSelectStaffID)f).idChoiceTb.Text;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDlbl.Text);
            int roomNum = int.Parse(RoomTB.Text);
            var sql = "UPDATE Staff SET Fname = @firstName, Mint = @middleInt, Lname = @lastName, Sex = @sex, Address = @address, Date_of_birth = @dateBirth, Room# = @room WHERE Doctor_Id = @id";

            string connectionString = Emergancy_Room_Database.Properties.Settings.Default.ERDatabaseConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@firstName", fNameTB.Text);
                    cmd.Parameters.AddWithValue("@middleInt", MITB.Text);
                    cmd.Parameters.AddWithValue("@lastName", lNameTB.Text);
                    cmd.Parameters.AddWithValue("@sex", RoomTB.Text);
                    cmd.Parameters.AddWithValue("@address", addressTB.Text);
                    cmd.Parameters.AddWithValue("@dateBirth", dateOfBirthTB.Text);
                    cmd.Parameters.AddWithValue("@room", roomNum);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Hide();
            displayStaffTable displayStaffTable = new displayStaffTable();
            displayStaffTable.ShowDialog();
            this.Close();
        }
    }
}
