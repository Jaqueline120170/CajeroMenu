using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Dtos
{
    /// <summary>
    /// Entidad de las ccc, representa el ente cuenta bancaria
    /// </summary>
    /// <author>jrt - 23112023</author>
    internal class CuentasDto
    {
        long idCliente;
        string numISBAN ="aaaaa";
        string fechaAltaCuenta="9999/12/31";
        string fechaBajaCuenta= "9999/12/31";
        string dniCliente="aaaaa";
        string idBanco = "CSI1SSXX.";

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NumISBAN { get => numISBAN; set => numISBAN = value; }
        public string FechaAltaCuenta { get => fechaAltaCuenta; set => fechaAltaCuenta = value; }
        public string FechaBajaCuenta { get => fechaBajaCuenta; set => fechaBajaCuenta = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string IdBanco { get => idBanco; set => idBanco = value; }

        public CuentasDto()
        {

        }

        public CuentasDto(long idCliente, string numISBAN, string fechaAltaCuenta, string fechaBajaCuenta, string dniCliente, string idBanco)
        {
            this.idCliente = idCliente;
            this.numISBAN = numISBAN;
            this.fechaAltaCuenta = fechaAltaCuenta;
            this.fechaBajaCuenta = fechaBajaCuenta;
            this.dniCliente = dniCliente;
            this.idBanco = idBanco;
        }

        override
        public string ToString()
        {
            string cuentaString = "idCliente:" + this.idCliente +
             "Numero ISBAN: " + this.numISBAN +
             "Fecha de alta cuenta: " + this.fechaAltaCuenta +
             "Fecha de baja cuenta: " + this.fechaBajaCuenta +
             "DNI  de cliente: " + this.dniCliente +
             "idBanco: " + this.idBanco;
            

            return cuentaString;

        }
    }
}
