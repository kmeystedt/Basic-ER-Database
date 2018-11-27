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
    public partial class insertBillForm : Form
    {
        public insertBillForm()
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
            var sql = "INSERT INTO Bills (Patient, Bill_amount, Bill_payed, Payment_Method) " +
                      "VALUES (@patient, @bill_amount, @bill_payed, @payment_method);";

            string connectionString = Emergancy_Room_Database.Properties.Settings.Default.ERDatabaseConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@patient", patientIDTB.Text);
                    cmd.Parameters.AddWithValue("@bill_amount", billAmountTB.Text);
                    cmd.Parameters.AddWithValue("@bill_payed", billPayedTB.Text);
                    cmd.Parameters.AddWithValue("@payment_method", paymentMethodTB.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Hide();
            displayBillsTable displayBillsTable = new displayBillsTable();
            displayBillsTable.ShowDialog();
            this.Close();
        }
    }
}
