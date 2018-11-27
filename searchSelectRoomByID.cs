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
    public partial class searchSelectRoomByID : Form
    {
        public searchSelectRoomByID()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f;

        private void searchSelectRoomByID_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["searchSelectRoomID"];
            IDlbl.Text = ((searchSelectRoomID)f).idChoiceTb.Text;
            
            string connectionString = Emergancy_Room_Database.Properties.Settings.Default.ERDatabaseConnectionString;

            var con = new SqlConnection(connectionString);

            doctorInRoom(con);
            patientInRoom(con);
            staffInRoom(con);

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            this.Close();
        }

        private void doctorInRoom(SqlConnection connect)
        {
            var sql = "SELECT Fname, Mint, Lname FROM Doctors WHERE Room# = " + IDlbl.Text;
            var dataAdapter = new SqlDataAdapter(sql, connect);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            doctorDataGridView.ReadOnly = true;
            doctorDataGridView.DataSource = ds.Tables[0];
        }

        private void patientInRoom(SqlConnection connect)
        {
            var sql = "SELECT Fname, Mint, Lname FROM Patients WHERE Room# = " + IDlbl.Text;
            var dataAdapter = new SqlDataAdapter(sql, connect);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            patientDataGridView.ReadOnly = true;
            patientDataGridView.DataSource = ds.Tables[0];
        }

        private void staffInRoom(SqlConnection connect)
        {
            var sql = "SELECT Fname, Mint, Lname FROM Staff WHERE Room# = " + IDlbl.Text;
            var dataAdapter = new SqlDataAdapter(sql, connect);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            staffDataGridView.ReadOnly = true;
            staffDataGridView.DataSource = ds.Tables[0];
        }
    }
}
