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
namespace POSSystem
{
    public partial class FormIssueLoyaltyCard : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public FormIssueLoyaltyCard()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Confirm cancellation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnLoyaltyCustomers_Click(object sender, EventArgs e)
        {
            FormLoyaltyCustomers formLoyaltyCustomers = new FormLoyaltyCustomers();
            formLoyaltyCustomers.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            bool contain = false;
            bool validity = validation();
            if (validity == true)
            {
                int loyaltyCardNumber = int.Parse(tbNIC.Text.Substring(0, 9));
                con = new SqlConnection(@"Data Source=DESKTOP-9V4S0N9\SQLEXPRESS;Initial Catalog=dbCashier;Integrated Security=True");
                cmd = new SqlCommand("Select * from IssueLoyaltyCard where LoyaltyCardNumber= @LoyaltyCardNumber", con);
                cmd.Parameters.AddWithValue("@LoyaltyCardNumber", loyaltyCardNumber);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)                                                             //check whether this number is already in the database
                    {
                        MessageBox.Show("This customer already has a Loyalty Card", "error");
                        contain = true;

                        break;
                    }
                }
                con.Close();
                con.Open();

                if (contain == false)
                { 
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO IssueLoyaltyCard(LoyaltyCardNumber,Name,Address,TPNumber,NICNumber) VALUES ('" + loyaltyCardNumber + "','" + tbName.Text + "','" + tbAddress.Text + "','" + tbTelephoneNumber.Text + "','" + tbNIC.Text + "')";
                    cmd.ExecuteNonQuery();


                }
                con.Close();
            }
        }

        private bool validation()
        {
            if ((string.IsNullOrWhiteSpace(tbAddress.Text)) || (string.IsNullOrWhiteSpace(tbName.Text)) || (string.IsNullOrWhiteSpace(tbNIC.Text)) || (string.IsNullOrWhiteSpace(tbTelephoneNumber.Text)))
            {
                MessageBox.Show("Enter all Data", "error");
                return false;
            }
            else if (tbNIC.Text.Length != 10)
            {
                MessageBox.Show("Invalid NIC number", "error"); 
                return false;
            }
            else if(tbTelephoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Invalid Telephone number", "error");
                return false;
            }

            else; return true;
        }



        private void enableButton()
        {
            if (tbAddress.Text.Trim() != "" && tbName.Text.Trim() != "" && tbNIC.Text.Trim() != "" && tbTelephoneNumber.Text.Trim() != "")
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }


        private void tbName_TextChanged_1(object sender, EventArgs e)
        {
           enableButton();            
        }

        private void tbNIC_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void tbTelephoneNumber_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void FormIssueLoyaltyCard_Load(object sender, EventArgs e)
        {

        }
    }
    }
