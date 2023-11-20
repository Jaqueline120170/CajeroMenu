using CajeroMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    internal interface CuentaInterfaz
    {
        public void darAltaCuenta(List<CuentasDto> listaAntigua);
    }

}
