﻿using CajeroMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    internal interface ClienteInterfaz
    {
        // metodo dar alta cliente, no devuelve nada porque es un objeto
        public void darAltaCliente(List<ClienteDto> listaAntigua);

    



    }
}
