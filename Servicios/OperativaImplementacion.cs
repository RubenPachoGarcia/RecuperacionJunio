using RecuperacionJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal class OperativaImplementacion: OperativaInterfaz
    {
        public void altaPropietario()
        {
            PropietarioDto propietario=new PropietarioDto();

            propietario.Id = idAutomatico();

            Console.WriteLine("INTRODUZCA SU DNI: ");
            string dniSolicitado=Convert.ToString(Console.ReadLine());
            propietario.Dni = dniSolicitado;

            if (dniSolicitado.Length < 9)
            {
                Console.WriteLine("EL DNI INTRODUCIDO NO ES VALIDO");
            }
            else
            {
                Console.WriteLine(propietario.ToString());
                Program.listaPropietarios.Add(propietario);
            }
        }

        private long idAutomatico()
        {
            long idAutomatico = 0;
            int tamanioLista = Program.listaPropietarios.Count;

            if (tamanioLista == 0)
            {
                idAutomatico = 1;
            }
            else
            {
                idAutomatico = tamanioLista + 1;
            }

            return idAutomatico;
        }
    }
}
