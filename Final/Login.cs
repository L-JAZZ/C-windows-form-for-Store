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
    public partial class Login : Form
    {
        //need to pass current employee id
        public static string EmbloyeeID = "";
        public Login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {   //need to connect to local database

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\YS\source\repos\Final\Techshop.mdf;Integrated Security=True;Connect Timeout=30");            //take rows from table 
            string query = "Select * from Employee where id = '" + txt_id.Text.Trim() + "' and password = '" + txt_password.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query,connection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            //there should be only one user with this email
            if (dataTable.Rows.Count == 1)
            {
                EmbloyeeID = txt_id.Text;
                Techshop techshop = new Techshop();
                this.Hide();
                techshop.Show();
            }
            else MessageBox.Show("Incorrect id or password");
        }
        //link to register
        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
