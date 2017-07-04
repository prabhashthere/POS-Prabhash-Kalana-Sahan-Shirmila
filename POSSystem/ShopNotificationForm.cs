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
    public partial class ShopNotificationForm : Form
    {
        public ShopNotificationForm()
        {
            InitializeComponent();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "IsRelease";
            buttonColumn.Text = "YES";
            buttonColumn.UseColumnTextForButtonValue = true;
            int columnIndex = 4;
            if (dataGridView1.Columns["IsRelease"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, buttonColumn);
            }
            //dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void ShopNotificationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["IsRelease"].Index)
            {
                string id=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                MessageBox.Show("aaaaaaaaaaa");
            }

        }
    }
}
