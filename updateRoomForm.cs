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
    public partial class updateRoomForm : Form
    {
        public updateRoomForm()
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

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDlbl.Text);
            int doc = int.Parse(doctorIDTB.Text);
            int staff = int.Parse(staffIDTB.Text);
            int pat = int.Parse(patientTB.Text);
            var sql = "UPDATE Room SET Doctor = @docID, Staff = @staffID, Patient = @patID, Occupied = @occ WHERE Room_Id = @roomID";

            string connectionString = Emergancy_Room_Database.Properties.Settings.Default.ERDatabaseConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@patID", pat);
                    cmd.Parameters.AddWithValue("@docID", doc);
                    cmd.Parameters.AddWithValue("@staffID", staff);
                    cmd.Parameters.AddWithValue("@occ", occupiedTB.Text);
                    cmd.Parameters.AddWithValue("@roomID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Hide();
            displayRoomsTable displayRoomsTable = new displayRoomsTable();
            displayRoomsTable.ShowDialog();
            this.Close();
        }

        private void updateCallsForm_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["updateSelectRoomID"];
            IDlbl.Text = ((updateSelectRoomID)f).idChoiceTb.Text;
        }
    }
}
