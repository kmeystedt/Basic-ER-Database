namespace Emergancy_Room_Database
{
    partial class updateDoctorForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.MITB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.dateOfBirthTB = new System.Windows.Forms.TextBox();
            this.RoomTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(256, 180);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(86, 35);
            this.returnBtn.TabIndex = 31;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(97, 180);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(91, 35);
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Text = "Update in Table";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // MITB
            // 
            this.MITB.Location = new System.Drawing.Point(97, 88);
            this.MITB.Margin = new System.Windows.Forms.Padding(1);
            this.MITB.Name = "MITB";
            this.MITB.Size = new System.Drawing.Size(27, 20);
            this.MITB.TabIndex = 28;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(322, 49);
            this.addressTB.Margin = new System.Windows.Forms.Padding(1);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(259, 20);
            this.addressTB.TabIndex = 27;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(97, 127);
            this.lNameTB.Margin = new System.Windows.Forms.Padding(1);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(75, 20);
            this.lNameTB.TabIndex = 26;
            // 
            // dateOfBirthTB
            // 
            this.dateOfBirthTB.Location = new System.Drawing.Point(322, 87);
            this.dateOfBirthTB.Margin = new System.Windows.Forms.Padding(1);
            this.dateOfBirthTB.Name = "dateOfBirthTB";
            this.dateOfBirthTB.Size = new System.Drawing.Size(87, 20);
            this.dateOfBirthTB.TabIndex = 25;
            // 
            // RoomTB
            // 
            this.RoomTB.Location = new System.Drawing.Point(320, 129);
            this.RoomTB.Margin = new System.Windows.Forms.Padding(1);
            this.RoomTB.Name = "RoomTB";
            this.RoomTB.Size = new System.Drawing.Size(27, 20);
            this.RoomTB.TabIndex = 24;
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(97, 49);
            this.fNameTB.Margin = new System.Windows.Forms.Padding(1);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(75, 20);
            this.fNameTB.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Middle Initial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Room #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(435, 19);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(35, 13);
            this.IDlbl.TabIndex = 33;
            this.IDlbl.Text = "label9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Chosen ID: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "Enter Updated and Unchanged Data:";
            // 
            // updateDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 252);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.MITB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.dateOfBirthTB);
            this.Controls.Add(this.RoomTB);
            this.Controls.Add(this.fNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "updateDoctorForm";
            this.Text = "updateDoctorForm";
            this.Load += new System.EventHandler(this.updateDoctorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox MITB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox dateOfBirthTB;
        private System.Windows.Forms.TextBox RoomTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}