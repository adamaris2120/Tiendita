using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Articulo
    {
        public double precio;

        public Articulo(double precio)
        {
            this.precio = precio;
        }

        public double Precio
        {
            get { return precio; }
        }
    }
}
