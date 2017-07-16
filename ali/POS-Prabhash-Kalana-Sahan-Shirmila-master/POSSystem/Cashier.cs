using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class FormCashier : Form
    {
        public FormCashier()
        {
            InitializeComponent();
        }

        private void btnCreateNewBill_Click(object sender, EventArgs e)
        {
            FormCreateNewBill formCreateNewBill = new FormCreateNewBill();
            formCreateNewBill.Show();
        }

        private void btnIssueLoyaltyCard_Click(object sender, EventArgs e)
        {
            FormIssueLoyaltyCard formIssueLoyaltyCard = new FormIssueLoyaltyCard();
            formIssueLoyaltyCard.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.Show();
        }

        private void panelCashier_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
