namespace POSSystem
{
    partial class FormCreateNewBill
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbLoyaltyCard = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLoyaltyCard = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.unitPrice,
            this.amount,
            this.discount,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(305, 408);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(187, 33);
            this.btnDeleteItem.TabIndex = 1;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(558, 408);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(189, 33);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.Width = 220;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price (Rs)";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Width = 120;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Width = 90;
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount (%)";
            this.discount.Name = "discount";
            this.discount.Width = 90;
            // 
            // total
            // 
            this.total.HeaderText = "Total (Rs)";
            this.total.Name = "total";
            this.total.Width = 120;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(49, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(187, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbLoyaltyCard
            // 
            this.cbLoyaltyCard.AutoSize = true;
            this.cbLoyaltyCard.Location = new System.Drawing.Point(16, 329);
            this.cbLoyaltyCard.Name = "cbLoyaltyCard";
            this.cbLoyaltyCard.Size = new System.Drawing.Size(84, 17);
            this.cbLoyaltyCard.TabIndex = 4;
            this.cbLoyaltyCard.Text = "Loyalty Card";
            this.cbLoyaltyCard.UseVisualStyleBackColor = true;
            this.cbLoyaltyCard.CheckedChanged += new System.EventHandler(this.cbLoyaltyCard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loyalty Card No:";
            // 
            // tbLoyaltyCard
            // 
            this.tbLoyaltyCard.Location = new System.Drawing.Point(113, 350);
            this.tbLoyaltyCard.Name = "tbLoyaltyCard";
            this.tbLoyaltyCard.Size = new System.Drawing.Size(100, 20);
            this.tbLoyaltyCard.TabIndex = 6;
            // 
            // FormCreateNewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.tbLoyaltyCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLoyaltyCard);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCreateNewBill";
            this.Text = "Create New Bill";
            this.Load += new System.EventHandler(this.Create_New_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbLoyaltyCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLoyaltyCard;
    }
}