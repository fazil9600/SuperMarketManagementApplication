using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarketManagementApplication
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source = (Localdb)\\FazilLocalDB; Initial Catalog = SuperMarket; Integrated Security = True");

        private void fillcombo()
        {
            //This method will bind the combobox with database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from ProductCategory", Con);
            SqlDataReader sdra;
            sdra = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(sdra);
            cb_category_main.ValueMember = "CategoryName";
            cb_category_main.DataSource = dt;
            Con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void bt_category_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try {
                if (tb_mp_id.Text == "" || tb_mp_name.Text == "" || tb_mp_qty.Text == "" || tb_mp_price.Text == "")
                {
                    MessageBox.Show("Please fill all the details in the form");
                }
                else
                {
                    Con.Open();
                    string query = "insert into Products values(" + tb_mp_id.Text + ",'" + tb_mp_name.Text + "'," + tb_mp_qty.Text + "," + tb_mp_price.Text + ",'"+cb_category_main.SelectedValue.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added Succesfully");
                    Con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
