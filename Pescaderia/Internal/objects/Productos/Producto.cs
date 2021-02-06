using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pescaderia.Internal;
using Newtonsoft.Json;

namespace Pescaderia.Internal.objects.Productos
{
    [Serializable]
    public class Producto
    {
        public int id = 0;
        public string nombre;
        public TipoProducto tipoProducto;
        public double precio;
        public double cantidad;
        public float articulosStock;

        [JsonConstructor]
        public Producto() { }

        public Producto(int id, string nombre, TipoProducto tipoProducto, double precio, float articulosStock)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipoProducto = tipoProducto;
            this.precio = precio;
            this.cantidad = 0;
            this.articulosStock = articulosStock;
        }

        public Producto(int id, string nombre, TipoProducto tipoProducto, double precio, double cantidad, float articulosStock)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipoProducto = tipoProducto;
            this.precio = precio;
            this.cantidad = cantidad;
            this.articulosStock = articulosStock;
        }

    }
}
