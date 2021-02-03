namespace Pescaderia.Internal
{
    class CalculateReference
    {
        private double _referencePrice = 0;
        public double precioDivisa
        {
            get { return _referencePrice; }
            set { _referencePrice = value; }
        }

        public CalculateReference(double referensePrice) {
            this._referencePrice = referensePrice;
        }

        public double Calcular(double referencePrice)
        {
            return referencePrice * _referencePrice;
        }
        public override string ToString()
        {
            return "El precio de la divisa es: " + _referencePrice.ToString();
        }
    }
}
