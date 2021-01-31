using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pescaderia.Internal
{
    class CalcularDivisas
    {
        private double _precioDivisa = 0;
        public double precioDivisa
        {
            get { return _precioDivisa; }
            set { _precioDivisa = value; }
        }


        public CalcularDivisas(double precioDivisa) {
            this._precioDivisa = precioDivisa;
        }

        public double Calcular(double precioPago)
        {
            return precioPago * this._precioDivisa;
        }
    }
}
