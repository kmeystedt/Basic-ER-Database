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
    public partial class updatePatientsForm : Form
    {
        public updatePatientsForm()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f;

        private void updatePatientsForm_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["updateSelectPatientID"];
            IDlbl.Text = ((updateSelectPatientID)f).idChoiceTb.Text;
        }

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
            int roomNum = int.Parse(RoomTB.Text);
            int bill = int.Parse(billTB.Text);
            int call_id = int.Parse(callIDTB.Text);
            var sql = "UPDATE Patients SET Fname = @firstName, Mint = @middleInt, Lname = @lastName, Sex = @sex, Address = @address, " +
                "Date_of_birth = @dateBirth, Room# = @room, Bill = @bill, Perscription = @pers, Diagnosis = @diag, Call_id = @callId WHERE Patient_Id = @id";

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
                    cmd.Parameters.AddWithValue("@bill", bill);
                    cmd.Parameters.AddWithValue("@pers", perscriptionTB.Text);
                    cmd.Parameters.AddWithValue("@diag", diagnosisTB.Text);
                    cmd.Parameters.AddWithValue("@callId", call_id);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Hide();
            displayPatientTable displayPatientTable = new displayPatientTable();
            displayPatientTable.ShowDialog();
            this.Close();
        }
    }
}
