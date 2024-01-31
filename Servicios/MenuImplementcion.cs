using EjercicioAsignado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsignado.Servicios
{
    /// <summary>
    /// Clase que contiene la implementacion de cada mètodo del menuInterfaz
    /// @author JRT - 31/1/2024
    /// </summary>
    internal class MenuImplementcion : MenuInterfaz
    {
        public ClienteDto crearCliente()
        {
            throw new NotImplementedException();
        }

        public int mostraMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Cerrar");
            Console.WriteLine("1. Dar Alta cliente");
            Console.WriteLine("2. Dar Baja Cliente");
            Console.WriteLine("3. Mostrar lista de clientes");
            Console.WriteLine("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        public int pedirId()
        {
            Console.WriteLine("Indica el id del cliente");
            int idCliente = Convert.ToInt32(Console.ReadLine());

            return idCliente;
        }
    }
}
