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
    public partial class FormCreateNewBill : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public FormCreateNewBill()
        {
            InitializeComponent();
            tbLoyaltyCard.Enabled = false;
        }

        private void Create_New_Bill_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormCreateNewBill formCreateNewBill = new FormCreateNewBill();
            formCreateNewBill.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Prabhash\Desktop\ali\POS - Prabhash - Kalana - Sahan - Shirmila\POSSystem\Shop Database.mdf;Integrated Security=True");
            sda = new SqlDataAdapter("");

            if (cbLoyaltyCard.Checked)
            {

            }
            else;

        }

        private void cbLoyaltyCard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoyaltyCard.Checked)
            {
                tbLoyaltyCard.Enabled = true;
            }
            else
                tbLoyaltyCard.Enabled = false;
        }
    }
}
