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
    internal class CuentaImplementacion : CuentaInterfaz
    {
        public void darAltaCuenta(List<CuentasDto> listaAntigua)

        {
            listaAntigua.Add(crearNuevaCuenta());

        }
        /// <summary>
        /// Dar de alta una cuenta bancaria y solicitar info para confirmar
        /// </summary>
        /// <returns>Nueva cuenta bancaria con la info solicitada</returns>
        private CuentasDto crearNuevaCuenta()
        {
            long idCliente;
            string numISBAN;
            string fechaAltaCuenta;
            string fechaBajaCuenta;
            string dniCliente;
            string idBanco;


            Console.WriteLine("Introduzca un id: ");
            idCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca nùmero ISBAN: ");
            numISBAN = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha actual");
            fechaAltaCuenta = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de vencimiento");
            fechaBajaCuenta = Console.ReadLine();
            Console.WriteLine("Introduzca su DNI");
            dniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el id del Banco al que pertenece");
            idBanco = Console.ReadLine();

            CuentasDto cuentaNueva = new CuentasDto(idCliente, numISBAN, fechaAltaCuenta, fechaBajaCuenta,dniCliente, idBanco);
            return cuentaNueva;
        }
    }
}
