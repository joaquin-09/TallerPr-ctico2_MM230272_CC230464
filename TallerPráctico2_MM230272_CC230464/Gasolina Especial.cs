using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPráctico2_MM230272_CC230464
{
    class Gasolina_Especial : Gasolina
    {
        public double CantidadGalonesRetirada;
        public double cantidadGalonestotal = 600;
        public double CGAE;
        public double nuevoprecio;
        public double precioE()
        {
            Precio = 4.45;
            return precio;
        }

        public double cantidadgalonesRE(double CantidadGalonesRetirada)
        {
            CGAE = cantidadGalonestotal - CantidadGalonesRetirada;
            return CGAE;
        }
        private double cantidadSurtidaE;
        public double CantidadSurtidaE
        {
            get { return cantidadSurtidaE; }
            set { cantidadSurtidaE = value; }
        }

        public double PrecioInicialE()
        {
            return precioE();
        }
        public void ModificarPrecioE(double nuevoprecio)
        {
            Precio = nuevoprecio;
        }
        public double DolarAgalonE(double dolar)
        {
            CantidadGalonesRetirada = Precio / dolar;
            return CantidadGalonesRetirada;
        }

        public double GalonAdolarE(double Galon)
        {
            double PrecioDolar = Galon * Precio;
            return PrecioDolar;
        }
    }
}
