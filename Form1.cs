using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_clear_Click(object sender, EventArgs e)
        {
            tb_password.Text = "";
            tb_username.Text = "";
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text == "" || tb_password.Text =="")
            {
                MessageBox.Show("Enter user name and password");
            }
            else
            {
                if(cb_role.SelectedItem.ToString()=="Admin")
                {
                    if(tb_username.Text == "Admin" && tb_password.Text== "Admin")
                    {
                        ProductForm prodf = new ProductForm();
                        prodf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please enter admin login details");
                    }
                }
                else if(cb_role.SelectedItem.ToString()=="Seller")
                {
                    MessageBox.Show("You are a seller");



                }
                else
                {
                    MessageBox.Show("Please select a role");
                }
            }
        }
    }
}
