
using Entities;


using System;
using Tiendita.Servicios;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a nuestra TIENDITA MAJO");
        

        Funciones funciones = new Funciones();
        funciones.Pedirdatos();
        funciones.SumarArt();
        funciones.AgregarDescuentos();
       
       
 


        
        
    }
}