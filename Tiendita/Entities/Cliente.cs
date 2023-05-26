using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }


        public void ImprimirInformacion()
        {
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Teléfono: {0}", telefono);
            Console.WriteLine("Correo electrónico: {0}", correo);
        }
    }
}
