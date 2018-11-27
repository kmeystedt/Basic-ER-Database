namespace Emergancy_Room_Database
{
    partial class updateBillForm
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.billAmountTB = new System.Windows.Forms.TextBox();
            this.billPayedTB = new System.Windows.Forms.TextBox();
            this.paymentMethodTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(269, 153);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(1);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(88, 40);
            this.returnBtn.TabIndex = 24;
            this.returnBtn.Text = "Return to Main Menu";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(42, 153);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(1);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(88, 40);
            this.enterBtn.TabIndex = 23;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter Updated and Unchanged Data:";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(428, 17);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(35, 13);
            this.IDlbl.TabIndex = 35;
            this.IDlbl.Text = "label9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Chosen ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Patient ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Bill Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Bill Payed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Payment Method:";
            // 
            // patientIDTB
            // 
            this.patientIDTB.Location = new System.Drawing.Point(125, 55);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(100, 20);
            this.patientIDTB.TabIndex = 40;
            // 
            // billAmountTB
            // 
            this.billAmountTB.Location = new System.Drawing.Point(125, 97);
            this.billAmountTB.Name = "billAmountTB";
            this.billAmountTB.Size = new System.Drawing.Size(100, 20);
            this.billAmountTB.TabIndex = 41;
            // 
            // billPayedTB
            // 
            this.billPayedTB.Location = new System.Drawing.Point(361, 55);
            this.billPayedTB.Name = "billPayedTB";
            this.billPayedTB.Size = new System.Drawing.Size(100, 20);
            this.billPayedTB.TabIndex = 42;
            // 
            // paymentMethodTB
            // 
            this.paymentMethodTB.Location = new System.Drawing.Point(361, 97);
            this.paymentMethodTB.Name = "paymentMethodTB";
            this.paymentMethodTB.Size = new System.Drawing.Size(100, 20);
            this.paymentMethodTB.TabIndex = 43;
            // 
            // updateBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 210);
            this.Controls.Add(this.paymentMethodTB);
            this.Controls.Add(this.billPayedTB);
            this.Controls.Add(this.billAmountTB);
            this.Controls.Add(this.patientIDTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.label1);
            this.Name = "updateBillForm";
            this.Text = "updateBillForm";
            this.Load += new System.EventHandler(this.updateBillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.TextBox billAmountTB;
        private System.Windows.Forms.TextBox billPayedTB;
        private System.Windows.Forms.TextBox paymentMethodTB;
    }
}