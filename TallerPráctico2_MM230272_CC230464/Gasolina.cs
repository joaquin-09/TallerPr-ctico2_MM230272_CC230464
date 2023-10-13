using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPráctico2_MM230272_CC230464
{
    class Gasolina
    {
        protected double precio;
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        protected double cantGalones;
        public double CantGalones
        {
            get { return cantGalones; }
            set { cantGalones = value; }
        }

        protected double cantMaxGalones;
        public double CantMaxGalones
        {
            get { return cantMaxGalones; }
            set { cantMaxGalones = value; }
        }
    }
}
