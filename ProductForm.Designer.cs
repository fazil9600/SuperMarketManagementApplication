
namespace SuperMarketManagementApplication
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_refresh = new System.Windows.Forms.Button();
            this.cb_role_category = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_category_main = new System.Windows.Forms.ComboBox();
            this.tb_mp_price = new System.Windows.Forms.TextBox();
            this.tb_mp_name = new System.Windows.Forms.TextBox();
            this.tb_mp_qty = new System.Windows.Forms.TextBox();
            this.tb_mp_id = new System.Windows.Forms.TextBox();
            this.bt_sellers = new System.Windows.Forms.Button();
            this.bt_category = new System.Windows.Forms.Button();
            this.bt_selling = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_refresh);
            this.panel1.Controls.Add(this.cb_role_category);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_edit);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_category_main);
            this.panel1.Controls.Add(this.tb_mp_price);
            this.panel1.Controls.Add(this.tb_mp_name);
            this.panel1.Controls.Add(this.tb_mp_qty);
            this.panel1.Controls.Add(this.tb_mp_id);
            this.panel1.Location = new System.Drawing.Point(100, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 376);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "MANAGE PRODUCTS";
            // 
            // tb_refresh
            // 
            this.tb_refresh.Location = new System.Drawing.Point(476, 30);
            this.tb_refresh.Name = "tb_refresh";
            this.tb_refresh.Size = new System.Drawing.Size(69, 23);
            this.tb_refresh.TabIndex = 11;
            this.tb_refresh.Text = " REFRESH";
            this.tb_refresh.UseVisualStyleBackColor = true;
            // 
            // cb_role_category
            // 
            this.cb_role_category.FormattingEnabled = true;
            this.cb_role_category.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.cb_role_category.Location = new System.Drawing.Point(349, 30);
            this.cb_role_category.Name = "cb_role_category";
            this.cb_role_category.Size = new System.Drawing.Size(121, 23);
            this.cb_role_category.TabIndex = 10;
            this.cb_role_category.Text = "Select Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(348, 306);
            this.dataGridView1.TabIndex = 9;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(149, 277);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(82, 21);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.Text = "DELETE";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(84, 277);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(59, 21);
            this.bt_edit.TabIndex = 8;
            this.bt_edit.Text = "EDIT";
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(15, 277);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(63, 21);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = " ";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "CATEGORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // cb_category_main
            // 
            this.cb_category_main.FormattingEnabled = true;
            this.cb_category_main.Location = new System.Drawing.Point(72, 239);
            this.cb_category_main.Name = "cb_category_main";
            this.cb_category_main.Size = new System.Drawing.Size(121, 23);
            this.cb_category_main.TabIndex = 2;
            this.cb_category_main.Text = "Select Category";
            // 
            // tb_mp_price
            // 
            this.tb_mp_price.Location = new System.Drawing.Point(72, 185);
            this.tb_mp_price.Name = "tb_mp_price";
            this.tb_mp_price.Size = new System.Drawing.Size(121, 23);
            this.tb_mp_price.TabIndex = 1;
            // 
            // tb_mp_name
            // 
            this.tb_mp_name.Location = new System.Drawing.Point(72, 71);
            this.tb_mp_name.Name = "tb_mp_name";
            this.tb_mp_name.Size = new System.Drawing.Size(121, 23);
            this.tb_mp_name.TabIndex = 1;
            // 
            // tb_mp_qty
            // 
            this.tb_mp_qty.Location = new System.Drawing.Point(72, 120);
            this.tb_mp_qty.Name = "tb_mp_qty";
            this.tb_mp_qty.Size = new System.Drawing.Size(121, 23);
            this.tb_mp_qty.TabIndex = 0;
            // 
            // tb_mp_id
            // 
            this.tb_mp_id.Location = new System.Drawing.Point(72, 15);
            this.tb_mp_id.Name = "tb_mp_id";
            this.tb_mp_id.Size = new System.Drawing.Size(121, 23);
            this.tb_mp_id.TabIndex = 0;
            // 
            // bt_sellers
            // 
            this.bt_sellers.Location = new System.Drawing.Point(12, 36);
            this.bt_sellers.Name = "bt_sellers";
            this.bt_sellers.Size = new System.Drawing.Size(82, 21);
            this.bt_sellers.TabIndex = 1;
            this.bt_sellers.Text = "SELLERS";
            this.bt_sellers.UseVisualStyleBackColor = true;
            // 
            // bt_category
            // 
            this.bt_category.AutoSize = true;
            this.bt_category.Location = new System.Drawing.Point(12, 84);
            this.bt_category.Name = "bt_category";
            this.bt_category.Size = new System.Drawing.Size(75, 25);
            this.bt_category.TabIndex = 1;
            this.bt_category.Text = "CATEGORY";
            this.bt_category.UseVisualStyleBackColor = true;
            this.bt_category.Click += new System.EventHandler(this.bt_category_Click);
            // 
            // bt_selling
            // 
            this.bt_selling.Location = new System.Drawing.Point(12, 139);
            this.bt_selling.Name = "bt_selling";
            this.bt_selling.Size = new System.Drawing.Size(75, 21);
            this.bt_selling.TabIndex = 1;
            this.bt_selling.Text = "SELLING";
            this.bt_selling.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 317);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Select Category";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(72, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 23);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(72, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 23);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(72, 120);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 23);
            this.textBox7.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(72, 15);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 23);
            this.textBox8.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.bt_selling);
            this.Controls.Add(this.bt_category);
            this.Controls.Add(this.bt_sellers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_sellers;
        private System.Windows.Forms.Button bt_category;
        private System.Windows.Forms.Button bt_selling;
        private System.Windows.Forms.Button tb_refresh;
        private System.Windows.Forms.ComboBox cb_role_category;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_category_main;
        private System.Windows.Forms.TextBox tb_mp_price;
        private System.Windows.Forms.TextBox tb_mp_name;
        private System.Windows.Forms.TextBox tb_mp_qty;
        private System.Windows.Forms.TextBox tb_mp_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
    }
}