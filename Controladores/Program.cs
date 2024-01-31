using EjercicioAsignado.Dtos;
using EjercicioAsignado.Servicios;

namespace EjercicioAsignado.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// @author JRT - 31/1/2024
    /// </summary>
    /// <param name="args"></param>
    /// 
    internal class Program
    {
        /// <summary>
        /// metodo de entrada de la aplicacion 
        /// @author JRT - 31/01/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementcion();
            OperativaInterfaz oi = new OperativaImplementacion();
            List<ClienteDto> listaClientes = new List<ClienteDto>();


            bool cerrarMenu = false;
            int opcionSeleccionada;


            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostraMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Cerrar Menu");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Dar alta cliente");
                        oi.darAltaCliente(listaClientes);
                        break;
                    case 2:
                        Console.WriteLine("Dar de baja cliente");
                        oi.darBajaCliente(listaClientes);
                        break;
                    case 3:
                        Console.WriteLine("Mostrar lista clientes");
                        foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna");
                        break;



                }
            }
        }
    }
}
    
