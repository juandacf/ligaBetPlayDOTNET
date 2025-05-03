using ligaBetplay.constructores;
using ligaBetplay.crud;
using ligaBetplay.menus;
using ligaBetplay.resources;
using ligaBetPlayDOTNET;

namespace ligaBetPlayDOTNET.crud
{
    public class CrudJugadores
    {
        
        public static void AgregarJugadores(){
            CrudEquipos.VerEquipos();
            Console.WriteLine("Por favor, ingrese el nombre del equipo al cual desea agregar el jugador.");
            string EquipoElegido = Console.ReadLine();
            bool EquipoExiste = Utils.ValidarNombreEquipo(EquipoElegido);
            if(EquipoExiste){
                var IdEquipoElegido = (from equipo in MenusGenerales.ContenedorGeneral
                                      where equipo.nombre == EquipoElegido
                                      select equipo).FirstOrDefault();
                
                Console.WriteLine("Por favor, ingrese el nombre del jugador");
                string NombreJugador = Console.ReadLine();
                Console.WriteLine("Por favor,ingrese el apellido del jugador.");
                string ApellidoJugador = Console.ReadLine();
                Console.WriteLine("Por favor, ingrese la posición del jugador");
                string PosicionJugador = Console.ReadLine();
                
                string id = Guid.NewGuid().ToString();
                Jugadores jugador = new Jugadores(id, NombreJugador, ApellidoJugador, IdEquipoElegido.id, PosicionJugador);

                MenusGenerales.ContenedorJugadores.Add (jugador);

                Console.WriteLine("El jugador ha sido agregado con éxito.");

                Console.ReadKey(true);

                
            } else {
                Console.WriteLine("El equipo seleccionado no existe. Por favor, presione enter y vuelva a intentarlo.");
                Console.ReadKey(true);
                AgregarJugadores();
            }
        }

        public static void VerJugadores(){
            Console.Clear();

            foreach (var jugador in MenusGenerales.ContenedorJugadores)

            {
                Console.WriteLine($"id:{jugador.Id}// Jugador:{jugador.Nombre} // Apellido: {jugador.Apellido} // Posicion: {jugador.Posicion} //");
            }
        }


        public static void EditarJugadores(){
            Console.Clear();
            VerJugadores();
            Console.WriteLine("Por favor, ingrese el id del jugador que desea modificar: ");
            string JugadorElegido = Console.ReadLine();
            bool JugadorExiste = Utils.ValidarIdJugador(JugadorElegido);
            if(JugadorExiste){
              Console.WriteLine("Por favor, ingrese el nuevo nombre del jugador");
              string NuevoNombre = Console.ReadLine();
              Console.WriteLine("Por favor, ingrese el nuevo apellido del jugador");
              string NuevoApellido = Console.ReadLine();
              Console.WriteLine("Por favor, ingrese la nueva posición del jugador");
              string NuevaPosicion =  Console.ReadLine();
              foreach (var jugador in MenusGenerales.ContenedorJugadores)
              {
                if(jugador.Id==JugadorElegido){
                    jugador.Nombre = NuevoNombre;
                    jugador.Apellido = NuevoApellido;
                    jugador.Posicion = NuevaPosicion;
                    Console.WriteLine($"La actualización del jugador {jugador.Nombre} {jugador.Apellido} fue efectuada con éxito. ");
                }
              }
            } 
        }
        public static void EliminarJugadores(){
            
        }
    }
}