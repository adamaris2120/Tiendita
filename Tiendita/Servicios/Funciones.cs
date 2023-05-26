using Entities;

namespace Tiendita.Servicios
{
    public class Funciones
    {


        public void Pedirdatos()
        {
			try
			{
                Cliente cliente = new Cliente();

                Console.WriteLine("Ingrese los datos del cliente:\n");
                Console.Write("Nombre: ");
                cliente.nombre = Console.ReadLine();

                Console.Write("Teléfono: ");
                cliente.telefono = Console.ReadLine();

                Console.Write("Correo electrónico: \n ");
                cliente.correo = Console.ReadLine();

                //Cliente cliente = new Cliente(nombre, telefono, correo);

                Console.WriteLine("Datos del cliente:\n");
                cliente.ImprimirInformacion();


            }
			catch (Exception ex)
			{

				throw new Exception ("Succedui un eeror"+ex.Message);
			}


        }

        public double SumarArt ()
        {
            try
            {
                Console.WriteLine("Ingrese los datos de los artículos:");

                double totalCompra = 0;

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Artículo {0}:", i);
                    Console.Write("Precio: $");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    totalCompra += precio;
                }

                Console.WriteLine("Detalle de la compra:");
                Console.WriteLine("Total de la compra: ${0}", totalCompra);

                return totalCompra;

            }

            catch (Exception ex)
            {

                throw new Exception("Succedui un eeror" + ex.Message);
            }



        }
        public void AgregarDescuentos()
        {
            try
            {
                double totalCompra = 0;

                double descuento = Math.Floor(totalCompra / 5000) * 0.10 * totalCompra;

                if (totalCompra >= 8000 && totalCompra < 10000)
                {
                    Console.WriteLine("Descuento aplicado: ${0}", descuento);
                    Console.WriteLine("Total con descuento: ${0}", totalCompra - descuento);
                    Console.WriteLine("Monto mensual (3 meses sin interés): ${0}", (totalCompra - descuento) / 3);
                }
                else if (totalCompra >= 10000)
                {
                    Console.WriteLine("Descuento aplicado: ${0}", descuento);
                    Console.WriteLine("Total con descuento: ${0}", totalCompra - descuento);
                    Console.WriteLine("Seleccione el plazo para el pago:");
                    Console.WriteLine("1. 6 meses sin interés");
                    Console.WriteLine("2. 12 meses sin interés");
                    Console.Write("Opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    double montoMensual = 0;

                    switch (opcion)
                    {
                        case 1:
                            montoMensual = (totalCompra - descuento) / 6;
                            break;
                        case 2:
                            montoMensual = (totalCompra - descuento) / 12;
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }

                    Console.WriteLine("Monto mensual: ${0}", montoMensual);
                }
                else
                {
                    Console.WriteLine("No se aplicaron descuentos.");
                }



            }
            catch (Exception ex)
            {

                throw new Exception("Succedui un eeror" + ex.Message);
            }
        }
    }
}
