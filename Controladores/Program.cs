using CajeroMenu.Dtos;
using CajeroMenu.Servicios;

namespace CajeroMenu.Controladores
{
/// <summary>
/// Clase principal de la aplicación
/// 25092023 - jrt
/// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada de la aplicación
        /// 25092023 - jrt
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentasDto> listaCuentas = new List<CuentasDto>();
            MenuInterfaz mi = new MenuImplementacion();
            mi.mostrarMensajeBienvenida();

            ClienteInterfaz ci = new ClienteImplementacion();
            CuentaInterfaz cui = new CuentaImplementacion();

            //variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;

            //desde la primera iteración debe cumplirse la condición
            while(!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();

                

                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta caso 1");
                        ci.darAltaCliente(listaClientes);
                        //el valor de la referencia nde dar alta clientes pasará a lista antigua
                        foreach (ClienteDto clienteNuevo in listaClientes)
                        {
                            Console.WriteLine(clienteNuevo.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta casi 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5");
                        break;
                    case 6:
                        Console.WriteLine("[INFO] - Se ejecuta caso 6");
                        cui.darAltaCuenta(listaCuentas);
                        foreach(CuentasDto cuentaNueva in listaCuentas)
                        {
                            Console.WriteLine(cuentaNueva.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna");
                        break;

                   
                          
               }

            }
         

        }
    }

}
