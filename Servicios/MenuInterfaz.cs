using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos con la funcionalidad menú
    /// 25092023 - jrt
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero. 
        /// 25092023 - jrt
        /// </summary>
       public void mostrarMensajeBienvenida();

        /// <summary>
        /// Método que muestra el menú y recoje la selección del usuario
        /// 26092023 - jrt
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
