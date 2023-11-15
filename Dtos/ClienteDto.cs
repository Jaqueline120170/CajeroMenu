using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Dtos
{
    internal class ClienteDto
    {
        //1. ATRIBUTOS Y CARACTERISTICAS
        //son private por defecto

        long idCliente;

        string nombreCliente;

        string apellidosCliente;

        string dniCliente;

        string fechaNacimientoCliente;

        string emailCliente;

        int tlfCliente;

        string fechaAltaCliente;

        string fechaBajaCliente;

        //2. GETTERS Y SETTERS (metodos de acceso get-lectura; set-escritura)
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
        public string FechaBajaCliente { get => fechaBajaCliente; set => fechaBajaCliente = value; }


        //3. Se genera el constructor que viene por defecto
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fechaNacimientoCliente, string emailCliente, int tlfCliente, string fechaAltaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fechaNacimientoCliente = fechaNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fechaAltaCliente = fechaAltaCliente;
            
        }

        public ClienteDto()
        {

        }
        
        //TOSTRING , dar la version tipo texto del objeto
        override
        public string ToString()
        {
            string clienteString = "Nombre: " + this.nombreCliente +
                "Apellidos: " + this.apellidosCliente +
                 "Dni: " + this.dniCliente +
                 "Fecha Nacimiento: " + this.fechaNacimientoCliente +
                 "Email: " + this.emailCliente +
                 "Tlf: " + this.tlfCliente +
                 "Fecha de alta : " + this.fechaAltaCliente +
                 "Fecha baja: " + this.fechaBajaCliente;
            return clienteString;   
                 

        }
    }
}
