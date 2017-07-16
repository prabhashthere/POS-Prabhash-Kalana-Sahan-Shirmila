namespace POSSystem
{
    partial class FormIssueLoyaltyCard
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNIC = new System.Windows.Forms.TextBox();
            this.tbTelephoneNumber = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoyaltyCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Permenent Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone Number";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(371, 322);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 43);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(239, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 22);
            this.tbName.TabIndex = 5;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged_1);
            // 
            // tbNIC
            // 
            this.tbNIC.Location = new System.Drawing.Point(239, 100);
            this.tbNIC.Name = "tbNIC";
            this.tbNIC.Size = new System.Drawing.Size(230, 22);
            this.tbNIC.TabIndex = 6;
            this.tbNIC.TextChanged += new System.EventHandler(this.tbNIC_TextChanged);
            // 
            // tbTelephoneNumber
            // 
            this.tbTelephoneNumber.Location = new System.Drawing.Point(239, 247);
            this.tbTelephoneNumber.Name = "tbTelephoneNumber";
            this.tbTelephoneNumber.Size = new System.Drawing.Size(230, 22);
            this.tbTelephoneNumber.TabIndex = 7;
            this.tbTelephoneNumber.TextChanged += new System.EventHandler(this.tbTelephoneNumber_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(239, 159);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(229, 59);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.Text = "";
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(42, 322);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 43);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoyaltyCustomers
            // 
            this.btnLoyaltyCustomers.Location = new System.Drawing.Point(146, 322);
            this.btnLoyaltyCustomers.Name = "btnLoyaltyCustomers";
            this.btnLoyaltyCustomers.Size = new System.Drawing.Size(218, 43);
            this.btnLoyaltyCustomers.TabIndex = 10;
            this.btnLoyaltyCustomers.Text = "Loyalty customers";
            this.btnLoyaltyCustomers.UseVisualStyleBackColor = true;
            this.btnLoyaltyCustomers.Click += new System.EventHandler(this.btnLoyaltyCustomers_Click);
            // 
            // FormIssueLoyaltyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(525, 412);
            this.Controls.Add(this.btnLoyaltyCustomers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbTelephoneNumber);
            this.Controls.Add(this.tbNIC);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIssueLoyaltyCard";
            this.Text = "Issue Loyalty Card";
            this.Load += new System.EventHandler(this.FormIssueLoyaltyCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNIC;
        private System.Windows.Forms.TextBox tbTelephoneNumber;
        private System.Windows.Forms.RichTextBox tbAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoyaltyCustomers;
    }
}