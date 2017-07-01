using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace POSSystem
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            txtUserName.Font = new Font(FontFamily.GenericSansSerif,
            10.0F);
            txtUserName.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
            txtPassword.Font = new Font(FontFamily.GenericSansSerif,
            10.0F);
            txtPassword.ForeColor = System.Drawing.Color.Black;
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passwrd = txtPassword.Text;
            SqlConnection con = new SqlConnection("Data Source=SHIRMI-PC\\SQLEXPRESS;Initial Catalog=EmployeeDetails;Integrated Security=True");
            try
            {
                SqlCommand comm = new SqlCommand("SELECT UserName,Password,Designation FROM EmployeeDetails;", con);
                con.Open();
                SqlDataReader reader = comm.ExecuteReader();
                bool isSuitable=false;
                while (reader.Read())
                {

                    if (userName == reader.GetValue(0).ToString() && passwrd == reader.GetValue(1).ToString())
                    {
                       isSuitable  = true;
                        break;
                    }
                }
                if (isSuitable == true)
                {
                    MessageBox.Show("correct UserName or password ");
                    if (reader.GetValue(2).ToString() == "Cashier")
                    {
                        CashierForm cf = new CashierForm();
                        cf.Show();
                    }
                    else if (reader.GetValue(2).ToString() == "StockKeeper")
                    {
                        //StockKeeper Main window
                        MessageBox.Show("StockKeeper Main window ");
                    }
                    else {
                        //Manager Main Window
                        MessageBox.Show("Manager Main Window");
                    }
                }
                else {
                    MessageBox.Show("Incorrect UserName or password ");
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }


        }
    }
}
