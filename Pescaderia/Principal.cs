using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Pescaderia.Internal;
using Pescaderia.Internal.objects.Compras;
using Pescaderia.Internal.objects.Productos;
using ToolsCripto_Alexx;
using System.IO;

namespace Pescaderia
{
    public partial class Inicio_Form : Form, Observable
    {
        //! Bases de datos locales
        List<Compra> databaseCompras = Serializer.JSON_Deserialize<Compra>(directories.comprasFile);
        List<Producto> databaseArticulos = Serializer.JSON_Deserialize<Producto>(directories.productsFile);
        List<Producto> articulosCompra = new List<Producto>();

        //! Pago y Referencia del dolar
        private double totalAPagar = 0;
        private CalculateReference calculoDivisa = new CalculateReference(0);

        //* variables para mover la ventana
        #region window_variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        
        #endregion

        public Inicio_Form()
        {
            InitializeComponent();
            InsertDataInGUI();

            //* Verify if directory exist
            if (!Directory.Exists(directories.comprasFolder))
                Directory.CreateDirectory(directories.comprasFolder);        
        }

        //! Windows Controls
        #region controls
        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OpenRegistersFrom(object sender, EventArgs e)
        {
            form_registros formRegistros = new form_registros();
            formRegistros.Show();
        }

        private void OpenInventoryForm(object sender, EventArgs e)
        {
            form_inventory inv = new form_inventory(this);
            inv.Show();
        }

        //* Mover ventana
        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //! Inserta los datos dentro de los campos
        private void InsertDataInGUI()
        {
            if(cb_articulos.Items.Count > 0)
            {
                databaseArticulos = Serializer.JSON_Deserialize<Producto>(directories.productsFile);
                cb_articulos.Items.Clear();
            }

            foreach (Producto articulo in databaseArticulos){
                cb_articulos.Items.Add(articulo.nombre);
            }

            cb_metodo.DataSource = Enum.GetNames(typeof(eTipoPago));
            cb_bank.DataSource = Enum.GetNames(typeof(eBancoPago));
        }

        private void SetReferencePrice(object sender, EventArgs e)
        {
            double precioDivisaHoy = (double)numeric_dolar_today.Value;
            calculoDivisa.precioDivisa = precioDivisaHoy;
        }

        private void UpdateLabels()
        {
            lb_precioDolar.Text = totalAPagar.ToString() + " $";
            lb_precioBolivar.Text = calculoDivisa.Calcular(totalAPagar).ToString() + " BsS";
        }

        #endregion

        private void AddArticleToPurchase(object sender, EventArgs e)
        {
            if (num_articulosCantidad.Value > 0)
            {
                int itemSelected = cb_articulos.SelectedIndex;
                double precioTotal = databaseArticulos[itemSelected].precio * (double)num_articulosCantidad.Value;
                totalAPagar += precioTotal;

                UpdateLabels();

                gridView_items.Rows.Add(
                    databaseArticulos[itemSelected].nombre,
                    (double)num_articulosCantidad.Value,
                    databaseArticulos[itemSelected].precio.ToString() + "$",
                    precioTotal + "$",
                    string.Empty
                );
                databaseArticulos[itemSelected].cantidad = (double)num_articulosCantidad.Value;
                articulosCompra.Add(databaseArticulos[itemSelected]);

            }
        }

        // Registrar pago
        private void RegisterPurchase(object sender, EventArgs e)
        {
            if(numeric_dolar_today.Value != 0)
            {
                if (tb_clienteName.Text != string.Empty)
                {
                    if (articulosCompra.Count > 0)
                    {
                        string cliente = tb_clienteName.Text; // Nombre cliente
                        string telefonoCliente = tb_telefono.Text; // Telefono del cliente Opcional
                        string cedulaCliente = tb_cedula.Text; // Cedula cliente
                        DateTime fechaCompra = DateTime.Today; // Fecha actual de la compra
                        double totalPago = totalAPagar; // pago total en bolivares
                        double totalPagoDolar = calculoDivisa.Calcular(totalAPagar); // pago total en dolares
                        eBancoPago bancoPago = (eBancoPago)cb_bank.SelectedIndex; // banco al que hizo pago
                        eTipoPago tipoPago = (eTipoPago)cb_metodo.SelectedIndex; // metodo de pago
                        string ReferenciaPago = tb_referenciaPago.Text; // referencia de pago, Transferencia, pago movil.
                        bool pagoPendiente = pagoPendienteCheck.Checked;
                        // Registrar nueva compra
                        Compra nuevaCompra = new Compra(
                            cliente,
                            telefonoCliente,
                            cedulaCliente,
                            articulosCompra,
                            fechaCompra,
                            totalPago,
                            totalPagoDolar,
                            ReferenciaPago,
                            tipoPago,
                            bancoPago,
                            pagoPendiente
                        );

                        databaseCompras.Add(nuevaCompra);

                        Serializer.JSON_Serializer(databaseCompras, directories.comprasFile);

                        MessageBox.Show("Compra Exitosa!");
                        ResetPurchaseFields();
                    }
                    else { MessageBox.Show("No hay articulos para la compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("No se ha establecido un nombre de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("No se ha establecido un precio del dolar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void ResetPurchaseFields()
        {
            totalAPagar = 0;
            articulosCompra = new List<Producto>();
            gridView_items.Rows.Clear();

            tb_clienteName.Text = string.Empty;
            tb_cedula.Text = string.Empty;
            tb_referenciaPago.Text = string.Empty;
            tb_telefono.Text = string.Empty;
            cb_bank.SelectedIndex = 0;
            cb_metodo.SelectedIndex = 0;
            lb_precioDolar.Text = totalAPagar.ToString() + "$";
            lb_precioBolivar.Text = calculoDivisa.Calcular(totalAPagar) + "BsS";
        }

        private void SelectPaidMethod(object sender, EventArgs e)
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

        //! Update GUI When this function is called by other form
        public new void Update() {
            databaseArticulos = Serializer.JSON_Deserialize<Producto>(directories.productsFile);
            InsertDataInGUI(); 
        }

        private void DeleteSelectedArticlePurchase(object sender, EventArgs e)
        {
            int selectedArticleIndex = gridView_items.CurrentCell.RowIndex;
            DialogResult Result = MessageBox.Show("Estas seguro que quieres eliminar el articulo seleccionado?", "Advertencia", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                totalAPagar -= articulosCompra[selectedArticleIndex].precio * articulosCompra[selectedArticleIndex].cantidad;
                UpdateLabels();
                articulosCompra.RemoveAt(selectedArticleIndex);
                gridView_items.Rows.RemoveAt(selectedArticleIndex);
            }
        }

        private void Inicio_Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
