using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSManager
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.SellItems' table. You can move, or remove it, as needed.
           
            this.dateTimePicker1.Value = DateTime.Today.AddDays(-2);
            this.dateTimePicker2.Value = DateTime.Today.AddDays(-1);
            this.reportViewer1.RefreshReport();
            this.SellItemsTableAdapter.Fill(this.DataSet1.SellItems, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

            double profit = 0;
            for (int i = 0; i < DataSet1.SellItems.Select("Date is not null").Length; i++)
            {
                profit += Convert.ToDouble(DataSet1.SellItems.Rows[i]["UnitPrice"]);
            }
            textBox1.Text = profit.ToString();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
