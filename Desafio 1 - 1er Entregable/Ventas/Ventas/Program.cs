using Ventas.ADO.NET;
using System.Collections.Generic;

namespace Ventas
{
    public class ProgramaVentas
    {
        static void Main(string[] args)
        {

            string Usuario = "";
            string Clave = "";

            Console.WriteLine("Ingrese el usuario");
            Usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la clave");
            Clave = Console.ReadLine();

            UsuarioHandler usuarioHandler = new UsuarioHandler();

            if (usuarioHandler.Login(Usuario, Clave) == "OK")
            {
                Console.WriteLine("Usuario correcto \nBienvenido");            
            }
            else 
            {
                Console.WriteLine("Usuario Incorrecto");
            }
            usuarioHandler.GetUsuarios(); 

            ProductoHandler productoHandler = new ProductoHandler();
            productoHandler.GetProductos();

            Console.WriteLine("Los productos son:");
            foreach (var product in productoHandler.GetTodasLasDescripcionesConDataReader())
            {
              
                Console.WriteLine(product);
            }

            ProductoVendidoHandler productoVendidoHandler = new ProductoVendidoHandler();
            productoVendidoHandler.GetProductosVendidos();

            VentaHandler ventaHandler = new VentaHandler();
            ventaHandler.GetVenta();


        }
    }
}