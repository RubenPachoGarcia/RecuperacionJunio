using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal class MenuImplementacion: MenuInterfaz
    {
        // Metodo mediante el cual se muestra el menu principal de la app mediante el cual el usuario podra interactuar
        public int menuPrincipal()
        {
            int opcionUsuario;

            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("-------------------");
            Console.WriteLine("0. CERRAR MENU");
            Console.WriteLine("1. NUMEROS DE HISTORICOS");
            Console.WriteLine("2. ALTA PROPIETARIO");
            Console.WriteLine("-------------------");
            Console.WriteLine("SELECCIONE LA OPCION QUE DESEE: ");

            opcionUsuario=Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;
        }
    }
}
