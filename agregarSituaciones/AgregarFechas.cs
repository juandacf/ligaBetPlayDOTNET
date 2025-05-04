using ligaBetplay.crud;
using ligaBetplay.menus;
using ligaBetplay.resources;

namespace ligaBetPlayDOTNET.agregarSituaciones
{
    public class AgregarFechas
    {
        public static void AgregarFecha(){
            Console.WriteLine();
            CrudEquipos.VerEquipos();
            Console.WriteLine("Por favor, digite el nombre del primer equipo:");
            string NombreEquipo1 = Console.ReadLine();
            Console.WriteLine("Por favor, digite el nombre del segundo equipo:");
            string NombreEquipo2 = Console.ReadLine();
            bool Equipo1Existe = Utils.ValidarNombreEquipo(NombreEquipo1);
            bool Equipo2Existe = Utils.ValidarNombreEquipo(NombreEquipo2);
            if(Equipo1Existe && Equipo2Existe){
                

                foreach (var equipo in MenusGenerales.ContenedorGeneral)
                {
                    if(NombreEquipo1==equipo.nombre){

                    }
                    if(NombreEquipo2==equipo.nombre){
                        
                    }
                }
            } else {
                Console.WriteLine("Los dos equipos o alguno de los dos no existe. Presione enter y vuélvalo a intentarlo: ");
                Console.ReadKey(true);
                AgregarFecha();
            }
        }
    }
}