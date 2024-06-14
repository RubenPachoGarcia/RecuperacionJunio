using RecuperacionJunio.Dtos;
using RecuperacionJunio.Servicios;
using RecuperacionJunio.Util;

namespace RecuperacionJunio
{
    class Program
    {
        public static string rutaCarpetaLogs = "C:\\Users\\ruben\\Desktop\\Programacion\\RecuperacionJunio\\Logs\\";

        public static string rutaFicheroLog = String.Concat(rutaCarpetaLogs, Utilidades.nombreFicheroLog());

        public static string rutaFicheroCargaInicial = "C:\\Users\\ruben\\Desktop\\Programacion\\RecuperacionJunio\\datosIniciales.txt";
        
        public static List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();

        public static List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi=new FicheroImplementacion();
            OperativaInterfaz oi=new OperativaImplementacion();

            // Variable opcion con la que el usuario podra seleccionar las opciones que desee
            int opcion;
            // Variable que controlara cuando el usuario ha decidido cerrar la aplicacion
            bool cerrarMenu = false;

            try
            {
                fi.escrituraFicheroLog("HAS ENTRADO");
                fi.cargaInicialFichero();
                // Bucle while donde el usuario tendra a disposicion el menu de la aplicacion y podra interactuar de manera libre con este
                while (!cerrarMenu)
                {
                    opcion = mi.menuPrincipal();

                    switch (opcion)
                    {
                        case 0:
                            fi.escrituraFicheroLog("SE CIERRA LA APLICACION");
                            Console.WriteLine("SE CIERRA LA APLICACION");
                            cerrarMenu = true;
                            break;
                        case 1:
                            fi.escrituraFicheroLog("NUMERO DE HISTORICOS");
                            Console.WriteLine("OPCION 1");
                            break;
                        case 2:
                            fi.escrituraFicheroLog("ALTA PROPIETARIO");
                            Console.WriteLine("OPCION 2");
                            foreach (PropietarioDto propietarios in listaPropietarios)
                            {
                                Console.WriteLine(propietarios.ToString());
                            }
                            oi.altaPropietario();
                            break;
                        default:
                            fi.escrituraFicheroLog("LA OPCION SELECCIONADA NO ES VALIDA O NO EXISTE");
                            Console.WriteLine("LA OPCION SELECCIONADA NO ES VALIDA O NO EXISTE");
                            break;
                    }
                }
            }catch(Exception ex) 
            {
                fi.escrituraFicheroLog("ERROR DETECTADO");
                Console.WriteLine("ERROR DETECTADO: ".Concat(ex.ToString()));   
            }
        }
    }
}
