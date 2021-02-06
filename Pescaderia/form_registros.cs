using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Pescaderia.Internal.objects;
using Pescaderia.Internal.objects.Compras;
using Pescaderia.Internal;
using ToolsCripto_Alexx;

namespace Pescaderia
{
    public partial class form_registros : Form, Observable
    {
        List<Compra> comprasDatabase = Serializer.JSON_Deserialize<Compra>(directories.comprasFile);
        private int selectedClientIndex = 0;

        public form_registros()
        {
            InitializeComponent();
        }

        private void SelectClientCell(object sender, DataGridViewCellEventArgs e)
        {
            if (!btn_view_details.Enabled)
                btn_view_details.Enabled = true;

            selectedClientIndex = viewer_clients.CurrentCell.RowIndex;
        }

        private void OpenClientDetailsForm(object sender, EventArgs e)
        {
            form_client_info formClientInfo = new form_client_info(selectedClientIndex, this);
            formClientInfo.Show();
        }

        private void form_registros_Load(object sender, EventArgs e)
        {
            SetViewerOptionsMenu();
            UpdateRegistersViewer(comprasDatabase);
        }

        private void SetViewerOptionsMenu()
        {
            options_view.DataSource = Enum.GetValues(typeof(OptionsViewer));
        }

        private void SetViewerOptions(object sender, EventArgs e)
        {
            if((OptionsViewer)options_view.SelectedIndex == OptionsViewer.Fecha)
            {
                dateTimePurchase.Enabled = true;
                SearchRegisterByDateTime(comprasDatabase, dateTimePurchase.Value);
            }
            if((OptionsViewer)options_view.SelectedIndex == OptionsViewer.Todos)
            {
                dateTimePurchase.Enabled = false;
                UpdateRegistersViewer(comprasDatabase);
            }
        }

        private void SearchRegisterByDateTime(List<Compra> purchases, DateTime purchaseDatetime)
        {
            ClearRegistrersViewer();

            if(purchases.Count > 0)
            {
                foreach (Compra OrdenedPurchases in purchases.Where(purchase => purchase.fechaCompra.ToString("dd/MM/yyyy") == purchaseDatetime.ToString("dd/MM/yyyy")))
                {
                    AddIntoViewerValues(
                        OrdenedPurchases.nombreCliente,
                        OrdenedPurchases.totalPagoDolar,
                        OrdenedPurchases.totalPago,
                        OrdenedPurchases.referenciaPago,
                        OrdenedPurchases.bancoPago,
                        OrdenedPurchases.tipoPago,
                        OrdenedPurchases.fechaCompra,
                        OrdenedPurchases.pagoPendiente
                    );
                }
            }
        }

        private void UpdateRegistersViewer(List<Compra> Purchases)
        {
            ClearRegistrersViewer();

            if (Purchases.Count > 0)
            {
                foreach (Compra compra in Purchases)
                {
                    AddIntoViewerValues(
                        compra.nombreCliente,
                        compra.totalPagoDolar,
                        compra.totalPago,
                        compra.referenciaPago,
                        compra.bancoPago,
                        compra.tipoPago,
                        compra.fechaCompra,
                        compra.pagoPendiente
                    ); ;
                }
            }
        }

        private void AddIntoViewerValues(string nombreCliente, double totalPagoDivisa, double totalPagoBolivares, string referenciaPago, eBancoPago banco, eTipoPago tipoPago, DateTime fecha, bool pagoPendiente)
        {
            viewer_clients.Rows.Add(
                nombreCliente,
                totalPagoDivisa,
                totalPagoBolivares,
                referenciaPago,
                banco,
                tipoPago,
                fecha.ToString("dd/MM/yyyy"),
                (pagoPendiente) ? "Pendiente" : "Pagado"
            );
        }


        private void ClearRegistrersViewer()
        {
            if (viewer_clients.Rows.Count > 0)
                viewer_clients.Rows.Clear();
        }

        private void ChooseDateTimeToSearch(object sender, EventArgs e)
        {
            SearchRegisterByDateTime(comprasDatabase, dateTimePurchase.Value);
        }

        public void Update()
        {
            comprasDatabase = Serializer.JSON_Deserialize<Compra>(directories.comprasFile);
            if ((OptionsViewer)options_view.SelectedIndex == OptionsViewer.Fecha)
            {
                SearchRegisterByDateTime(comprasDatabase, dateTimePurchase.Value);
            }
            if ((OptionsViewer)options_view.SelectedIndex == OptionsViewer.Todos)
            {
                UpdateRegistersViewer(comprasDatabase);
            }
        }
    }
}
