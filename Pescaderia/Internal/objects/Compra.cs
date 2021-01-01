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
        public string ReferenciaPago = string.Empty;
        public eTipoPago tipoPago = eTipoPago.Efectivo;
        public eBancoPago bancoPago = eBancoPago.BancoDeVenezuela;

        public string articulos
        {
            get
            {
                string a = string.Empty;

                for (int i = 0; i > articulosComprados.Count; i++) {
                    a = a +" " + articulosComprados[i].Nombre;
                }

                return a;
            }
        }

    }
}
