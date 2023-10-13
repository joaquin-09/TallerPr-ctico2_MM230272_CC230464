using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPráctico2_MM230272_CC230464
{
    class Diésel : Gasolina
    {
        public double CantidadGalonesRetirada;
        public double cantidadGalonestotal = 800;
        public double CGAD;

        public double cantidadGalonesMaxD()
        {
            return cantidadGalonestotal;
        }
        public double precioD()
        {
            Precio = 4.25;
            return precio;
        }
        public double PrecioInicialD()
        {
            return precioD();
        }

        public double cantidadgalonesRD(double CantidadGalonesRetirada)
        {
            CGAD = cantidadGalonestotal - CantidadGalonesRetirada;
            return CGAD;
        }

        public double CantidadMaxGalonesD()
        {
            return cantidadGalonestotal;
        }

        private double cantidadSurtidaD;
        public double CantidadSurtidaD
        {
            get { return cantidadSurtidaD; }
            set { cantidadSurtidaD = value; }
        }

        public double DolarAgalonD(double dolar)
        {
            CantidadGalonesRetirada = Precio / dolar;
            return CantidadGalonesRetirada;
        }
        public void ModificarPrecioD(double nuevoprecio)
        {
            Precio = nuevoprecio;
        }
        public double GalonAdolarD(double Galon)
        {
            double PrecioDolar = Galon * Precio;
            return PrecioDolar;
        }
    }
}
