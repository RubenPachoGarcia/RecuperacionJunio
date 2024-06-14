using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal interface FicheroInterfaz
    {
        /*
        * Metodo por el cual cada vez que el usuario interaccione con la aplicacion quedara constancia de ello en el fichero
        * RPG-14062024
        */
        public void escrituraFicheroLog(string mensaje);
        /*
         * Metodo mediante el cual se realizara la carga inicial de la aplicacion de forma transparente
         * RPG-14062024
         */
        public void cargaInicialFichero();
    }
}
