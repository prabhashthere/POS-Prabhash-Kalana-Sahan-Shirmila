using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POSSystem
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            lblTotal.Text = MyStaticValues.roughTotalBill.ToString();
            lblLoyaltyDiscount.Text = (MyStaticValues.roughTotalBill - MyStaticValues.finalBill).ToString();
            lblFinalBill.Text = MyStaticValues.finalBill.ToString();
            lblPayment.Text = MyStaticValues.payment.ToString();
            lblBalance.Text = MyStaticValues.balance.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9V4S0N9\SQLEXPRESS;Initial Catalog=dbCashier;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ProductName,UnitPrice,Amount,Discount,Total FROM SellItems WHERE Time = '" + MyStaticValues.submitTime + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

        }
    }
}
