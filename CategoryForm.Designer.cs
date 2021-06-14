
namespace SuperMarketManagementApplication
{
    partial class CategoryForm
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
            this.dgv_manage_categories = new System.Windows.Forms.DataGridView();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cat_name = new System.Windows.Forms.TextBox();
            this.tb_cat_description = new System.Windows.Forms.TextBox();
            this.tb_cat_id = new System.Windows.Forms.TextBox();
            this.bt_selling = new System.Windows.Forms.Button();
            this.bt_products = new System.Windows.Forms.Button();
            this.bt_sellers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_refresh);
            this.panel1.Controls.Add(this.dgv_manage_categories);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_edit);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_cat_name);
            this.panel1.Controls.Add(this.tb_cat_description);
            this.panel1.Controls.Add(this.tb_cat_id);
            this.panel1.Location = new System.Drawing.Point(92, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 376);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "MANAGE CATEGORIES";
            // 
            // tb_refresh
            // 
            this.tb_refresh.Location = new System.Drawing.Point(516, 7);
            this.tb_refresh.Name = "tb_refresh";
            this.tb_refresh.Size = new System.Drawing.Size(69, 23);
            this.tb_refresh.TabIndex = 11;
            this.tb_refresh.Text = " REFRESH";
            this.tb_refresh.UseVisualStyleBackColor = true;
            // 
            // dgv_manage_categories
            // 
            this.dgv_manage_categories.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_manage_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manage_categories.Location = new System.Drawing.Point(237, 30);
            this.dgv_manage_categories.Name = "dgv_manage_categories";
            this.dgv_manage_categories.RowTemplate.Height = 25;
            this.dgv_manage_categories.Size = new System.Drawing.Size(348, 306);
            this.dgv_manage_categories.TabIndex = 9;
            this.dgv_manage_categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manage_categories_CellContentClick);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(149, 277);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(82, 21);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.Text = "DELETE";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(84, 277);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(59, 21);
            this.bt_edit.TabIndex = 8;
            this.bt_edit.Text = "EDIT";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(15, 277);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(63, 21);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = "ADD";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIPTION";
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
            // tb_cat_name
            // 
            this.tb_cat_name.Location = new System.Drawing.Point(100, 66);
            this.tb_cat_name.Name = "tb_cat_name";
            this.tb_cat_name.Size = new System.Drawing.Size(121, 23);
            this.tb_cat_name.TabIndex = 1;
            // 
            // tb_cat_description
            // 
            this.tb_cat_description.Location = new System.Drawing.Point(100, 120);
            this.tb_cat_description.Name = "tb_cat_description";
            this.tb_cat_description.Size = new System.Drawing.Size(121, 23);
            this.tb_cat_description.TabIndex = 0;
            // 
            // tb_cat_id
            // 
            this.tb_cat_id.Location = new System.Drawing.Point(100, 14);
            this.tb_cat_id.Name = "tb_cat_id";
            this.tb_cat_id.Size = new System.Drawing.Size(121, 23);
            this.tb_cat_id.TabIndex = 0;
            // 
            // bt_selling
            // 
            this.bt_selling.Location = new System.Drawing.Point(4, 147);
            this.bt_selling.Name = "bt_selling";
            this.bt_selling.Size = new System.Drawing.Size(75, 21);
            this.bt_selling.TabIndex = 3;
            this.bt_selling.Text = "SELLING";
            this.bt_selling.UseVisualStyleBackColor = true;
            // 
            // bt_products
            // 
            this.bt_products.AutoSize = true;
            this.bt_products.Location = new System.Drawing.Point(5, 92);
            this.bt_products.Name = "bt_products";
            this.bt_products.Size = new System.Drawing.Size(76, 25);
            this.bt_products.TabIndex = 4;
            this.bt_products.Text = "PRODUCTS";
            this.bt_products.UseVisualStyleBackColor = true;
            this.bt_products.Click += new System.EventHandler(this.bt_products_Click);
            // 
            // bt_sellers
            // 
            this.bt_sellers.Location = new System.Drawing.Point(4, 44);
            this.bt_sellers.Name = "bt_sellers";
            this.bt_sellers.Size = new System.Drawing.Size(82, 21);
            this.bt_sellers.TabIndex = 5;
            this.bt_sellers.Text = "SELLERS";
            this.bt_sellers.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.bt_selling);
            this.Controls.Add(this.bt_products);
            this.Controls.Add(this.bt_sellers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manage_categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button tb_refresh;
        private System.Windows.Forms.DataGridView dgv_manage_categories;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cat_name;
        private System.Windows.Forms.TextBox tb_cat_description;
        private System.Windows.Forms.TextBox tb_cat_id;
        private System.Windows.Forms.Button bt_selling;
        private System.Windows.Forms.Button bt_products;
        private System.Windows.Forms.Button bt_sellers;
    }
}