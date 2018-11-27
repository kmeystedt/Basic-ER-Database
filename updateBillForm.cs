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
    public partial class updateBillForm : Form
    {
        public updateBillForm()
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

        private void updateBillForm_Load(object sender, EventArgs e)
        {
            f = System.Windows.Forms.Application.OpenForms["updateSelectBillID"];
            IDlbl.Text = ((updateSelectBillID)f).idChoiceTb.Text;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDlbl.Text);
            int patID = int.Parse(patientIDTB.Text);
            float amount = float.Parse(billAmountTB.Text);
            var sql = "UPDATE Bills SET Patient = @patID, Bill_amount = @amount, Bill_payed = @payed, Payment_method = @method WHERE Bill_Id = @billID";

            string connectionString = Emergancy_Room_Database.Properties.Settings.Default.ERDatabaseConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@patID", patID);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@payed", billPayedTB.Text);
                    cmd.Parameters.AddWithValue("@method", paymentMethodTB.Text);
                    cmd.Parameters.AddWithValue("@billID", id);
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
