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

namespace Final
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            //hide password
            txt_password.PasswordChar = '*';
            txt_confirm.PasswordChar = '*';
        }
        //link to login
        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            //length of password
            if (txt_password.Text.Length < 6)
            {
                MessageBox.Show("Too short password, make it at least 6");
            }
            else
            {
                //need to connect to local database
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\YS\source\repos\Final\Techshop.mdf;Integrated Security=True;Connect Timeout=30");
                try
                {
                    //inserts row into table 
                    if (txt_password.Text.Trim().Equals(txt_confirm.Text.Trim()))
                    {
                        string queryInsert = "insert into Employee (id,password) values('" + txt_id.Text.Trim() + "','" + txt_password.Text.Trim() + "') ";
                        SqlDataAdapter sda = new SqlDataAdapter(queryInsert, connection);
                        DataTable dataTable = new DataTable();
                        sda.Fill(dataTable);
                        MessageBox.Show("User added!");
                    }
                    else MessageBox.Show("Passwords should be equal!");
                }
                catch
                {
                    MessageBox.Show("This id is already taken");
                }
            }
        }
    }
}
