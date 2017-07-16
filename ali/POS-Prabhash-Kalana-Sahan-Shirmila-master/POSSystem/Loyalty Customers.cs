using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class FormLoyaltyCustomers : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlCommandBuilder scb;
        SqlDataAdapter sda;
        DataTable dt;
        public FormLoyaltyCustomers()
        {
            InitializeComponent();
        }
        
        private void Loyalty_Customers_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-9V4S0N9\SQLEXPRESS;Initial Catalog=dbCashier;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT LoyaltyCardNumber,Name,Address,TPNumber,NICNumber FROM IssueLoyaltyCard",con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
