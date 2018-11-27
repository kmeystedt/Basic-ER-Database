namespace Emergancy_Room_Database
{
    partial class insertBillForm
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
            this.insertBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.billAmountTB = new System.Windows.Forms.TextBox();
            this.billPayedTB = new System.Windows.Forms.TextBox();
            this.paymentMethodTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(661, 583);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(230, 83);
            this.returnBtn.TabIndex = 19;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(90, 583);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(242, 83);
            this.insertBtn.TabIndex = 18;
            this.insertBtn.Text = "Insert to Table";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(553, 55);
            this.label8.TabIndex = 17;
            this.label8.Text = "Insert New Bill to Table:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bill Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bill Payed (Y/N):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Payment Method:";
            // 
            // patientIDTB
            // 
            this.patientIDTB.Location = new System.Drawing.Point(264, 128);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(182, 38);
            this.patientIDTB.TabIndex = 24;
            // 
            // billAmountTB
            // 
            this.billAmountTB.Location = new System.Drawing.Point(264, 323);
            this.billAmountTB.Name = "billAmountTB";
            this.billAmountTB.Size = new System.Drawing.Size(182, 38);
            this.billAmountTB.TabIndex = 25;
            // 
            // billPayedTB
            // 
            this.billPayedTB.Location = new System.Drawing.Point(709, 128);
            this.billPayedTB.Name = "billPayedTB";
            this.billPayedTB.Size = new System.Drawing.Size(182, 38);
            this.billPayedTB.TabIndex = 26;
            // 
            // paymentMethodTB
            // 
            this.paymentMethodTB.Location = new System.Drawing.Point(709, 326);
            this.paymentMethodTB.Name = "paymentMethodTB";
            this.paymentMethodTB.Size = new System.Drawing.Size(182, 38);
            this.paymentMethodTB.TabIndex = 27;
            // 
            // insertBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 690);
            this.Controls.Add(this.paymentMethodTB);
            this.Controls.Add(this.billPayedTB);
            this.Controls.Add(this.billAmountTB);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label8);
            this.Name = "insertBillForm";
            this.Text = "insertBillForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.TextBox billAmountTB;
        private System.Windows.Forms.TextBox billPayedTB;
        private System.Windows.Forms.TextBox paymentMethodTB;
    }
}