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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_registrosTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.h_clienteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_totalPaidBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_totalPaidDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_tipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h_clienteName,
            this.h_article,
            this.h_totalPaidBs,
            this.h_totalPaidDolar,
            this.h_reference,
            this.h_bank,
            this.h_tipoPago});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(900, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // lb_registrosTitle
            // 
            this.lb_registrosTitle.AutoSize = true;
            this.lb_registrosTitle.BackColor = System.Drawing.Color.Transparent;
            this.lb_registrosTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registrosTitle.Location = new System.Drawing.Point(5, 9);
            this.lb_registrosTitle.Name = "lb_registrosTitle";
            this.lb_registrosTitle.Size = new System.Drawing.Size(196, 38);
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
            this.panel1.Size = new System.Drawing.Size(924, 56);
            this.panel1.TabIndex = 2;
            // 
            // h_clienteName
            // 
            this.h_clienteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_clienteName.HeaderText = "Cliente";
            this.h_clienteName.Name = "h_clienteName";
            this.h_clienteName.ReadOnly = true;
            // 
            // h_article
            // 
            this.h_article.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.h_article.HeaderText = "Articulo";
            this.h_article.Name = "h_article";
            this.h_article.ReadOnly = true;
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
            // form_registros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(924, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "form_registros";
            this.Text = "REGISTROS / .: PESCADERIA LOLYMAR :.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_registrosTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_clienteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_totalPaidBs;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_totalPaidDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_tipoPago;
    }
}