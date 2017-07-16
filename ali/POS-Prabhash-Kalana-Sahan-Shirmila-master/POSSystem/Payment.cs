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
    public partial class Payment : Form
    {
        FormCreateNewBill formCreateNewBill = new FormCreateNewBill();
        public Payment()
        {
            InitializeComponent();
        }

        private void Final_Amount_Load(object sender, EventArgs e)
        {
            
            if (MyStaticValues.checkLoyalty == 1)
            {
                MyStaticValues.finalBill = (MyStaticValues.roughTotalBill * (1 - MyStaticValues.loyaltyDiscount));
                lblFinalBill.Text = MyStaticValues.finalBill.ToString();
            }
            else
            {
                MyStaticValues.finalBill = MyStaticValues.roughTotalBill;
                lblFinalBill.Text = MyStaticValues.finalBill.ToString();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
   
            MyStaticValues.checkLoyalty = 0;
            MyStaticValues.payment = float.Parse(tbPayment.Text);
            MyStaticValues.balance = MyStaticValues.payment - MyStaticValues.finalBill;
            Bill bill = new Bill();
            bill.Show();



        }
    }
}
