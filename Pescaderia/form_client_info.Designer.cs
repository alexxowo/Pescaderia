
namespace Pescaderia
{
    partial class form_client_info
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_client_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewer_articles = new System.Windows.Forms.DataGridView();
            this.head_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head_precioPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_client = new System.Windows.Forms.Label();
            this.lb_contact = new System.Windows.Forms.Label();
            this.lb_identidad = new System.Windows.Forms.Label();
            this.lb_fecha_compra = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_total_ref = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_paid_type = new System.Windows.Forms.Label();
            this.lb_paid_ref = new System.Windows.Forms.Label();
            this.lb_bank = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewer_articles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(144)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.lb_client_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 52);
            this.panel1.TabIndex = 0;
            // 
            // lb_client_title
            // 
            this.lb_client_title.AutoSize = true;
            this.lb_client_title.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_client_title.Location = new System.Drawing.Point(12, 9);
            this.lb_client_title.Name = "lb_client_title";
            this.lb_client_title.Size = new System.Drawing.Size(103, 35);
            this.lb_client_title.TabIndex = 0;
            this.lb_client_title.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contacto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cedula de Identidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de compra:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // viewer_articles
            // 
            this.viewer_articles.AllowUserToAddRows = false;
            this.viewer_articles.AllowUserToDeleteRows = false;
            this.viewer_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewer_articles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.head_article,
            this.head_cant,
            this.head_precio,
            this.head_precioPagar});
            this.viewer_articles.Location = new System.Drawing.Point(18, 250);
            this.viewer_articles.Name = "viewer_articles";
            this.viewer_articles.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.viewer_articles.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewer_articles.Size = new System.Drawing.Size(497, 266);
            this.viewer_articles.TabIndex = 5;
            // 
            // head_article
            // 
            this.head_article.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.head_article.HeaderText = "Articulo";
            this.head_article.Name = "head_article";
            this.head_article.ReadOnly = true;
            // 
            // head_cant
            // 
            this.head_cant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.head_cant.HeaderText = "Cantidad";
            this.head_cant.Name = "head_cant";
            this.head_cant.ReadOnly = true;
            // 
            // head_precio
            // 
            this.head_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.head_precio.HeaderText = "Precio";
            this.head_precio.Name = "head_precio";
            this.head_precio.ReadOnly = true;
            // 
            // head_precioPagar
            // 
            this.head_precioPagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.head_precioPagar.HeaderText = "Precio a Pagar";
            this.head_precioPagar.Name = "head_precioPagar";
            this.head_precioPagar.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Articulos Comprados:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total (ref):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_client
            // 
            this.lb_client.AutoSize = true;
            this.lb_client.Location = new System.Drawing.Point(148, 76);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(44, 19);
            this.lb_client.TabIndex = 9;
            this.lb_client.Text = "NULL";
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Location = new System.Drawing.Point(109, 110);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(44, 19);
            this.lb_contact.TabIndex = 10;
            this.lb_contact.Text = "NULL";
            // 
            // lb_identidad
            // 
            this.lb_identidad.AutoSize = true;
            this.lb_identidad.Location = new System.Drawing.Point(178, 146);
            this.lb_identidad.Name = "lb_identidad";
            this.lb_identidad.Size = new System.Drawing.Size(44, 19);
            this.lb_identidad.TabIndex = 11;
            this.lb_identidad.Text = "NULL";
            // 
            // lb_fecha_compra
            // 
            this.lb_fecha_compra.AutoSize = true;
            this.lb_fecha_compra.Location = new System.Drawing.Point(160, 185);
            this.lb_fecha_compra.Name = "lb_fecha_compra";
            this.lb_fecha_compra.Size = new System.Drawing.Size(44, 19);
            this.lb_fecha_compra.TabIndex = 12;
            this.lb_fecha_compra.Text = "NULL";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(373, 550);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(44, 19);
            this.lb_total.TabIndex = 14;
            this.lb_total.Text = "NULL";
            // 
            // lb_total_ref
            // 
            this.lb_total_ref.AutoSize = true;
            this.lb_total_ref.Location = new System.Drawing.Point(373, 528);
            this.lb_total_ref.Name = "lb_total_ref";
            this.lb_total_ref.Size = new System.Drawing.Size(44, 19);
            this.lb_total_ref.TabIndex = 15;
            this.lb_total_ref.Text = "NULL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ref:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Banco:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_paid_type
            // 
            this.lb_paid_type.AutoSize = true;
            this.lb_paid_type.Location = new System.Drawing.Point(82, 528);
            this.lb_paid_type.Name = "lb_paid_type";
            this.lb_paid_type.Size = new System.Drawing.Size(44, 19);
            this.lb_paid_type.TabIndex = 19;
            this.lb_paid_type.Text = "NULL";
            // 
            // lb_paid_ref
            // 
            this.lb_paid_ref.AutoSize = true;
            this.lb_paid_ref.Location = new System.Drawing.Point(71, 550);
            this.lb_paid_ref.Name = "lb_paid_ref";
            this.lb_paid_ref.Size = new System.Drawing.Size(44, 19);
            this.lb_paid_ref.TabIndex = 20;
            this.lb_paid_ref.Text = "NULL";
            // 
            // lb_bank
            // 
            this.lb_bank.AutoSize = true;
            this.lb_bank.Location = new System.Drawing.Point(91, 573);
            this.lb_bank.Name = "lb_bank";
            this.lb_bank.Size = new System.Drawing.Size(44, 19);
            this.lb_bank.TabIndex = 21;
            this.lb_bank.Text = "NULL";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Crimson;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(0, 600);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(543, 31);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // form_client_info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(543, 631);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_bank);
            this.Controls.Add(this.lb_paid_ref);
            this.Controls.Add(this.lb_paid_type);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_total_ref);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb_fecha_compra);
            this.Controls.Add(this.lb_identidad);
            this.Controls.Add(this.lb_contact);
            this.Controls.Add(this.lb_client);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viewer_articles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "form_client_info";
            this.Text = "Cliente /  .: Lolymar :.";
            this.Load += new System.EventHandler(this.form_client_info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewer_articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_client_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView viewer_articles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_client;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.Label lb_identidad;
        private System.Windows.Forms.Label lb_fecha_compra;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_total_ref;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_paid_type;
        private System.Windows.Forms.Label lb_paid_ref;
        private System.Windows.Forms.Label lb_bank;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_precioPagar;
    }
}