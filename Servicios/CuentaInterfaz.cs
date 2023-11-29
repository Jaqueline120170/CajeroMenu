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
    internal interface CuentaInterfaz
    {
        /// <summary>
        /// Dar de alta una nueva cuenta bancaria asociada a un cliente
        /// </summary>
        /// <author>jrt 27/11/2023</author>
        /// <param name="listaAntigua">lista de cuentas existentes</param>
        public void darAltaCuenta(List<CuentasDto> listaAntigua);

        /// <summary>
        /// Método que lleva a cabo la recogida de datos para dar de alta a un cliente
        /// y los añade a la lista CuentasDto y los guarda en listaAntigua
        /// 21112023 - jrt
        /// </summary>
        /// <returns>una linea de texto con los datos introducidos</returns>
    }

}
