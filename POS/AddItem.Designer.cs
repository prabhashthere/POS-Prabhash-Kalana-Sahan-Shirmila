namespace StockKeeper
{
    partial class AddItem
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblexpiredate = new System.Windows.Forms.Label();
            this.lblunitprice = new System.Windows.Forms.Label();
            this.lblvendorid = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.txtstockid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtexpdate = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtvendorid = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstockid
            // 
            this.lblstockid.AutoSize = true;
            this.lblstockid.Location = new System.Drawing.Point(103, 50);
            this.lblstockid.Name = "lblstockid";
            this.lblstockid.Size = new System.Drawing.Size(98, 17);
            this.lblstockid.TabIndex = 0;
            this.lblstockid.Text = "Enter Stock ID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(103, 106);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(83, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Enter Name";
            // 
            // lblexpiredate
            // 
            this.lblexpiredate.AutoSize = true;
            this.lblexpiredate.Location = new System.Drawing.Point(103, 164);
            this.lblexpiredate.Name = "lblexpiredate";
            this.lblexpiredate.Size = new System.Drawing.Size(80, 17);
            this.lblexpiredate.TabIndex = 2;
            this.lblexpiredate.Text = "Expiry Date";
            // 
            // lblunitprice
            // 
            this.lblunitprice.AutoSize = true;
            this.lblunitprice.Location = new System.Drawing.Point(103, 220);
            this.lblunitprice.Name = "lblunitprice";
            this.lblunitprice.Size = new System.Drawing.Size(69, 17);
            this.lblunitprice.TabIndex = 3;
            this.lblunitprice.Text = "Unit Price";
            // 
            // lblvendorid
            // 
            this.lblvendorid.AutoSize = true;
            this.lblvendorid.Location = new System.Drawing.Point(103, 268);
            this.lblvendorid.Name = "lblvendorid";
            this.lblvendorid.Size = new System.Drawing.Size(71, 17);
            this.lblvendorid.TabIndex = 4;
            this.lblvendorid.Text = "Vendor ID";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Location = new System.Drawing.Point(103, 314);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(63, 17);
            this.lbldiscount.TabIndex = 5;
            this.lbldiscount.Text = "Discount";
            // 
            // txtstockid
            // 
            this.txtstockid.Location = new System.Drawing.Point(268, 45);
            this.txtstockid.Name = "txtstockid";
            this.txtstockid.Size = new System.Drawing.Size(100, 22);
            this.txtstockid.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(268, 106);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 7;
            // 
            // txtexpdate
            // 
            this.txtexpdate.Location = new System.Drawing.Point(268, 164);
            this.txtexpdate.Name = "txtexpdate";
            this.txtexpdate.Size = new System.Drawing.Size(100, 22);
            this.txtexpdate.TabIndex = 8;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(268, 217);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(100, 22);
            this.txtunitprice.TabIndex = 9;
            // 
            // txtvendorid
            // 
            this.txtvendorid.Location = new System.Drawing.Point(268, 263);
            this.txtvendorid.Name = "txtvendorid";
            this.txtvendorid.Size = new System.Drawing.Size(100, 22);
            this.txtvendorid.TabIndex = 10;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(268, 309);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 22);
            this.txtdiscount.TabIndex = 11;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(553, 393);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 12;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 466);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtvendorid);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtexpdate);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtstockid);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblvendorid);
            this.Controls.Add(this.lblunitprice);
            this.Controls.Add(this.lblexpiredate);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblstockid);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstockid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblexpiredate;
        private System.Windows.Forms.Label lblunitprice;
        private System.Windows.Forms.Label lblvendorid;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.TextBox txtstockid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtexpdate;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtvendorid;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Button btnok;
    }
}