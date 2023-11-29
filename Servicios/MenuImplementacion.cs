using CajeroMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de menú
    /// 25092023 - jrt
    /// 
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Banco CSI1"; 
                Console.WriteLine(mensaje);
        }
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("##########################");
            Console.WriteLine("0. Cerra aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Modificar");
            Console.WriteLine("4. Ver lista Clientes");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("6. Dar de alta una cuenta bancaria");
            Console.WriteLine("7. Eliminar cliente");
            Console.WriteLine("################################");
            Console.WriteLine("Selecciona una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

            return opcionIntroducida;
        }

        public string pedirDni()
        {
            Console.WriteLine("Indica el DNI del cliente");
            string dniCliente=Console.ReadLine();
            return dniCliente;
        }
        
    }
}
