using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pescaderia.Internal.objects
{
    [Serializable]
    public class Articulos
    {
        public Articulos() { }
        public Articulos(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public int id = 0;
        public string Nombre;
        public double Precio;
        public double cantidad;
        public float articulosStock;
    }
}
