
namespace Pescaderia
{
    partial class form_inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataview_database = new System.Windows.Forms.DataGridView();
            this.header_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add_article = new System.Windows.Forms.Button();
            this.lb_article_stock = new System.Windows.Forms.Label();
            this.numeric_stock = new System.Windows.Forms.NumericUpDown();
            this.lb_article_price = new System.Windows.Forms.Label();
            this.numeric_price = new System.Windows.Forms.NumericUpDown();
            this.lb_article_title = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_edit_stock = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_edit_price = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_edit_art_title = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_database)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_edit_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_edit_price)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataview_database);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulos Actuales";
            // 
            // dataview_database
            // 
            this.dataview_database.AllowUserToAddRows = false;
            this.dataview_database.AllowUserToDeleteRows = false;
            this.dataview_database.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview_database.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataview_database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_database.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header_id,
            this.header_article,
            this.header_price,
            this.header_stock});
            this.dataview_database.GridColor = System.Drawing.Color.Black;
            this.dataview_database.Location = new System.Drawing.Point(6, 26);
            this.dataview_database.Name = "dataview_database";
            this.dataview_database.ReadOnly = true;
            this.dataview_database.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataview_database.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataview_database.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataview_database.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataview_database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataview_database.Size = new System.Drawing.Size(416, 409);
            this.dataview_database.TabIndex = 0;
            this.dataview_database.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectArticleCell);
            // 
            // header_id
            // 
            this.header_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.header_id.HeaderText = "ID";
            this.header_id.Name = "header_id";
            this.header_id.ReadOnly = true;
            // 
            // header_article
            // 
            this.header_article.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.header_article.DefaultCellStyle = dataGridViewCellStyle2;
            this.header_article.HeaderText = "Articulo";
            this.header_article.Name = "header_article";
            this.header_article.ReadOnly = true;
            // 
            // header_price
            // 
            this.header_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.header_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.header_price.HeaderText = "Precio";
            this.header_price.Name = "header_price";
            this.header_price.ReadOnly = true;
            // 
            // header_stock
            // 
            this.header_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.header_stock.DefaultCellStyle = dataGridViewCellStyle4;
            this.header_stock.HeaderText = "Stock";
            this.header_stock.Name = "header_stock";
            this.header_stock.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_article);
            this.groupBox2.Controls.Add(this.lb_article_stock);
            this.groupBox2.Controls.Add(this.numeric_stock);
            this.groupBox2.Controls.Add(this.lb_article_price);
            this.groupBox2.Controls.Add(this.numeric_price);
            this.groupBox2.Controls.Add(this.lb_article_title);
            this.groupBox2.Controls.Add(this.tb_title);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(450, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir Articulos";
            // 
            // btn_add_article
            // 
            this.btn_add_article.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btn_add_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_article.Location = new System.Drawing.Point(6, 89);
            this.btn_add_article.Name = "btn_add_article";
            this.btn_add_article.Size = new System.Drawing.Size(395, 34);
            this.btn_add_article.TabIndex = 6;
            this.btn_add_article.Text = "Añadir";
            this.btn_add_article.UseVisualStyleBackColor = false;
            this.btn_add_article.Click += new System.EventHandler(this.AddArticle);
            // 
            // lb_article_stock
            // 
            this.lb_article_stock.AutoSize = true;
            this.lb_article_stock.Location = new System.Drawing.Point(307, 26);
            this.lb_article_stock.Name = "lb_article_stock";
            this.lb_article_stock.Size = new System.Drawing.Size(49, 19);
            this.lb_article_stock.TabIndex = 5;
            this.lb_article_stock.Text = "Stock";
            // 
            // numeric_stock
            // 
            this.numeric_stock.DecimalPlaces = 3;
            this.numeric_stock.InterceptArrowKeys = false;
            this.numeric_stock.Location = new System.Drawing.Point(311, 48);
            this.numeric_stock.Name = "numeric_stock";
            this.numeric_stock.Size = new System.Drawing.Size(90, 27);
            this.numeric_stock.TabIndex = 4;
            // 
            // lb_article_price
            // 
            this.lb_article_price.AutoSize = true;
            this.lb_article_price.Location = new System.Drawing.Point(209, 27);
            this.lb_article_price.Name = "lb_article_price";
            this.lb_article_price.Size = new System.Drawing.Size(54, 19);
            this.lb_article_price.TabIndex = 3;
            this.lb_article_price.Text = "Precio";
            // 
            // numeric_price
            // 
            this.numeric_price.DecimalPlaces = 3;
            this.numeric_price.InterceptArrowKeys = false;
            this.numeric_price.Location = new System.Drawing.Point(213, 49);
            this.numeric_price.Name = "numeric_price";
            this.numeric_price.Size = new System.Drawing.Size(90, 27);
            this.numeric_price.TabIndex = 2;
            // 
            // lb_article_title
            // 
            this.lb_article_title.AutoSize = true;
            this.lb_article_title.Location = new System.Drawing.Point(2, 21);
            this.lb_article_title.Name = "lb_article_title";
            this.lb_article_title.Size = new System.Drawing.Size(68, 19);
            this.lb_article_title.TabIndex = 1;
            this.lb_article_title.Text = "Articulo:";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(6, 48);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(201, 27);
            this.tb_title.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numeric_edit_stock);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numeric_edit_price);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_edit_art_title);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(450, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 134);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editar Articulo";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(63)))), ((int)(((byte)(91)))));
            this.btn_edit.Enabled = false;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(6, 89);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(395, 34);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Modificar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.EditSelectedArticle);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock";
            // 
            // numeric_edit_stock
            // 
            this.numeric_edit_stock.DecimalPlaces = 3;
            this.numeric_edit_stock.Enabled = false;
            this.numeric_edit_stock.InterceptArrowKeys = false;
            this.numeric_edit_stock.Location = new System.Drawing.Point(311, 48);
            this.numeric_edit_stock.Name = "numeric_edit_stock";
            this.numeric_edit_stock.Size = new System.Drawing.Size(90, 27);
            this.numeric_edit_stock.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // numeric_edit_price
            // 
            this.numeric_edit_price.DecimalPlaces = 3;
            this.numeric_edit_price.Enabled = false;
            this.numeric_edit_price.InterceptArrowKeys = false;
            this.numeric_edit_price.Location = new System.Drawing.Point(213, 49);
            this.numeric_edit_price.Name = "numeric_edit_price";
            this.numeric_edit_price.Size = new System.Drawing.Size(90, 27);
            this.numeric_edit_price.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Articulo:";
            // 
            // tb_edit_art_title
            // 
            this.tb_edit_art_title.Enabled = false;
            this.tb_edit_art_title.Location = new System.Drawing.Point(6, 48);
            this.tb_edit_art_title.Name = "tb_edit_art_title";
            this.tb_edit_art_title.Size = new System.Drawing.Size(201, 27);
            this.tb_edit_art_title.TabIndex = 0;
            // 
            // form_inventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(878, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_inventory";
            this.ShowIcon = false;
            this.Text = "Pescaderia Lolymar / Inventario";
            this.Load += new System.EventHandler(this.FormInventoryLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataview_database)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_edit_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_edit_price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add_article;
        private System.Windows.Forms.Label lb_article_stock;
        private System.Windows.Forms.NumericUpDown numeric_stock;
        private System.Windows.Forms.Label lb_article_price;
        private System.Windows.Forms.NumericUpDown numeric_price;
        private System.Windows.Forms.Label lb_article_title;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.DataGridView dataview_database;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_edit_stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_edit_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_edit_art_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_stock;
    }
}