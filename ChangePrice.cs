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
    public partial class ChangePrice : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\New folder\\Cashier Database.mdf\";Integrated Security=True");

        

        public ChangePrice()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            display_data();

        }
        public void display_data()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from [Shop Table]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.CellClick += dataGridView1_CellClick;

            DataGridViewButtonColumn offercoloumn = new DataGridViewButtonColumn();
            offercoloumn.Name = "Channge Product Price coloumn";
            offercoloumn.Text = "Change";
            offercoloumn.UseColumnTextForButtonValue = true;

            int columnIndex = 9;
            if (dataGridView1.Columns["Channge Product Price coloumn"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, offercoloumn);
            }


            con.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Channge Product Price coloumn"].Index)
            {

                this.Hide();
                EnterNewPrice.newstockID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                EnterNewPrice f7 = new EnterNewPrice();
                f7.ShowDialog();


              


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager man = new Manager();
            man.Show();
        }
    }
}
