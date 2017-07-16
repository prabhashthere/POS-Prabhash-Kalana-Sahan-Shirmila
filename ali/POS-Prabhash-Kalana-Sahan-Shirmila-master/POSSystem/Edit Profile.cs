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
    public partial class FormEditProfile : Form
    {
        public FormEditProfile()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.Close();
        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
