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

namespace POSManager
{
    public partial class CustomReport : Form
    {
        public CustomReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report f2 = new Report();
            f2.ShowDialog();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.SellItemsTableAdapter.Fill(this.DataSet1.SellItems, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

            double profit = 0;
            for (int i = 0; i < DataSet1.SellItems.Select("Date is not null").Length; i++)
            {
                profit += Convert.ToDouble(DataSet1.SellItems.Rows[i]["UnitPrice"]);
            }
            textBox1.Text = profit.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
         
           
        }
    }
}
