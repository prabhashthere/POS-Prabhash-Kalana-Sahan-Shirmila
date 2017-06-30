namespace StockKeeper
{
    partial class stockkeeperMain
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstocknotification = new System.Windows.Forms.Label();
            this.lblshopnotification = new System.Windows.Forms.Label();
            this.lblexpirenotification = new System.Windows.Forms.Label();
            this.btnstocknotification = new System.Windows.Forms.Button();
            this.btnshopnotification = new System.Windows.Forms.Button();
            this.btnexpirenotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(131, 115);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(232, 53);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(131, 185);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(232, 52);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOCK KEEPER";
            // 
            // lblstocknotification
            // 
            this.lblstocknotification.AutoSize = true;
            this.lblstocknotification.Location = new System.Drawing.Point(82, 299);
            this.lblstocknotification.Name = "lblstocknotification";
            this.lblstocknotification.Size = new System.Drawing.Size(117, 17);
            this.lblstocknotification.TabIndex = 3;
            this.lblstocknotification.Text = "Stock Notification";
            // 
            // lblshopnotification
            // 
            this.lblshopnotification.AutoSize = true;
            this.lblshopnotification.Location = new System.Drawing.Point(82, 339);
            this.lblshopnotification.Name = "lblshopnotification";
            this.lblshopnotification.Size = new System.Drawing.Size(115, 17);
            this.lblshopnotification.TabIndex = 4;
            this.lblshopnotification.Text = "Shop Notification";
            // 
            // lblexpirenotification
            // 
            this.lblexpirenotification.AutoSize = true;
            this.lblexpirenotification.Location = new System.Drawing.Point(82, 378);
            this.lblexpirenotification.Name = "lblexpirenotification";
            this.lblexpirenotification.Size = new System.Drawing.Size(121, 17);
            this.lblexpirenotification.TabIndex = 5;
            this.lblexpirenotification.Text = "Expire Notification";
            // 
            // btnstocknotification
            // 
            this.btnstocknotification.Location = new System.Drawing.Point(306, 299);
            this.btnstocknotification.Name = "btnstocknotification";
            this.btnstocknotification.Size = new System.Drawing.Size(75, 23);
            this.btnstocknotification.TabIndex = 6;
            this.btnstocknotification.UseVisualStyleBackColor = true;
            // 
            // btnshopnotification
            // 
            this.btnshopnotification.Location = new System.Drawing.Point(306, 339);
            this.btnshopnotification.Name = "btnshopnotification";
            this.btnshopnotification.Size = new System.Drawing.Size(75, 23);
            this.btnshopnotification.TabIndex = 7;
            this.btnshopnotification.UseVisualStyleBackColor = true;
            // 
            // btnexpirenotification
            // 
            this.btnexpirenotification.Location = new System.Drawing.Point(306, 378);
            this.btnexpirenotification.Name = "btnexpirenotification";
            this.btnexpirenotification.Size = new System.Drawing.Size(75, 23);
            this.btnexpirenotification.TabIndex = 8;
            this.btnexpirenotification.UseVisualStyleBackColor = true;
            // 
            // stockkeeperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 478);
            this.Controls.Add(this.btnexpirenotification);
            this.Controls.Add(this.btnshopnotification);
            this.Controls.Add(this.btnstocknotification);
            this.Controls.Add(this.lblexpirenotification);
            this.Controls.Add(this.lblshopnotification);
            this.Controls.Add(this.lblstocknotification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Name = "stockkeeperMain";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstocknotification;
        private System.Windows.Forms.Label lblshopnotification;
        private System.Windows.Forms.Label lblexpirenotification;
        private System.Windows.Forms.Button btnstocknotification;
        private System.Windows.Forms.Button btnshopnotification;
        private System.Windows.Forms.Button btnexpirenotification;
    }
}

