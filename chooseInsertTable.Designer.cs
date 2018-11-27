namespace Emergancy_Room_Database
{
    partial class chooseInsertTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.insertCallsBtn = new System.Windows.Forms.Button();
            this.insertBillsBtn = new System.Windows.Forms.Button();
            this.insertStaffBtn = new System.Windows.Forms.Button();
            this.insertPatientsBtn = new System.Windows.Forms.Button();
            this.insertDoctorsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Table to Insert New Entity:";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(106, 160);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 14;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // insertCallsBtn
            // 
            this.insertCallsBtn.Location = new System.Drawing.Point(106, 91);
            this.insertCallsBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.insertCallsBtn.Name = "insertCallsBtn";
            this.insertCallsBtn.Size = new System.Drawing.Size(88, 40);
            this.insertCallsBtn.TabIndex = 12;
            this.insertCallsBtn.Text = "Calls";
            this.insertCallsBtn.UseVisualStyleBackColor = true;
            this.insertCallsBtn.Click += new System.EventHandler(this.insertCallsBtn_Click);
            // 
            // insertBillsBtn
            // 
            this.insertBillsBtn.Location = new System.Drawing.Point(16, 91);
            this.insertBillsBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.insertBillsBtn.Name = "insertBillsBtn";
            this.insertBillsBtn.Size = new System.Drawing.Size(88, 40);
            this.insertBillsBtn.TabIndex = 11;
            this.insertBillsBtn.Text = "Bills";
            this.insertBillsBtn.UseVisualStyleBackColor = true;
            this.insertBillsBtn.Click += new System.EventHandler(this.insertBillsBtn_Click);
            // 
            // insertStaffBtn
            // 
            this.insertStaffBtn.Location = new System.Drawing.Point(197, 71);
            this.insertStaffBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.insertStaffBtn.Name = "insertStaffBtn";
            this.insertStaffBtn.Size = new System.Drawing.Size(88, 40);
            this.insertStaffBtn.TabIndex = 10;
            this.insertStaffBtn.Text = "Staff";
            this.insertStaffBtn.UseVisualStyleBackColor = true;
            this.insertStaffBtn.Click += new System.EventHandler(this.insertStaffBtn_Click);
            // 
            // insertPatientsBtn
            // 
            this.insertPatientsBtn.Location = new System.Drawing.Point(106, 49);
            this.insertPatientsBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.insertPatientsBtn.Name = "insertPatientsBtn";
            this.insertPatientsBtn.Size = new System.Drawing.Size(88, 40);
            this.insertPatientsBtn.TabIndex = 9;
            this.insertPatientsBtn.Text = "Patients";
            this.insertPatientsBtn.UseVisualStyleBackColor = true;
            this.insertPatientsBtn.Click += new System.EventHandler(this.insertPatientsBtn_Click);
            // 
            // insertDoctorsBtn
            // 
            this.insertDoctorsBtn.Location = new System.Drawing.Point(16, 49);
            this.insertDoctorsBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.insertDoctorsBtn.Name = "insertDoctorsBtn";
            this.insertDoctorsBtn.Size = new System.Drawing.Size(88, 40);
            this.insertDoctorsBtn.TabIndex = 8;
            this.insertDoctorsBtn.Text = "Doctors";
            this.insertDoctorsBtn.UseVisualStyleBackColor = true;
            this.insertDoctorsBtn.Click += new System.EventHandler(this.insertDoctorsBtn_Click);
            // 
            // chooseInsertTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 212);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.insertCallsBtn);
            this.Controls.Add(this.insertBillsBtn);
            this.Controls.Add(this.insertStaffBtn);
            this.Controls.Add(this.insertPatientsBtn);
            this.Controls.Add(this.insertDoctorsBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "chooseInsertTable";
            this.Text = "chooseInsertTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button insertCallsBtn;
        private System.Windows.Forms.Button insertBillsBtn;
        private System.Windows.Forms.Button insertStaffBtn;
        private System.Windows.Forms.Button insertPatientsBtn;
        private System.Windows.Forms.Button insertDoctorsBtn;
    }
}