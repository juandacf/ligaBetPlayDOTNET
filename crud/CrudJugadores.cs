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
                string id = Guid.NewGuid().ToString();
                
            } else {
                Console.WriteLine("El equipo seleccionado no existe. Por favor, presione enter y vuelva a intentarlo.");
                Console.ReadKey(true);
                AgregarJugadores();
            }
        }
    }
}