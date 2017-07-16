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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9V4S0N9\\SQLEXPRESS;Initial Catalog=\"Cashier Database\";Integrated Security=True");
        SqlDataAdapter adapter; //to update table
        DataTable dt; //copy details in/to grid
        SqlCommandBuilder sqlCB; //connect db with adapter
        
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
            this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            //    MessageBox.Show(date1.Date.ToString("MM/dd/yyyy"));
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-9V4S0N9\SQLEXPRESS;Initial Catalog=dbCashier;Integrated Security=True");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                con1.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SellItems(StockID,UnitPrice,Amount) VALUES ('"+dataGridView1.Rows[i].Cells[0].Value+"','"+dataGridView1.Rows[i].Cells[2].Value+"','"+dataGridView1.Rows[i].Cells[3].Value+"')");
                SqlCommand cmd = con1.CreateCommand();
                cmd.CommandText = "INSERT  SellItems (Date,Time,StockID,UnitPrice,Amount,ProductName,Discount,Total) VALUES ('" + date1 + "','" + date1 + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "')";

                cmd.ExecuteNonQuery();
                con1.Close();

            }

            //con.Close();
            if (cbLoyaltyCard.Checked)
            {

            }
   
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    
                    int stockID = int.Parse(row.Cells[0].Value.ToString());
                    string productName = row.Cells[1].Value.ToString();
                    float unitPrice = float.Parse(row.Cells[2].Value.ToString());
                    int amount = int.Parse(row.Cells[3].Value.ToString());
                    float discount = float.Parse(row.Cells[4].Value.ToString());
                    float total = int.Parse(row.Cells[5].Value.ToString());
                    MyStaticValues.roughTotalBill += total;
                    adapter = new SqlDataAdapter("UPDATE \"Shop Table\" SET AvailableAmount = AvailableAmount - '" + amount + "' WHERE StockID = '" + stockID + "'", con);
                    sqlCB = new SqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                }
               
            }

            if (cbLoyaltyCard.Checked)
            {
                SqlCommand sqlC = new SqlCommand("SELECT * FROM LoyaltyCardTable WHERE LoyaltyCardID = '" + tbLoyaltyCard.Text + "'", con);
                adapter = new SqlDataAdapter(sqlC);
                dt = new DataTable();
                adapter.Fill(dt);
                int checkLoyalty1 = dt.Rows.Count;
                //MessageBox.Show(checkLoyalty1.ToString());
                MyStaticValues.checkLoyalty = checkLoyalty1;
            }
            Payment payment = new Payment();
            payment.Show();

            MyStaticValues.submitTime = DateTime.Now.ToString();
            MessageBox.Show(MyStaticValues.submitTime);
           

        }

        private void cbLoyaltyCard_CheckedChanged(object sender, EventArgs e)
        {
            tbLoyaltyCard.Text = null;
            if (cbLoyaltyCard.Checked)
            {
                tbLoyaltyCard.Enabled = true;
            }
            else
                tbLoyaltyCard.Enabled = false;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                if (item != dataGridView1.Rows[dataGridView1.Rows.Count - 1])
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void tbLoyaltyCard_TextChanged(object sender, EventArgs e)
        {

        }

        private int methodCheckStockID(DataGridViewCellEventArgs e1)
        {
            SqlCommand sqlC = new SqlCommand("SELECT * FROM \"Shop Table\" WHERE StockID = '" + dataGridView1[0, e1.RowIndex].Value + "'", con);
            adapter = new SqlDataAdapter(sqlC);
            dt = new DataTable();
            adapter.Fill(dt);
            int checkStockID1 = dt.Rows.Count;
            //MessageBox.Show(checkStockID1.ToString());
            MyStaticValues.checkStockID = checkStockID1;
            return MyStaticValues.checkStockID;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (methodCheckStockID(e) == 1)
                {
                   
                    //MessageBox.Show(dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value.ToString());
                    adapter = new SqlDataAdapter("SELECT ProductName,UnitPrice,Discount FROM \"Shop Table\" WHERE StockID = '" + dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value + "'", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1[1, e.RowIndex].Value = Convert.ToString(dt.Rows[0][0]);
                    dataGridView1[2, e.RowIndex].Value = Convert.ToString(dt.Rows[0][1]);
                    dataGridView1[4, e.RowIndex].Value = Convert.ToString(dt.Rows[0][2]);
                    //MessageBox.Show(dt.Rows.Count.ToString());
                }
                else
                {
                    MessageBox.Show("Invalid StockId");
                }

            }
            if (e.ColumnIndex == 4)
            {
                //MessageBox.Show(dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value.ToString());
                //adapter = new SqlDataAdapter("SELECT ProductName,UnitPrice,Discount FROM \"Shop Table\" WHERE StockID = '" + dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value + "'", con);
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);
                dataGridView1[5, e.RowIndex].Value = (Convert.ToInt32(dataGridView1[2, e.RowIndex].Value) - Convert.ToInt32(dataGridView1[4, e.RowIndex].Value)) * Convert.ToInt32(dataGridView1[3, e.RowIndex].Value);
                //MessageBox.Show(dt.Rows.Count.ToString());
            }
        }
    }

    public static class MyStaticValues
    {
        public static int checkLoyalty;
        public static float loyaltyDiscount = 0.1F;
        public static float roughTotalBill;
        public static float balance;
        public static float finalBill;
        public static float payment;
        public static string submitTime;
        public static int checkStockID;
    }

}
