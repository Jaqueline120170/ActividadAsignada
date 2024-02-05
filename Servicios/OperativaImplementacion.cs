using EjercicioAsignado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsignado.Servicios
{   
   
    internal class OperativaImplementacion : OperativaInterfaz
    {
        /// <summary>
        /// Clase que contiene la implementación de los métodos de la interfaz CubInterfaz
        /// @author JRT - 31/01/2024
        /// </summary>


        /// <summary>
        /// Mètodo que recoge el id del cliente que se desea dar de baja para
        /// borrarlo de la lista, si el id introducido coincide con aalguno existente en la lista, se eliminará o dará de baja.
        /// @author JRT- 31/01/2024
        /// </summary>
        /// <returns>la lista modificada sin el cliente dado de baja</returns>
        public void darBajaCliente(List<ClienteDto> listaAntigua)

        {
            MenuInterfaz mi = new MenuImplementcion();
            int  buscarId = mi.pedirId();
            ClienteDto clienteABorrar = new ClienteDto();
            foreach (ClienteDto cliente in listaAntigua)
            {
                if (cliente.IdCliente.Equals(buscarId))
                {
                    cliente.FechaBaja= DateTime.Now.ToString();
                    clienteABorrar = cliente;
                    
                }
                Console.WriteLine("Fecha y hora de baja del cliente: " + cliente.FechaBaja);
            }
            
        }

        public void darAltaCliente(List<ClienteDto> listaAntigua)

        {
            listaAntigua.Add(crearCliente());

        }

        /// <summary>
        /// Mètodo que recoge los atributos o datos que conformaran a un nuevo cliente para
        /// ser añadido a la lista, en este caso es privado porque solo se harà o implementará en esta clase.
        /// @author JRT- 31/01/2024
        /// </summary>
        /// <returns>un nuevo cliente</returns>
        private ClienteDto crearCliente()
        {
            int idCliente;
            string nombreCliente;
            string apellidoCliente;
            int edad;
            int telefonoCliente;
            string fechaAlta;
            string fechaBaja="------------";
            string nombreId;
           

            Console.WriteLine("Introduzca el id: ");
            idCliente=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca nombre: ");
            nombreCliente= Console.ReadLine();
            Console.WriteLine("Introduzca apellidos: ");
            apellidoCliente=Console.ReadLine();
            nombreId = idCliente + nombreCliente;
            Console.WriteLine("Introduzca edad: ");
            edad=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca telefono: ");
            telefonoCliente=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la fecha actual: ");
            fechaAlta=Console.ReadLine();
            
            


            return new ClienteDto(idCliente, nombreCliente, apellidoCliente,nombreId, edad, telefonoCliente, fechaAlta, fechaBaja);
           
        }

        public void mostrarListaClientes(List<ClienteDto>listaAntigua)
        {
            Console.WriteLine("Lista de clientes:");
            foreach (ClienteDto cliente in listaAntigua)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

    }
}
