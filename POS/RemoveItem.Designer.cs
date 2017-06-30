namespace StockKeeper
{
    partial class RemoveItem
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
            this.lblstockid = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtstockid = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.lblcanreturn = new System.Windows.Forms.Label();
            this.cbxcanreturn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblstockid
            // 
            this.lblstockid.AutoSize = true;
            this.lblstockid.Location = new System.Drawing.Point(86, 65);
            this.lblstockid.Name = "lblstockid";
            this.lblstockid.Size = new System.Drawing.Size(98, 17);
            this.lblstockid.TabIndex = 0;
            this.lblstockid.Text = "Enter Stock ID";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(86, 125);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(56, 17);
            this.lblamount.TabIndex = 1;
            this.lblamount.Text = "Amount";
            // 
            // txtstockid
            // 
            this.txtstockid.Location = new System.Drawing.Point(305, 65);
            this.txtstockid.Name = "txtstockid";
            this.txtstockid.Size = new System.Drawing.Size(100, 22);
            this.txtstockid.TabIndex = 2;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(305, 120);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 22);
            this.txtamount.TabIndex = 3;
            // 
            // lblcanreturn
            // 
            this.lblcanreturn.AutoSize = true;
            this.lblcanreturn.Location = new System.Drawing.Point(86, 202);
            this.lblcanreturn.Name = "lblcanreturn";
            this.lblcanreturn.Size = new System.Drawing.Size(80, 17);
            this.lblcanreturn.TabIndex = 4;
            this.lblcanreturn.Text = "Can Return";
            // 
            // cbxcanreturn
            // 
            this.cbxcanreturn.AutoSize = true;
            this.cbxcanreturn.Location = new System.Drawing.Point(305, 198);
            this.cbxcanreturn.Name = "cbxcanreturn";
            this.cbxcanreturn.Size = new System.Drawing.Size(18, 17);
            this.cbxcanreturn.TabIndex = 5;
            this.cbxcanreturn.UseVisualStyleBackColor = true;
            // 
            // RemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 475);
            this.Controls.Add(this.cbxcanreturn);
            this.Controls.Add(this.lblcanreturn);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtstockid);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblstockid);
            this.Name = "RemoveItem";
            this.Text = "RemoveItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstockid;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtstockid;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label lblcanreturn;
        private System.Windows.Forms.CheckBox cbxcanreturn;
    }
}