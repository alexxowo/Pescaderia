using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pescaderia.Internal;
using Pescaderia.Internal.objects;
using ToolsCripto_Alexx;
using System.IO;

namespace Pescaderia
{
    public partial class Inicio_Form : Form, iUpdate
    {
        List<Compra> databaseCompras = Serializer.JSON_Deserialize<Compra>(directories.comprasFile);
        List<Articulos> databaseArticulos = Serializer.JSON_Deserialize<Articulos>(directories.productsFile);
        List<Articulos> articulosCompra = new List<Articulos>();

        private double totalAPagar = 0;
        private double referenciaDolar = 820000;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Inicio_Form()
        {
            InitializeComponent();
            insertData();

            if (!Directory.Exists(directories.comprasFolder))
                Directory.CreateDirectory(directories.comprasFolder);        
        }

        private void Inicio_Form_Load(object sender, EventArgs e) { }

        #region controls
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void insertData()
        {
            if(cb_articulos.Items.Count > 0)
            {
                databaseArticulos = Serializer.JSON_Deserialize<Articulos>(directories.productsFile);
                cb_articulos.Items.Clear();
            }

            foreach (Articulos articulo in databaseArticulos){
                cb_articulos.Items.Add(articulo.Nombre);
            }

            cb_metodo.DataSource = Enum.GetNames(typeof(eTipoPago));
            cb_bank.DataSource = Enum.GetNames(typeof(eBancoPago));
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            if (num_articulosCantidad.Value > 0)
            {
                referenciaDolar = (double)numeric_dolar_today.Value;
                int itemSelected = cb_articulos.SelectedIndex;
                double precioTotal = databaseArticulos[itemSelected].Precio * (double)num_articulosCantidad.Value;

                totalAPagar = totalAPagar + precioTotal;
                lb_precioDolar.Text = totalAPagar.ToString()+" $";
                lb_precioBolivar.Text = (totalAPagar * referenciaDolar).ToString()+" BsS";
            
                gridView_items.Rows.Add(
                    databaseArticulos[itemSelected].Nombre,
                    (double)num_articulosCantidad.Value,
                    databaseArticulos[itemSelected].Precio.ToString()+"$",
                    precioTotal + "$",
                    string.Empty
                );
                databaseArticulos[itemSelected].cantidad = (double)num_articulosCantidad.Value;
                articulosCompra.Add(databaseArticulos[itemSelected]);


            }
        }

        #endregion

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tb_clienteName.Text != string.Empty) {
                if (articulosCompra.Count > 0) {
                    Compra nuevaCompra = new Compra();
                    nuevaCompra.nombreCliente = tb_clienteName.Text; // Nombre cliente
                    nuevaCompra.telefonoCliente = tb_telefono.Text; // Telefono del cliente Opcional
                    nuevaCompra.CedulaIdentidad = tb_cedula.Text; // Cedula cliente
                    nuevaCompra.articulosComprados = articulosCompra; // Articulos que compra
                    nuevaCompra.fechaCompra = DateTime.Today; // Fecha actual de la compra
                    nuevaCompra.totalPago = totalAPagar; // pago total en bolivares
                    nuevaCompra.totalPagoDolar = totalAPagar * referenciaDolar; // pago total en dolares
                    nuevaCompra.bancoPago = (eBancoPago)cb_bank.SelectedIndex; // banco al que hizo pago
                    nuevaCompra.tipoPago = (eTipoPago)cb_metodo.SelectedIndex; // metodo de pago
                    nuevaCompra.ReferenciaPago = tb_referenciaPago.Text; // referencia de pago, Transferencia, pago movil.

                    databaseCompras.Add(nuevaCompra);

                    MessageBox.Show(nuevaCompra.articulos);

                    Serializer.JSON_Serializer(databaseCompras, directories.comprasFile);

                    MessageBox.Show("Compra Exitosa!");

                    resetCompra();
                }
            }
        }

        private void resetCompra()
        {
            totalAPagar = 0;
            articulosCompra = new List<Articulos>();
            gridView_items.Rows.Clear();

            tb_clienteName.Text = string.Empty;
            tb_cedula.Text = string.Empty;
            tb_referenciaPago.Text = string.Empty;
            tb_telefono.Text = string.Empty;
            cb_bank.SelectedIndex = 0;
            cb_metodo.SelectedIndex = 0;
            lb_precioDolar.Text = totalAPagar.ToString() + "$";
            lb_precioBolivar.Text = (totalAPagar * referenciaDolar).ToString() + "BsS";
        }

        private void cb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((eTipoPago)cb_metodo.SelectedIndex == eTipoPago.Efectivo) {
                tb_referenciaPago.Enabled = false;
                tb_referenciaPago.BackColor = Color.Crimson;
            }
            else {
                tb_referenciaPago.Enabled = true;
                tb_referenciaPago.BackColor = Color.White;
            }
        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            form_registros formRegistros = new form_registros();
            formRegistros.Show();
        }

        private void lb_autor_Click(object sender, EventArgs e)
        {

        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            form_inventory inv = new form_inventory(this);
            inv.Show();
        }

        public void Update() { insertData(); }

        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
