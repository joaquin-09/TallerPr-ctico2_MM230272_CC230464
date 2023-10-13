using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPráctico2_MM230272_CC230464
{
    class Gasolina_Regular : Gasolina
    {
        public double CantidadGalonesRetirada;
        public double cantidadGalonestotal = 800;
        public double CGAR;

        public double precioR()
        {
            Precio = 3.95;
            return precio;
        }
        public double PrecioInicialR()
        {
            return precioR();
        }

        public double cantidadgalonesRR(double CantidadGalonesRetirada)
        {
            CGAR = cantidadGalonestotal - CantidadGalonesRetirada;
            return CGAR;
        }

        public double CantidadMaxGalonesR()
        {
            return cantidadGalonestotal;
        }

        private double cantidadSurtidaR;
        public double CantidadSurtidaR
        {
            get { return cantidadSurtidaR; }
            set { cantidadSurtidaR = value; }
        }
        public void ModificarPrecioR(double nuevoprecio)
        {
            Precio = nuevoprecio;
        }
        public double DolarAgalonR(double dolar)
        {
            CantidadGalonesRetirada = Precio / dolar;
            return CantidadGalonesRetirada;
        }

        public double GalonAdolarR(double Galon)
        {
            double PrecioDolar = Galon * Precio;
            return PrecioDolar;
        }
    }
}

