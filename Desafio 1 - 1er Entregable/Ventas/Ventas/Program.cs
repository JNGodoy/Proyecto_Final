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
                Console.WriteLine("Usuario correcto \n Bienvenido");
            
            }
            else 
            {
                Console.WriteLine("Usuario Incorrecto");
            }
            usuarioHandler.GetUsuarios(); 

            ProductoHandler productoHandler = new ProductoHandler();
            productoHandler.GetProductos();

            ProductoVendidoHandler productoVendidoHandler = new ProductoVendidoHandler();
            productoVendidoHandler.GetProductosVendidos();

            VentaHandler ventaHandler = new VentaHandler();
            ventaHandler.GetVenta();


        }
    }
}