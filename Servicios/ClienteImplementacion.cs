using CajeroMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de menú
    /// 21112023 - jrt
    /// 
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {
        ClienteInterfaz ci = new ClienteImplementacion();
        MenuInterfaz mi = new MenuImplementacion();
        //las coloco fuera porque las voy a usar en varios métodos
        public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniBuscar= mi.pedirDni();

            //Borrar por objeto especifico se elimina por referencia de memoria, no por valores de los campos
            ClienteDto clienteABorrar = new ClienteDto();
            foreach (ClienteDto cliente in listaAntigua)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    clienteABorrar = cliente;
                    break;
                }
            }

            //Borrar por  posición
            int i;
            bool aBorrar = false;
            for ( i =0; i<listaAntigua.Count(); i++)
            {
                if (listaAntigua[i] .DniCliente.Equals(dniBuscar))
                {
                    aBorrar=true;
                    break;
                }
            if(aBorrar)
                {
                    listaAntigua.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine("El cliente no existe");
                }
            }

        }

        // definir la logica de los métodos que hay en interfaz, en este caso la logica de dar alta cliente
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            listaAntigua.Add(crearNuevoCliente());
            //CREO UN CLIENTE CON UN NUEVO METODO( crearNuevoCliente)
           
            // añadir a listaAntigua el cliente
        }

        public void modificarCuenta(List<ClienteDto> listaAntigua)

        {
            string dniBuscar = mi.pedirDni();
            int i;
            bool aModificar = false;
            foreach (ClienteDto cliente in listaAntigua)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    int campoIntroducido = mostrarCamposYseleccion();
                    bool control = true;
                    while (control)
                    {

                    }
                }
                if (aModificar)
                {
                    int campoIntroducido;
                    Console.WriteLine(mi.mostrarCamposYSeleccion);
                    Console.WriteLine("Seleccione el campo que desee modificar");

                    return campoIntroducido;
                }
                else
                {
                    Console.WriteLine("El cliente no existe");
                }
            }
        }

        private ClienteDto crearNuevoCliente()
        {
            string nombreCliente;
            string apellidosCliente;
            string dniCliente;
            string fechaNacimiento;
            string emailCliente;
            int tlfCliente;
            string fechaAltaCliente;
            long idCliente;
            

            
            Console.WriteLine("Introduzca su nombre");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca sus Apellidos");
            apellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su DNI");
            dniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su fecha de nacimiento");
            fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Introduzca su email");
            emailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su número de telefono");
            tlfCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la fecha actual");
            fechaAltaCliente = Console.ReadLine();
            Console.WriteLine("Introduzca un id: ");
            idCliente = Convert.ToInt64(Console.ReadLine());
            


            ClienteDto clienteNuevo = new ClienteDto(nombreCliente, apellidosCliente, dniCliente, fechaNacimiento, emailCliente, tlfCliente, fechaAltaCliente, idCliente);

            return clienteNuevo;
        }
        private int mostrarCamposYseleccion()
        {
            int campoIntroducido;

            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Apellidos");
            Console.WriteLine("3. Telefono");
            Console.WriteLine("4. Fecha Nacimiento");

            campoIntroducido = Console.ReadKey(true).KeyChar - ('0');
            return campoIntroducido;
        }

        private bool modificarCampoCliente(ClienteDto clienteAModificar, int campoIntroducido)
        {
            bool abrirMenu = true;
            switch (campoIntroducido)
            {
                case 0:
                case 1:
                    Console.WriteLine("[INFO] - Escriba nuevo nombre");
                    cliente.NombreCliente = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("[INFO] - Escriba nuevo Apellido");
                    cliente.Apellido = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("[INFO] - Escriba nuevo telefono");
                    break;
                case 4:
                    Console.WriteLine("[INFO] - Escriba nuevo email");
                    break;
                default:
                    break;
            }
        }


            
        
    }
}
