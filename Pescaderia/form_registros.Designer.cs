namespace Pescaderia
{
    partial class form_registros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewer_clients = new System.Windows.Forms.DataGridView();
            this.lb_registrosTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_view_details = new System.Windows.Forms.Button();
            this.lb_cant_vendido = new System.Windows.Forms.Label();
            this.lb_stock_total = new System.Windows.Forms.Label();
            this.lb_vendidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_mas_vendido = new System.Windows.Forms.Label();
            this.options_view = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.h_clienteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_totalPaidBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_totalPaidDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_tipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePurchase = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.viewer_clients)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewer_clients
            // 
            this.viewer_clients.AllowUserToAddRows = false;
            this.viewer_clients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewer_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewer_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewer_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h_clienteName,
            this.h_totalPaidBs,
            this.h_totalPaidDolar,
            this.h_reference,
            this.h_bank,
            this.h_tipoPago,
            this.header_datetime});
            this.viewer_clients.Location = new System.Drawing.Point(6, 48);
            this.viewer_clients.Name = "viewer_clients";
            this.viewer_clients.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.viewer_clients.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.viewer_clients.Size = new System.Drawing.Size(900, 302);
            this.viewer_clients.TabIndex = 0;
            this.viewer_clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectClientCell);
            // 
            // lb_registrosTitle
            // 
            this.lb_registrosTitle.AutoSize = true;
            this.lb_registrosTitle.BackColor = System.Drawing.Color.Transparent;
            this.lb_registrosTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registrosTitle.Location = new System.Drawing.Point(5, 9);
            this.lb_registrosTitle.Name = "lb_registrosTitle";
            this.lb_registrosTitle.Size = new System.Drawing.Size(185, 38);
            this.lb_registrosTitle.TabIndex = 1;
            this.lb_registrosTitle.Text = "REGISTROS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.lb_registrosTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 56);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePurchase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.options_view);
            this.groupBox1.Controls.Add(this.btn_view_details);
            this.groupBox1.Controls.Add(this.lb_cant_vendido);
            this.groupBox1.Controls.Add(this.lb_stock_total);
            this.groupBox1.Controls.Add(this.lb_vendidos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_stock);
            this.groupBox1.Controls.Add(this.lb_mas_vendido);
            this.groupBox1.Controls.Add(this.viewer_clients);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas del dia";
            // 
            // btn_view_details
            // 
            this.btn_view_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(194)))));
            this.btn_view_details.Enabled = false;
            this.btn_view_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_details.Location = new System.Drawing.Point(762, 364);
            this.btn_view_details.Name = "btn_view_details";
            this.btn_view_details.Size = new System.Drawing.Size(134, 45);
            this.btn_view_details.TabIndex = 7;
            this.btn_view_details.Text = "Detalles";
            this.btn_view_details.UseVisualStyleBackColor = false;
            this.btn_view_details.Click += new System.EventHandler(this.OpenClientDetailsForm);
            // 
            // lb_cant_vendido
            // 
            this.lb_cant_vendido.AutoSize = true;
            this.lb_cant_vendido.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cant_vendido.Location = new System.Drawing.Point(353, 390);
            this.lb_cant_vendido.Name = "lb_cant_vendido";
            this.lb_cant_vendido.Size = new System.Drawing.Size(85, 19);
            this.lb_cant_vendido.TabIndex = 6;
            this.lb_cant_vendido.Text = "ARTICULO";
            // 
            // lb_stock_total
            // 
            this.lb_stock_total.AutoSize = true;
            this.lb_stock_total.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stock_total.Location = new System.Drawing.Point(125, 390);
            this.lb_stock_total.Name = "lb_stock_total";
            this.lb_stock_total.Size = new System.Drawing.Size(85, 19);
            this.lb_stock_total.TabIndex = 5;
            this.lb_stock_total.Text = "ARTICULO";
            // 
            // lb_vendidos
            // 
            this.lb_vendidos.AutoSize = true;
            this.lb_vendidos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vendidos.Location = new System.Drawing.Point(147, 364);
            this.lb_vendidos.Name = "lb_vendidos";
            this.lb_vendidos.Size = new System.Drawing.Size(85, 19);
            this.lb_vendidos.TabIndex = 4;
            this.lb_vendidos.Text = "ARTICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendido:";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stock.Location = new System.Drawing.Point(15, 390);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(104, 19);
            this.lb_stock.TabIndex = 2;
            this.lb_stock.Text = "Stock (Total):";
            // 
            // lb_mas_vendido
            // 
            this.lb_mas_vendido.AutoSize = true;
            this.lb_mas_vendido.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mas_vendido.Location = new System.Drawing.Point(15, 364);
            this.lb_mas_vendido.Name = "lb_mas_vendido";
            this.lb_mas_vendido.Size = new System.Drawing.Size(126, 19);
            this.lb_mas_vendido.TabIndex = 1;
            this.lb_mas_vendido.Text = "Lo mas vendido:";
            // 
            // options_view
            // 
            this.options_view.FormattingEnabled = true;
            this.options_view.Location = new System.Drawing.Point(58, 19);
            this.options_view.Name = "options_view";
            this.options_view.Size = new System.Drawing.Size(121, 23);
            this.options_view.TabIndex = 8;
            this.options_view.SelectedValueChanged += new System.EventHandler(this.SetViewerOptions);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ver:";
            // 
            // h_clienteName
            // 
            this.h_clienteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_clienteName.HeaderText = "Cliente";
            this.h_clienteName.Name = "h_clienteName";
            this.h_clienteName.ReadOnly = true;
            // 
            // h_totalPaidBs
            // 
            this.h_totalPaidBs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_totalPaidBs.HeaderText = "Pago BsS";
            this.h_totalPaidBs.Name = "h_totalPaidBs";
            this.h_totalPaidBs.ReadOnly = true;
            // 
            // h_totalPaidDolar
            // 
            this.h_totalPaidDolar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_totalPaidDolar.HeaderText = "Total Dolar";
            this.h_totalPaidDolar.Name = "h_totalPaidDolar";
            this.h_totalPaidDolar.ReadOnly = true;
            // 
            // h_reference
            // 
            this.h_reference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_reference.HeaderText = "Referencia";
            this.h_reference.Name = "h_reference";
            this.h_reference.ReadOnly = true;
            // 
            // h_bank
            // 
            this.h_bank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_bank.HeaderText = "Banco";
            this.h_bank.Name = "h_bank";
            this.h_bank.ReadOnly = true;
            // 
            // h_tipoPago
            // 
            this.h_tipoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_tipoPago.HeaderText = "Metodo pago";
            this.h_tipoPago.Name = "h_tipoPago";
            this.h_tipoPago.ReadOnly = true;
            // 
            // header_datetime
            // 
            this.header_datetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.header_datetime.HeaderText = "Fecha";
            this.header_datetime.Name = "header_datetime";
            this.header_datetime.ReadOnly = true;
            // 
            // dateTimePurchase
            // 
            this.dateTimePurchase.Location = new System.Drawing.Point(185, 19);
            this.dateTimePurchase.Name = "dateTimePurchase";
            this.dateTimePurchase.Size = new System.Drawing.Size(200, 23);
            this.dateTimePurchase.TabIndex = 10;
            this.dateTimePurchase.ValueChanged += new System.EventHandler(this.ChooseDateTimeToSearch);
            // 
            // form_registros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(934, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "form_registros";
            this.Text = "REGISTROS / .: PESCADERIA LOLYMAR :.";
            this.Load += new System.EventHandler(this.form_registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewer_clients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewer_clients;
        private System.Windows.Forms.Label lb_registrosTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_mas_vendido;
        private System.Windows.Forms.Label lb_vendidos;
        private System.Windows.Forms.Label lb_cant_vendido;
        private System.Windows.Forms.Label lb_stock_total;
        private System.Windows.Forms.Button btn_view_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox options_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_clienteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_totalPaidBs;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_totalPaidDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_tipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_datetime;
        private System.Windows.Forms.DateTimePicker dateTimePurchase;
    }
}