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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source = (Localdb)\\FazilLocalDB; Initial Catalog = SuperMarket; Integrated Security = True");
        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductCategory values('" + tb_cat_id.Text + "','" + tb_cat_name.Text + "','" + tb_cat_description.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Succesfully");
                Con.Close();
                PopulateCategories();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
private void PopulateCategories()
        {
            try
            {

                Con.Open();
                string query = "select * from ProductCategory";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_manage_categories.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

  
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            PopulateCategories();
        }

        private void dgv_manage_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                tb_cat_id.Text = dgv_manage_categories.SelectedRows[0].Cells[1].Value.ToString();
                tb_cat_name.Text = dgv_manage_categories.SelectedRows[0].Cells[2].Value.ToString();
                tb_cat_description.Text = dgv_manage_categories.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_cat_id.Text == "")
                {
                    MessageBox.Show("Please select the category ID to delete");
                }
                else {
                    Con.Open();
                    string query = "delete from ProductCategory where CategoryID = " + tb_cat_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Succesfully");
                    Con.Close();
                    PopulateCategories(); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_cat_id.Text == "")
                {
                    MessageBox.Show("Please select the category ID to edit");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductCategory set CategoryName = '" + tb_cat_name.Text + "', CategoryDescription = '" + tb_cat_description.Text + "'  WHERE CategoryID = " + tb_cat_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Updated Succesfully");
                    Con.Close();
                    PopulateCategories();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_products_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }
    }
}
