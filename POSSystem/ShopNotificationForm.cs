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
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "IsRelease";
            uninstallButtonColumn.Text = "IsRelease";
            int columnIndex = 3;
            if (dataGridView1.Columns["IsRelease"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, uninstallButtonColumn);
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
                //Do something with your button.
                MessageBox.Show("aaaaaaaaaaa");
            }

        }
    }
}
