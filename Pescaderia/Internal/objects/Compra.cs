using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pescaderia.Internal.objects
{
    [Serializable]
    public class Compra
    {
        public string nombreCliente = string.Empty;
        public string telefonoCliente = string.Empty;
        public string CedulaIdentidad = string.Empty;
        public List<Articulos> articulosComprados = new List<Articulos>();
        public DateTime fechaCompra = DateTime.Now;
        public double totalPago = 0;
        public double totalPagoDolar = 0;
        public string referenciaPago = string.Empty;
        public eTipoPago tipoPago = eTipoPago.Efectivo;
        public eBancoPago bancoPago = eBancoPago.BancoDeVenezuela;

        public Compra(string nombreCliente, string telefonoCliente, string cedulaIdentidad, List<Articulos> articulosComprados, DateTime fechaCompra, double totalPago, double totalPagoDivisas, string referenciaPago, eTipoPago tipoPago, eBancoPago bancoPago)
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

        }
    }
}
