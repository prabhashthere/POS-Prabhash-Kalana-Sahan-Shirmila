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
    public partial class FormIssueLoyaltyCard : Form
    {
        public FormIssueLoyaltyCard()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormIssueLoyaltyCard formIssueLoyaltyCard = new FormIssueLoyaltyCard();
            formIssueLoyaltyCard.Close();
        }
    }
}
