namespace Pescaderia
{
    partial class Inicio_Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_registros = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_precioBolivar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_precioDolar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_autor = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.tb_clienteName = new System.Windows.Forms.TextBox();
            this.lb_clienteName = new System.Windows.Forms.Label();
            this.lb_cedulaIdentidad = new System.Windows.Forms.Label();
            this.tb_cedula = new System.Windows.Forms.TextBox();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.cb_metodo = new System.Windows.Forms.ComboBox();
            this.cb_bank = new System.Windows.Forms.ComboBox();
            this.lb_tipoPago = new System.Windows.Forms.Label();
            this.lb_bancoPago = new System.Windows.Forms.Label();
            this.tb_referenciaPago = new System.Windows.Forms.TextBox();
            this.lb_ref = new System.Windows.Forms.Label();
            this.gridView_items = new System.Windows.Forms.DataGridView();
            this.header_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_precioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.num_articulosCantidad = new System.Windows.Forms.NumericUpDown();
            this.lb_productoLabel = new System.Windows.Forms.Label();
            this.cb_articulos = new System.Windows.Forms.ComboBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_articulosCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.btn_registros);
            this.panel1.Controls.Add(this.btn_stats);
            this.panel1.Controls.Add(this.btn_inventory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_precioBolivar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_precioDolar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 465);
            this.panel1.TabIndex = 0;
            // 
            // btn_registros
            // 
            this.btn_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registros.ForeColor = System.Drawing.Color.White;
            this.btn_registros.Location = new System.Drawing.Point(0, 407);
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.Size = new System.Drawing.Size(215, 42);
            this.btn_registros.TabIndex = 20;
            this.btn_registros.Text = "Registros";
            this.btn_registros.UseVisualStyleBackColor = true;
            this.btn_registros.Click += new System.EventHandler(this.btn_registros_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.ForeColor = System.Drawing.Color.White;
            this.btn_stats.Location = new System.Drawing.Point(0, 352);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(215, 42);
            this.btn_stats.TabIndex = 4;
            this.btn_stats.Text = "Estadisticas";
            this.btn_stats.UseVisualStyleBackColor = true;
            // 
            // btn_inventory
            // 
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.Location = new System.Drawing.Point(0, 293);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(215, 42);
            this.btn_inventory.TabIndex = 3;
            this.btn_inventory.Text = "Inventario";
            this.btn_inventory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "TOTAL A PAGAR";
            // 
            // lb_precioBolivar
            // 
            this.lb_precioBolivar.AutoSize = true;
            this.lb_precioBolivar.Location = new System.Drawing.Point(70, 74);
            this.lb_precioBolivar.Name = "lb_precioBolivar";
            this.lb_precioBolivar.Size = new System.Drawing.Size(55, 23);
            this.lb_precioBolivar.TabIndex = 19;
            this.lb_precioBolivar.Text = "0BsS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "BsS: ";
            // 
            // lb_precioDolar
            // 
            this.lb_precioDolar.AutoSize = true;
            this.lb_precioDolar.Location = new System.Drawing.Point(70, 100);
            this.lb_precioDolar.Name = "lb_precioDolar";
            this.lb_precioDolar.Size = new System.Drawing.Size(32, 23);
            this.lb_precioDolar.TabIndex = 18;
            this.lb_precioDolar.Text = "0$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ref:";
            // 
            // lb_autor
            // 
            this.lb_autor.AutoSize = true;
            this.lb_autor.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_autor.Location = new System.Drawing.Point(941, 445);
            this.lb_autor.Name = "lb_autor";
            this.lb_autor.Size = new System.Drawing.Size(92, 14);
            this.lb_autor.TabIndex = 6;
            this.lb_autor.Text = "Design by Alexx";
            this.lb_autor.Click += new System.EventHandler(this.lb_autor_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(237, 18);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(255, 33);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Pescaderia Lolymar";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Location = new System.Drawing.Point(994, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(49, 39);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_minimize.Location = new System.Drawing.Point(946, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(49, 39);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // tb_clienteName
            // 
            this.tb_clienteName.Location = new System.Drawing.Point(239, 352);
            this.tb_clienteName.Name = "tb_clienteName";
            this.tb_clienteName.Size = new System.Drawing.Size(213, 30);
            this.tb_clienteName.TabIndex = 9;
            // 
            // lb_clienteName
            // 
            this.lb_clienteName.AutoSize = true;
            this.lb_clienteName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clienteName.Location = new System.Drawing.Point(235, 324);
            this.lb_clienteName.Name = "lb_clienteName";
            this.lb_clienteName.Size = new System.Drawing.Size(141, 23);
            this.lb_clienteName.TabIndex = 10;
            this.lb_clienteName.Text = "Nombre cliente";
            // 
            // lb_cedulaIdentidad
            // 
            this.lb_cedulaIdentidad.AutoSize = true;
            this.lb_cedulaIdentidad.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cedulaIdentidad.Location = new System.Drawing.Point(454, 324);
            this.lb_cedulaIdentidad.Name = "lb_cedulaIdentidad";
            this.lb_cedulaIdentidad.Size = new System.Drawing.Size(74, 23);
            this.lb_cedulaIdentidad.TabIndex = 12;
            this.lb_cedulaIdentidad.Text = "Cedula:";
            // 
            // tb_cedula
            // 
            this.tb_cedula.Location = new System.Drawing.Point(458, 352);
            this.tb_cedula.Name = "tb_cedula";
            this.tb_cedula.Size = new System.Drawing.Size(143, 30);
            this.tb_cedula.TabIndex = 11;
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefono.Location = new System.Drawing.Point(603, 323);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(85, 23);
            this.lb_telefono.TabIndex = 14;
            this.lb_telefono.Text = "Telefono";
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(607, 352);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(143, 30);
            this.tb_telefono.TabIndex = 13;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(616, 413);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(215, 31);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Registrar Pago";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cb_metodo
            // 
            this.cb_metodo.FormattingEnabled = true;
            this.cb_metodo.Location = new System.Drawing.Point(239, 413);
            this.cb_metodo.Name = "cb_metodo";
            this.cb_metodo.Size = new System.Drawing.Size(154, 31);
            this.cb_metodo.TabIndex = 20;
            this.cb_metodo.SelectedIndexChanged += new System.EventHandler(this.cb_metodo_SelectedIndexChanged);
            // 
            // cb_bank
            // 
            this.cb_bank.FormattingEnabled = true;
            this.cb_bank.Location = new System.Drawing.Point(399, 413);
            this.cb_bank.Name = "cb_bank";
            this.cb_bank.Size = new System.Drawing.Size(201, 31);
            this.cb_bank.TabIndex = 21;
            // 
            // lb_tipoPago
            // 
            this.lb_tipoPago.AutoSize = true;
            this.lb_tipoPago.Location = new System.Drawing.Point(239, 388);
            this.lb_tipoPago.Name = "lb_tipoPago";
            this.lb_tipoPago.Size = new System.Drawing.Size(125, 23);
            this.lb_tipoPago.TabIndex = 22;
            this.lb_tipoPago.Text = "Metodo Pago";
            // 
            // lb_bancoPago
            // 
            this.lb_bancoPago.AutoSize = true;
            this.lb_bancoPago.Location = new System.Drawing.Point(395, 387);
            this.lb_bancoPago.Name = "lb_bancoPago";
            this.lb_bancoPago.Size = new System.Drawing.Size(64, 23);
            this.lb_bancoPago.TabIndex = 23;
            this.lb_bancoPago.Text = "Banco";
            // 
            // tb_referenciaPago
            // 
            this.tb_referenciaPago.Location = new System.Drawing.Point(756, 352);
            this.tb_referenciaPago.Name = "tb_referenciaPago";
            this.tb_referenciaPago.Size = new System.Drawing.Size(143, 30);
            this.tb_referenciaPago.TabIndex = 24;
            // 
            // lb_ref
            // 
            this.lb_ref.AutoSize = true;
            this.lb_ref.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ref.Location = new System.Drawing.Point(752, 324);
            this.lb_ref.Name = "lb_ref";
            this.lb_ref.Size = new System.Drawing.Size(101, 23);
            this.lb_ref.TabIndex = 25;
            this.lb_ref.Text = "Referencia";
            // 
            // gridView_items
            // 
            this.gridView_items.AllowUserToAddRows = false;
            this.gridView_items.AllowUserToDeleteRows = false;
            this.gridView_items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.gridView_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridView_items.ColumnHeadersHeight = 30;
            this.gridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header_producto,
            this.header_cantidad,
            this.header_precioUnit,
            this.header_PrecioTotal,
            this.header_tipo});
            this.gridView_items.GridColor = System.Drawing.Color.Snow;
            this.gridView_items.Location = new System.Drawing.Point(239, 132);
            this.gridView_items.MultiSelect = false;
            this.gridView_items.Name = "gridView_items";
            this.gridView_items.ReadOnly = true;
            this.gridView_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridView_items.Size = new System.Drawing.Size(772, 181);
            this.gridView_items.TabIndex = 27;
            // 
            // header_producto
            // 
            this.header_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header_producto.DefaultCellStyle = dataGridViewCellStyle1;
            this.header_producto.HeaderText = "Producto";
            this.header_producto.Name = "header_producto";
            this.header_producto.ReadOnly = true;
            // 
            // header_cantidad
            // 
            this.header_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header_cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.header_cantidad.HeaderText = "Cantidad";
            this.header_cantidad.Name = "header_cantidad";
            this.header_cantidad.ReadOnly = true;
            // 
            // header_precioUnit
            // 
            this.header_precioUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header_precioUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.header_precioUnit.HeaderText = "Precio Unidad";
            this.header_precioUnit.Name = "header_precioUnit";
            this.header_precioUnit.ReadOnly = true;
            // 
            // header_PrecioTotal
            // 
            this.header_PrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header_PrecioTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.header_PrecioTotal.HeaderText = "Total";
            this.header_PrecioTotal.Name = "header_PrecioTotal";
            this.header_PrecioTotal.ReadOnly = true;
            // 
            // header_tipo
            // 
            this.header_tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header_tipo.DefaultCellStyle = dataGridViewCellStyle5;
            this.header_tipo.HeaderText = "Tipo Producto";
            this.header_tipo.Name = "header_tipo";
            this.header_tipo.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(711, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // num_articulosCantidad
            // 
            this.num_articulosCantidad.DecimalPlaces = 3;
            this.num_articulosCantidad.Location = new System.Drawing.Point(458, 95);
            this.num_articulosCantidad.Name = "num_articulosCantidad";
            this.num_articulosCantidad.Size = new System.Drawing.Size(87, 30);
            this.num_articulosCantidad.TabIndex = 36;
            // 
            // lb_productoLabel
            // 
            this.lb_productoLabel.AutoSize = true;
            this.lb_productoLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productoLabel.Location = new System.Drawing.Point(235, 69);
            this.lb_productoLabel.Name = "lb_productoLabel";
            this.lb_productoLabel.Size = new System.Drawing.Size(89, 23);
            this.lb_productoLabel.TabIndex = 35;
            this.lb_productoLabel.Text = "Producto";
            // 
            // cb_articulos
            // 
            this.cb_articulos.FormattingEnabled = true;
            this.cb_articulos.Location = new System.Drawing.Point(239, 95);
            this.cb_articulos.Name = "cb_articulos";
            this.cb_articulos.Size = new System.Drawing.Size(213, 31);
            this.cb_articulos.TabIndex = 34;
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.Color.Crimson;
            this.btn_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.Location = new System.Drawing.Point(551, 93);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(154, 31);
            this.btn_addItem.TabIndex = 33;
            this.btn_addItem.Text = "Añadir a cesta";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // Inicio_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1043, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_articulosCantidad);
            this.Controls.Add(this.lb_productoLabel);
            this.Controls.Add(this.cb_articulos);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.gridView_items);
            this.Controls.Add(this.lb_autor);
            this.Controls.Add(this.lb_ref);
            this.Controls.Add(this.tb_referenciaPago);
            this.Controls.Add(this.lb_bancoPago);
            this.Controls.Add(this.lb_tipoPago);
            this.Controls.Add(this.cb_bank);
            this.Controls.Add(this.cb_metodo);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lb_telefono);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.lb_cedulaIdentidad);
            this.Controls.Add(this.tb_cedula);
            this.Controls.Add(this.lb_clienteName);
            this.Controls.Add(this.tb_clienteName);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Inicio_Form";
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.Inicio_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_articulosCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label lb_autor;
        private System.Windows.Forms.TextBox tb_clienteName;
        private System.Windows.Forms.Label lb_clienteName;
        private System.Windows.Forms.Label lb_cedulaIdentidad;
        private System.Windows.Forms.TextBox tb_cedula;
        private System.Windows.Forms.Label lb_telefono;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lb_precioDolar;
        private System.Windows.Forms.Label lb_precioBolivar;
        private System.Windows.Forms.ComboBox cb_metodo;
        private System.Windows.Forms.ComboBox cb_bank;
        private System.Windows.Forms.Label lb_tipoPago;
        private System.Windows.Forms.Label lb_bancoPago;
        private System.Windows.Forms.TextBox tb_referenciaPago;
        private System.Windows.Forms.Label lb_ref;
        private System.Windows.Forms.DataGridView gridView_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_precioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_tipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown num_articulosCantidad;
        private System.Windows.Forms.Label lb_productoLabel;
        private System.Windows.Forms.ComboBox cb_articulos;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_registros;
    }
}

