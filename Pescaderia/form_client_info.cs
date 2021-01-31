using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pescaderia.Internal.objects;
using Pescaderia.Internal;
using ToolsCripto_Alexx;

namespace Pescaderia
{
    public partial class form_client_info : Form
    {
        List<Compra> compras = Serializer.JSON_Deserialize<Compra>(directories.comprasFile);
        Compra clientCompra;
        private int clientId = 0;

        //* Client data
        private string clientName;
        private string clientContact;
        private string clientCI;
        private DateTime clientCompraDate;
        private List<Articulos> clientArticles;
        private eBancoPago clientPaidBank;
        private eTipoPago clientPaidType;
        private string clientPaidRef;
        private double clientPaid;
        private double clientPaidDolar;
        //*====================================

        public form_client_info(int clientId)
        {
            this.clientCompra = compras[clientId];
            this.clientId = clientId;
            InitializeComponent();
        }

        private void getClientInfo()
        {
            clientName       = clientCompra.nombreCliente;
            clientContact    = clientCompra.telefonoCliente;
            clientCI         = clientCompra.CedulaIdentidad;
            clientCompraDate = clientCompra.fechaCompra;
            clientArticles   = clientCompra.articulosComprados;
            clientPaidBank   = clientCompra.bancoPago;
            clientPaidType   = clientCompra.tipoPago;
            clientPaidRef    = clientCompra.referenciaPago;
            clientPaid       = clientCompra.totalPago;
            clientPaidDolar  = clientCompra.totalPagoDolar;
        }

        private void setClientInfoGUI()
        {
            lb_client.Text       = clientName;
            lb_contact.Text      = clientContact;
            lb_identidad.Text    = clientCI;
            lb_fecha_compra.Text = clientCompraDate.ToString();
            lb_total.Text        = clientPaid.ToString();
            lb_total_ref.Text    = clientPaidDolar.ToString();
            lb_paid_ref.Text     = clientPaidRef;
            lb_bank.Text         = clientPaidBank.ToString();
            lb_paid_type.Text    = clientPaidType.ToString();

            //! Draw Viewer
            if(clientCompra.articulosComprados.Count > 0)
            {
                foreach (Articulos articulo in clientCompra.articulosComprados)
                {
                    viewer_articles.Rows.Add(
                        articulo.Nombre,
                        articulo.cantidad,
                        articulo.Precio,
                        (articulo.Precio * articulo.cantidad)
                    );
                }
            }
        }

        private void form_client_info_Load(object sender, EventArgs e)
        {
            getClientInfo();
            setClientInfoGUI();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
