﻿namespace Emergancy_Room_Database
{
    partial class searchSelectDoctorID
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
            this.label2 = new System.Windows.Forms.Label();
            this.idChoiceTb = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID of Doctor:";
            // 
            // idChoiceTb
            // 
            this.idChoiceTb.Location = new System.Drawing.Point(201, 55);
            this.idChoiceTb.Name = "idChoiceTb";
            this.idChoiceTb.Size = new System.Drawing.Size(88, 20);
            this.idChoiceTb.TabIndex = 29;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(111, 129);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(1);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(88, 40);
            this.enterBtn.TabIndex = 28;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(201, 129);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 27;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choose ID of Doctor Entity To Search For:";
            // 
            // searchSelectDoctorID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idChoiceTb);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label1);
            this.Name = "searchSelectDoctorID";
            this.Text = "searchSelectDoctorID";
            this.Load += new System.EventHandler(this.searchSelectDoctorID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox idChoiceTb;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label1;
    }
}