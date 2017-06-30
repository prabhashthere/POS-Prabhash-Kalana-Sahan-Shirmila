using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockKeeper
{
    public partial class stockkeeperMain : Form
    {
        public stockkeeperMain()
        {
            InitializeComponent();
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItemForm = new AddItem();
            addItemForm.Show();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveItem removeItemForm = new RemoveItem();
            removeItemForm.Show();
        }
    }
}
