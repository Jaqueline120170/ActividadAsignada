using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsignado.Dtos
{
    internal class ClienteDto
    {
        //ATRIBUTOS
        int idCliente;
        string nombreCliente;
        string apellidoCliente;
        string nombreId ;
        int edad ;
        int telefonoCliente ;
        string fechaAlta ;
        string fechaBaja="--------" ;
        
        //GETTERS Y SETTERS
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string NombreId { get => nombreId; set => nombreId = value; }
        public int Edad { get => edad; set => edad = value; }
        public int TelefonoCliente { get => telefonoCliente; set => telefonoCliente = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }

        //CONSTRUCTORES
        public ClienteDto(int idCliente, string nombreCliente, string apellidoCliente, string nombreId, int edad, int telefonoCliente, string fechaAlta, string fechaBaja)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.nombreId = nombreId;
            this.edad = edad;
            this.telefonoCliente = telefonoCliente;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            
        }

        public ClienteDto()
        {
        }

   
        //MÉTODO TOSTRING
        override
        public string ToString()
        {
            string clienteString = "id:"+ this.idCliente + " "+ "Nombre:" + this.nombreCliente + " "+ "Apellidos:" + this.apellidoCliente + " " +
                "Nombre id:" + this.nombreId + " "+
                "Edad de cliente:" + this.edad + " " +
                "Tlf:" + this.telefonoCliente + " " +
                "Fecha de alta:" + this.fechaAlta + " " +
                "Fecha baja:" + this.fechaBaja;
               

            return clienteString;
        } 
    }
}
