using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Pescaderia.Internal;
using Pescaderia.Internal.objects.Compras;
using Pescaderia.Internal.objects.Productos;
using ToolsCripto_Alexx;

namespace Pescaderia
{
    public partial class form_client_info : Form, Observer
    {
        List<Compra> compras = Serializer.JSON_Deserialize<Compra>(directories.comprasFile);
        Compra clientCompra;
        private int clientId = 0;
        Observable formRegisters;
        //* Client data
        private string clientName;
        private string clientContact;
        private string clientCI;
        private DateTime clientCompraDate;
        private List<Producto> clientArticles;
        private eBancoPago clientPaidBank;
        private eTipoPago clientPaidType;
        private string clientPaidRef;
        private double clientPaid;
        private double clientPaidDolar;
        private bool clientPagoPendiente;
        //*====================================

        public form_client_info(int clientId, Observable fatherForm)
        {
            formRegisters = fatherForm;
            this.clientCompra = compras[clientId];
            this.clientId = clientId;
            InitializeComponent();
        }

        private void getClientInfo()
        {
            clientName          = clientCompra.nombreCliente;
            clientContact       = clientCompra.telefonoCliente;
            clientCI            = clientCompra.CedulaIdentidad;
            clientCompraDate    = clientCompra.fechaCompra;
            clientArticles      = clientCompra.articulosComprados;
            clientPaidBank      = clientCompra.bancoPago;
            clientPaidType      = clientCompra.tipoPago;
            clientPaidRef       = clientCompra.referenciaPago;
            clientPaid          = clientCompra.totalPago;
            clientPaidDolar     = clientCompra.totalPagoDolar;
            clientPagoPendiente = clientCompra.pagoPendiente;
        }

        private void setClientInfoGUI()
        {
            lb_client.Text              = clientName;
            lb_contact.Text             = clientContact;
            lb_identidad.Text           = clientCI;
            lb_fecha_compra.Text        = clientCompraDate.ToString("dd/MM/yyyy");
            lb_total.Text               = clientPaid.ToString();
            lb_total_ref.Text           = clientPaidDolar.ToString();
            lb_paid_ref.Text            = clientPaidRef;
            lb_bank.Text                = clientPaidBank.ToString();
            lb_paid_type.Text           = clientPaidType.ToString();
            check_pagoPendiente.Checked = clientCompra.pagoPendiente;

            if (clientCompra.pagoPendiente)
            {
                check_pagoPendiente.Text = "Pendiente";
                check_pagoPendiente.ForeColor = Color.Crimson;
            }
            else
            {
                check_pagoPendiente.Text = "Pagado";
                check_pagoPendiente.ForeColor = Color.LimeGreen;
            }

            //! Draw Viewer
            if (clientCompra.articulosComprados.Count > 0)
            {
                foreach (Producto articulo in clientCompra.articulosComprados)
                {
                    viewer_articles.Rows.Add(
                        articulo.nombre,
                        articulo.cantidad,
                        articulo.precio,
                        (articulo.precio * articulo.cantidad)
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

        private void ChangePaidState(object sender, EventArgs e)
        {
            if (check_pagoPendiente.Checked)
            {
                check_pagoPendiente.Text = "Pendiente";
                check_pagoPendiente.ForeColor = Color.Crimson;
                NotifyChanges();
            }
            else
            {
                check_pagoPendiente.Text = "Pagado";
                check_pagoPendiente.ForeColor = Color.LimeGreen;
                NotifyChanges();
            }
        }

        public void NotifyChanges()
        {
            compras[clientId].pagoPendiente = check_pagoPendiente.Checked;
            Serializer.JSON_Serializer<Compra>(compras, directories.comprasFile);
            formRegisters.Update();
        }
    }
}
