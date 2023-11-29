using CajeroMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos con la funcionalidad menú
    /// 21112023 - jrt
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero. 
        /// 21112023 - jrt
        /// </summary>
        // metodo dar alta cliente, no devuelve nada porque es un objeto
        public void darAltaCliente(List<ClienteDto> listaAntigua);


        /// <summary>
        /// Método que lleva a cabo la recogida de datos para dar de alta a un cliente
        /// y los añade a la lista ClienteDto y los guarda en listaAntigua
        /// 21112023 - jrt
        /// </summary>
        /// <returns>una linea de texto con los datos introducidos</returns>
        /// 

        public void borrarCliente(List<ClienteDto> listaAntigua);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void modificarCuenta(List<ClienteDto> listaAntigua);
        



    }
}
