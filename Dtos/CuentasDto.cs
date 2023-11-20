﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Dtos
{
    internal class CuentasDto
    {
        long idCliente;
        string numISBAN;
        string fechaAltaCuenta;
        string fechaBajaCuenta;
        string dniCliente;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NumISBAN { get => numISBAN; set => numISBAN = value; }
        public string FechaAltaCuenta { get => fechaAltaCuenta; set => fechaAltaCuenta = value; }
        public string FechaBajaCuenta { get => fechaBajaCuenta; set => fechaBajaCuenta = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }

        public CuentasDto()
        {

        }

        public CuentasDto(long idCliente, string numISBAN, string fechaAltaCuenta, string fechaBajaCuenta, string dniCliente)
        {
            this.idCliente = idCliente;
            this.numISBAN = numISBAN;
            this.fechaAltaCuenta = fechaAltaCuenta;
            this.fechaBajaCuenta = fechaBajaCuenta;
            this.dniCliente = dniCliente;
        }

        override
        public string ToString()
        {
            string cuentaString = "idCliente:" + this.idCliente +
             "Numero ISBAN: " + this.numISBAN +
             "Fecha de alta cuenta: " + this.fechaAltaCuenta +
             "Fecha de baja cuenta: " + this.fechaBajaCuenta +
             "DNI  de cliente: " + this.dniCliente;
            return cuentaString;

        }
    }
}