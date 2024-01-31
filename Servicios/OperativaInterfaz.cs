using EjercicioAsignado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsignado.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Mètodo para dar de alta un nuevo elemento a la lista de  clientes que ya existen, en este caso a  lista antigua
        /// @author JRT - 31/01/2024
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaAntigua);


        /// <summary>
        /// Método para eleminar un elemento de la lista (listaAntigua) que tenemos de clientes
        /// @author JRT - 31/01/2024
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darBajaCliente(List<ClienteDto> listaAntigua);
    }
}
