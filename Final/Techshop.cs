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
    public partial class Techshop : Form
    {
        public Techshop()
        {
            InitializeComponent();
            //if we entered with some id it will show it on window
            label_id.Text = Login.EmbloyeeID;
        }

        //it is more useful to make it method 
        private void executeQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\YS\Documents\db\TECHSHOP.MDF;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
            }//in case if you'll write enormously big number for quantity or price:
            catch(OverflowException)
            {
                MessageBox.Show("you entered too big number");
            }
            //catch if this ID for product is already taken
            catch
            {
                MessageBox.Show("This id for porduct is already taken");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        //add new product
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals("") || txt_name.Text.Equals("") || txt_quantity.Text.Equals("") || txt_price.Text.Equals(""))
            {
                MessageBox.Show("Please fill all fields to add new product");
            }
            else
            {
                string queryInput = "insert into product (id,pname,pquantity,pprice) values('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_quantity.Text + "','" + txt_price.Text + "')";
                executeQuery(queryInput);
                MessageBox.Show("Product added!");
            }
        }
        //update product with id
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals("") || txt_name.Text.Equals("") || txt_quantity.Text.Equals("") || txt_price.Text.Equals(""))
            {
                MessageBox.Show("Please fill all fields to update product");
            }
            else
            {
                string queryUpdate = "update product set pname = '" + txt_name.Text + "', pquantity = " + txt_quantity.Text + ",pprice = " + txt_price.Text + " where id = " + txt_id.Text + ";";
                executeQuery(queryUpdate);
                MessageBox.Show("Product updated!");
            }
        }
        //delete product with id
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    MessageBox.Show("Please write id of product to delete it!");
                }
                else
                {
                    string queryDelete = "delete from product where id = '" + txt_id.Text + "'";
                    executeQuery(queryDelete);
                    MessageBox.Show("Product deleted!");
                }
            }
            catch
            {
                MessageBox.Show("Product with this id does not exists in database");
            }

        }
        //make all fields blank
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_quantity.Text = "";
            txt_price.Text = "";
            txt_id.Text = "";
        }
        //logout and go to login form
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
        //show data(products)
        private void btn_preview_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\YS\Documents\db\TECHSHOP.MDF;Integrated Security=True;Connect Timeout=30");
            using (con)
            {
                string querySelect = "";
                con.Open();
                //you can search for product with id or leave it blank to get all products
                if (txt_id.Text.Equals(""))
                {
                    querySelect = "select * from product";
                }
                else { querySelect = "select * from product where id = " + txt_id.Text ; }

                SqlDataAdapter sda = new SqlDataAdapter(querySelect, con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }
    }
}
