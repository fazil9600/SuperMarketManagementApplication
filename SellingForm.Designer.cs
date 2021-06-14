
namespace SuperMarketManagementApplication
{
    partial class SellingForm
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(102, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 376);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "SELLING ";
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
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
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
    }
}