using CajeroMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    internal class CuentaImplementacion : CuentaInterfaz
    {
        public void darAltaCuenta(List<CuentasDto> listaAntigua)

        {
            listaAntigua.Add(crearNuevaCuenta());

        }

        private CuentasDto crearNuevaCuenta()
        {
            long idCliente;
            string numISBAN;
            string fechaAltaCuenta;
            string fechaBajaCuenta;
            string dniCliente;

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

            CuentasDto cuentaNueva = new CuentasDto(idCliente, numISBAN, fechaAltaCuenta, fechaBajaCuenta,dniCliente);
            return cuentaNueva;
        }
    }
}
