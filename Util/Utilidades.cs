using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Util
{
    internal class Utilidades
    {
        //Metodo mediante el cual generamos el nombre del fichero log que se especifica en el enunciado
        public static string nombreFicheroLog()
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormato=fechaActual.ToString("ddMMyyyy");

            string nombreLog = String.Concat("log-", fechaFormato, ".txt");

            return nombreLog;
        }
    }
}
