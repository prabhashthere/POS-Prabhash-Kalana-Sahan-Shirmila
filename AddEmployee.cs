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
    public partial class AddEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=USER_PC\TEW_SQLEXPRESS;Initial Catalog=POSManager;Integrated Security=True");
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeTable);

        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeTable);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeTable.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeTable.Employee);
            button6.PerformClick();
            display_data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into EmployeeTable values('" + employeeIdTextBox.Text + "','" + employee_NameTextBox.Text + "','" + addressTextBox.Text + "','" + telephone_NoTextBox.Text + "','" + emailTextBox.Text + "') ";
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
            cmd.CommandText = "select*from EmployeeTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager f1 = new Manager();
            f1.ShowDialog();
        }

        private void Form6_Shown(Object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

     

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from EmployeeTable where EmployeeID='" + employeeIdTextBox.Text + "'";
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

        private void button6_Click(object sender, EventArgs e)
        {
            employeeIdTextBox.Clear();
            employee_NameTextBox.Clear();
            telephone_NoTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();
        }
    }

}
