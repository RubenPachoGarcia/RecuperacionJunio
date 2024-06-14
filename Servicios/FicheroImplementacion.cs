using RecuperacionJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal class FicheroImplementacion: FicheroInterfaz
    {
        // Metodo por el cual cada vez que el usuario interaccione con la aplicacion quedara constancia de ello en el fichero
        public void escrituraFicheroLog(string mensaje)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Program.rutaFicheroLog, true);
                sw.WriteLine(mensaje);
                sw.Close();
            }catch (Exception ex)
            {
                Console.WriteLine("ERROR DETECTADO: ".Concat(ex.ToString()));
            }
        }

        // Metodo mediante el cual se realizara la carga inicial de la aplicacion de forma transparente
        public void cargaInicialFichero()
        {
            string rutaCargaInicial = Program.rutaFicheroCargaInicial;
            string contenido;

            StreamReader sr=new StreamReader(rutaCargaInicial);
            {
                contenido = sr.ReadToEnd();
            }

            string[] ficheroArray=contenido.Split("\n");

            for(int i = 0; i < ficheroArray.Length; i++)
            {
                string[] vehiculosYPropietariosArray = ficheroArray[i].Split(":");

                VehiculoDto vehiculo = new VehiculoDto();
                PropietarioDto propietario = new PropietarioDto();

                propietario.Id = idAutomatico();

                vehiculo.Matricula = vehiculosYPropietariosArray[0];
                propietario.MatriculaPropietario = vehiculosYPropietariosArray[0];

                vehiculo.FechaMatriculacion = Convert.ToDateTime(vehiculosYPropietariosArray[1]);

                propietario.Dni = vehiculosYPropietariosArray[2];

                propietario.FechaCompra = Convert.ToDateTime(vehiculosYPropietariosArray[3]);

                Program.listaVehiculos.Add(vehiculo);
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
