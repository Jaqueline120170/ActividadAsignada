using EjercicioAsignado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsignado.Servicios
{
    /// <summary>
    /// Interfaz que contiene la relaciòn de metodos con la funcionalidad del menú
    /// @author JRT - 31/01/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú y recoge la opción introducida por el usuario
        /// @author JRT 31/01/2024
        /// </summary>
        /// <returns>un tipo int que contendrà la opción que seleccione el usuario</returns>
        public int mostraMenuYSeleccion();
        /// <summary>
        /// Método para solcitar al usuario el id del cliente , nos sirve para identificarlo o hacer match
        /// con los id's que contiene la lista y posteriormente hacer algunas modificaciones a la lista 
        /// en este caso , poder dar de baja un cliente.
        /// @author JRT - 31/01/2024
        /// </summary>
        /// <returns> un string con el idCliente</returns>
        public int pedirId();
        
    }
}
