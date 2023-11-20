using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("6. Dar de alta una cuenta bancaria");
            Console.WriteLine("################################");
            Console.WriteLine("Selecciona una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

            return opcionIntroducida;
        }
    }
}
