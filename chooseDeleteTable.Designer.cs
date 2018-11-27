namespace Emergancy_Room_Database
{
    partial class chooseDeleteTable
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.deleteCallsBtn = new System.Windows.Forms.Button();
            this.deleteBillsBtn = new System.Windows.Forms.Button();
            this.deleteStaffBtn = new System.Windows.Forms.Button();
            this.deletePatientsBtn = new System.Windows.Forms.Button();
            this.deleteDoctorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(111, 164);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 21;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // deleteCallsBtn
            // 
            this.deleteCallsBtn.Location = new System.Drawing.Point(111, 95);
            this.deleteCallsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteCallsBtn.Name = "deleteCallsBtn";
            this.deleteCallsBtn.Size = new System.Drawing.Size(88, 40);
            this.deleteCallsBtn.TabIndex = 20;
            this.deleteCallsBtn.Text = "Calls";
            this.deleteCallsBtn.UseVisualStyleBackColor = true;
            this.deleteCallsBtn.Click += new System.EventHandler(this.deleteCallsBtn_Click);
            // 
            // deleteBillsBtn
            // 
            this.deleteBillsBtn.Location = new System.Drawing.Point(21, 95);
            this.deleteBillsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteBillsBtn.Name = "deleteBillsBtn";
            this.deleteBillsBtn.Size = new System.Drawing.Size(88, 40);
            this.deleteBillsBtn.TabIndex = 19;
            this.deleteBillsBtn.Text = "Bills";
            this.deleteBillsBtn.UseVisualStyleBackColor = true;
            this.deleteBillsBtn.Click += new System.EventHandler(this.deleteBillsBtn_Click);
            // 
            // deleteStaffBtn
            // 
            this.deleteStaffBtn.Location = new System.Drawing.Point(202, 75);
            this.deleteStaffBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteStaffBtn.Name = "deleteStaffBtn";
            this.deleteStaffBtn.Size = new System.Drawing.Size(88, 40);
            this.deleteStaffBtn.TabIndex = 18;
            this.deleteStaffBtn.Text = "Staff";
            this.deleteStaffBtn.UseVisualStyleBackColor = true;
            this.deleteStaffBtn.Click += new System.EventHandler(this.deleteStaffBtn_Click);
            // 
            // deletePatientsBtn
            // 
            this.deletePatientsBtn.Location = new System.Drawing.Point(111, 53);
            this.deletePatientsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deletePatientsBtn.Name = "deletePatientsBtn";
            this.deletePatientsBtn.Size = new System.Drawing.Size(88, 40);
            this.deletePatientsBtn.TabIndex = 17;
            this.deletePatientsBtn.Text = "Patients";
            this.deletePatientsBtn.UseVisualStyleBackColor = true;
            this.deletePatientsBtn.Click += new System.EventHandler(this.insertPatientsBtn_Click);
            // 
            // deleteDoctorBtn
            // 
            this.deleteDoctorBtn.Location = new System.Drawing.Point(21, 53);
            this.deleteDoctorBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteDoctorBtn.Name = "deleteDoctorBtn";
            this.deleteDoctorBtn.Size = new System.Drawing.Size(88, 40);
            this.deleteDoctorBtn.TabIndex = 16;
            this.deleteDoctorBtn.Text = "Doctors";
            this.deleteDoctorBtn.UseVisualStyleBackColor = true;
            this.deleteDoctorBtn.Click += new System.EventHandler(this.insertDoctorsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Choose Table to Delete Existing Entity:";
            // 
            // chooseDeleteTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 215);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.deleteCallsBtn);
            this.Controls.Add(this.deleteBillsBtn);
            this.Controls.Add(this.deleteStaffBtn);
            this.Controls.Add(this.deletePatientsBtn);
            this.Controls.Add(this.deleteDoctorBtn);
            this.Controls.Add(this.label1);
            this.Name = "chooseDeleteTable";
            this.Text = "chooseDeleteTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button deleteCallsBtn;
        private System.Windows.Forms.Button deleteBillsBtn;
        private System.Windows.Forms.Button deleteStaffBtn;
        private System.Windows.Forms.Button deletePatientsBtn;
        private System.Windows.Forms.Button deleteDoctorBtn;
        private System.Windows.Forms.Label label1;
    }
}