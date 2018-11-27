namespace Emergancy_Room_Database
{
    partial class chooseUpdateTable
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
            this.updateCallsBtn = new System.Windows.Forms.Button();
            this.updateBillsBtn = new System.Windows.Forms.Button();
            this.updateStaffBtn = new System.Windows.Forms.Button();
            this.updatePatientsBtn = new System.Windows.Forms.Button();
            this.updateDoctorsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(132, 153);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 21;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // updateCallsBtn
            // 
            this.updateCallsBtn.Location = new System.Drawing.Point(132, 91);
            this.updateCallsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updateCallsBtn.Name = "updateCallsBtn";
            this.updateCallsBtn.Size = new System.Drawing.Size(88, 40);
            this.updateCallsBtn.TabIndex = 20;
            this.updateCallsBtn.Text = "Calls";
            this.updateCallsBtn.UseVisualStyleBackColor = true;
            this.updateCallsBtn.Click += new System.EventHandler(this.updateCallsBtn_Click);
            // 
            // updateBillsBtn
            // 
            this.updateBillsBtn.Location = new System.Drawing.Point(42, 91);
            this.updateBillsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updateBillsBtn.Name = "updateBillsBtn";
            this.updateBillsBtn.Size = new System.Drawing.Size(88, 40);
            this.updateBillsBtn.TabIndex = 19;
            this.updateBillsBtn.Text = "Bills";
            this.updateBillsBtn.UseVisualStyleBackColor = true;
            this.updateBillsBtn.Click += new System.EventHandler(this.updateBillsBtn_Click);
            // 
            // updateStaffBtn
            // 
            this.updateStaffBtn.Location = new System.Drawing.Point(222, 49);
            this.updateStaffBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updateStaffBtn.Name = "updateStaffBtn";
            this.updateStaffBtn.Size = new System.Drawing.Size(88, 40);
            this.updateStaffBtn.TabIndex = 18;
            this.updateStaffBtn.Text = "Staff";
            this.updateStaffBtn.UseVisualStyleBackColor = true;
            this.updateStaffBtn.Click += new System.EventHandler(this.updateStaffBtn_Click);
            // 
            // updatePatientsBtn
            // 
            this.updatePatientsBtn.Location = new System.Drawing.Point(132, 49);
            this.updatePatientsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updatePatientsBtn.Name = "updatePatientsBtn";
            this.updatePatientsBtn.Size = new System.Drawing.Size(88, 40);
            this.updatePatientsBtn.TabIndex = 17;
            this.updatePatientsBtn.Text = "Patients";
            this.updatePatientsBtn.UseVisualStyleBackColor = true;
            this.updatePatientsBtn.Click += new System.EventHandler(this.insertPatientsBtn_Click);
            // 
            // updateDoctorsBtn
            // 
            this.updateDoctorsBtn.Location = new System.Drawing.Point(42, 49);
            this.updateDoctorsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updateDoctorsBtn.Name = "updateDoctorsBtn";
            this.updateDoctorsBtn.Size = new System.Drawing.Size(88, 40);
            this.updateDoctorsBtn.TabIndex = 16;
            this.updateDoctorsBtn.Text = "Doctors";
            this.updateDoctorsBtn.UseVisualStyleBackColor = true;
            this.updateDoctorsBtn.Click += new System.EventHandler(this.insertDoctorsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Choose Table to Update New Entity:";
            // 
            // roomBtn
            // 
            this.roomBtn.Location = new System.Drawing.Point(222, 91);
            this.roomBtn.Margin = new System.Windows.Forms.Padding(1);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(88, 40);
            this.roomBtn.TabIndex = 22;
            this.roomBtn.Text = "Room";
            this.roomBtn.UseVisualStyleBackColor = true;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // chooseUpdateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 216);
            this.Controls.Add(this.roomBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.updateCallsBtn);
            this.Controls.Add(this.updateBillsBtn);
            this.Controls.Add(this.updateStaffBtn);
            this.Controls.Add(this.updatePatientsBtn);
            this.Controls.Add(this.updateDoctorsBtn);
            this.Controls.Add(this.label1);
            this.Name = "chooseUpdateTable";
            this.Text = "chooseUpdateTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button updateCallsBtn;
        private System.Windows.Forms.Button updateBillsBtn;
        private System.Windows.Forms.Button updateStaffBtn;
        private System.Windows.Forms.Button updatePatientsBtn;
        private System.Windows.Forms.Button updateDoctorsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roomBtn;
    }
}