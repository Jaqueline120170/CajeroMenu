using CajeroMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        // definir la logica de los métodos que hay en interfaz, en este caso la logica de dar alta cliente
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            listaAntigua.Add(crearNuevoCliente());
            //CREO UN CLIENTE CON UN NUEVO METODO( crearNuevoCliente)
           
            // añadir a listaAntigua el cliente
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


            ClienteDto clienteNuevo = new ClienteDto(nombreCliente, apellidosCliente, dniCliente, fechaNacimiento, emailCliente, tlfCliente, fechaAltaCliente, idCliente );

            return clienteNuevo;
        }
    }
}
