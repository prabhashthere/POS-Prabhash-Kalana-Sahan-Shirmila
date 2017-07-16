namespace POSSystem
{
    partial class FormCashier
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
            this.btnCreateNewBill = new System.Windows.Forms.Button();
            this.btnIssueLoyaltyCard = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.panelCashier = new System.Windows.Forms.Panel();
            this.panelCashier.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNewBill
            // 
            this.btnCreateNewBill.Location = new System.Drawing.Point(42, 45);
            this.btnCreateNewBill.Name = "btnCreateNewBill";
            this.btnCreateNewBill.Size = new System.Drawing.Size(214, 39);
            this.btnCreateNewBill.TabIndex = 0;
            this.btnCreateNewBill.Text = "Create New Bill";
            this.btnCreateNewBill.UseVisualStyleBackColor = true;
            this.btnCreateNewBill.Click += new System.EventHandler(this.btnCreateNewBill_Click);
            // 
            // btnIssueLoyaltyCard
            // 
            this.btnIssueLoyaltyCard.Location = new System.Drawing.Point(42, 108);
            this.btnIssueLoyaltyCard.Name = "btnIssueLoyaltyCard";
            this.btnIssueLoyaltyCard.Size = new System.Drawing.Size(214, 38);
            this.btnIssueLoyaltyCard.TabIndex = 1;
            this.btnIssueLoyaltyCard.Text = "Issue Loyalty Card";
            this.btnIssueLoyaltyCard.UseVisualStyleBackColor = true;
            this.btnIssueLoyaltyCard.Click += new System.EventHandler(this.btnIssueLoyaltyCard_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(42, 170);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(214, 36);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // panelCashier
            // 
            this.panelCashier.Controls.Add(this.btnEditProfile);
            this.panelCashier.Controls.Add(this.btnIssueLoyaltyCard);
            this.panelCashier.Controls.Add(this.btnCreateNewBill);
            this.panelCashier.Location = new System.Drawing.Point(12, 12);
            this.panelCashier.Name = "panelCashier";
            this.panelCashier.Size = new System.Drawing.Size(297, 248);
            this.panelCashier.TabIndex = 3;
            this.panelCashier.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCashier_Paint);
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 267);
            this.Controls.Add(this.panelCashier);
            this.Name = "FormCashier";
            this.Text = "Cashier";
            this.panelCashier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewBill;
        private System.Windows.Forms.Button btnIssueLoyaltyCard;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Panel panelCashier;
    }
}