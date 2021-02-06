using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pescaderia.Internal.objects.Productos;

namespace Pescaderia.Internal.objects.Compras
{
    [Serializable]
    public class Compra
    {
        public string nombreCliente = string.Empty;
        public string telefonoCliente = string.Empty;
        public string CedulaIdentidad = string.Empty;
        public List<Producto> articulosComprados = new List<Producto>();
        public DateTime fechaCompra = DateTime.Now;
        public double totalPago = 0;
        public double totalPagoDolar = 0;
        public string referenciaPago = string.Empty;
        public eTipoPago tipoPago = eTipoPago.Efectivo;
        public eBancoPago bancoPago = eBancoPago.BancoDeVenezuela;
        public bool pagoPendiente = false;

        public Compra(string nombreCliente, string telefonoCliente, string cedulaIdentidad, List<Producto> articulosComprados, DateTime fechaCompra, double totalPago, double totalPagoDivisas, string referenciaPago, eTipoPago tipoPago, eBancoPago bancoPago, bool pagoPendiente)
        {
            this.nombreCliente = nombreCliente;
            this.telefonoCliente = telefonoCliente;
            this.CedulaIdentidad = cedulaIdentidad;
            this.articulosComprados = articulosComprados;
            this.fechaCompra = fechaCompra;
            this.totalPago = totalPago;
            this.totalPagoDolar = totalPagoDivisas;
            this.referenciaPago = referenciaPago;
            this.tipoPago = tipoPago;
            this.bancoPago = bancoPago;
            this.pagoPendiente = pagoPendiente;
        }
    }
}
