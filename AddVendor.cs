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
    public partial class AddVendor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=USER_PC\TEW_SQLEXPRESS;Initial Catalog=POSManager;Integrated Security=True");
        public AddVendor()
        {
            InitializeComponent();
        }

        private void vendorTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vendorTableDataset);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorTableDataset.VendorTable' table. You can move, or remove it, as needed.
            try
            {
                this.vendorTableTableAdapter.Fill(this.vendorTableDataset.VendorTable);
                button3.PerformClick();
                display_data();
            }
            catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into VendorTable values('" + vendorIDTextBox.Text + "','" + vendor_NameTextBox.Text + "','" + companyTextBox.Text + "','" + telephone_NoTextBox.Text + "','" + emailTextBox.Text + "') ";
                cmd.ExecuteNonQuery();

                con.Close();
                display_data();
                MessageBox.Show("Record saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void display_data()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from VendorTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void vendorIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void vendorTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = vendorTableDataset;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Manager f1 = new Manager();
            f1.ShowDialog();
        }
        private void Form5_Shown(Object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            vendorIDTextBox.Clear();
            vendor_NameTextBox.Clear();
            companyTextBox.Clear();
            telephone_NoTextBox.Clear();
            emailTextBox.Clear();


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from VendorTable where VendorID='" + vendorIDTextBox.Text + "'";
                cmd.ExecuteNonQuery();

                con.Close();
                display_data();
                MessageBox.Show("Record deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void telephone_NoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
