using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ligaBetplay.constructores;
using ligaBetplay.menus;
using ligaBetplay.resources;

namespace ligaBetplay.crud
{
    public class CrudEquipos
    {
            public static void AgregarEquipos (){
                Console.Clear();
                bool switchContinuar = true;
                while (switchContinuar) {
                Console.WriteLine(MenusTexts.MensajeRequerirNombreEquipo);
                string NombreEquipo = Console.ReadLine();
                bool ExisteNombreEquipo = Utils.ValidarNombreEquipo(NombreEquipo);
                if(!ExisteNombreEquipo){
                    string id = Guid.NewGuid().ToString();
                    Equipos equipo = new Equipos(id, NombreEquipo);
                    MenusGenerales.ContenedorGeneral.Add(equipo);
                    Console.WriteLine(MenusTexts.MensajeEquipoAgregadoExitoso);
                    Console.ReadKey(true);
                    switchContinuar = Utils.ValidacionBooleana();
                } else {
                    Console.WriteLine("El nombre del equipo ya existe. Por favor, presione enter y vuélvalo a intentar de nuevo:");
                    Console.ReadKey(true);
                }
                }             
        }

        public static void VerEquipos(){
            Console.Clear();
            Console.WriteLine(MenusTexts.MensajePrincipalVerequipos);
            foreach (var equipo in MenusGenerales.ContenedorGeneral)
            {
                Console.WriteLine($"{equipo.nombre}");
            }
        }

        public static void EditarEquipos(){
            Console.Clear();
            VerEquipos();
            Console.WriteLine("Por favor, ingrese el nombre dele quipo que desea modificar:");
            string EquipoElegido = Console.ReadLine();
            bool EquipoExiste = Utils.ValidarNombreEquipo(EquipoElegido);
            if(EquipoExiste){
                Console.WriteLine("Por favor, ingrese el nuevo nombre del equipo");
                string NuevoNombre = Console.ReadLine();
                foreach(var equipo in MenusGenerales.ContenedorGeneral){
                    if(EquipoElegido== equipo.nombre){
                        equipo.nombre = NuevoNombre;
                        Console.WriteLine("El nombre del equipo pudo ser actualizado. Por favor, presione enter para volver al menú principal");;
                        Console.ReadKey(true);
                        MenusGenerales.MenuPrincipal();
                    }
                }
            } else {
                Console.WriteLine("El equipo escogido no exsite. Por favor, presione enter y vuelva a intentarlo.");
                Console.ReadKey(true);
                EditarEquipos();
            }
        }
        public static void EliminarEquipos(){
            Console.Clear();
            VerEquipos();
            Console.WriteLine("Por favor, ingrese el nombre dele quipo que desea eliminar:");
            string EquipoElegido = Console.ReadLine();
            bool EquipoExiste = Utils.ValidarNombreEquipo(EquipoElegido);
            if(EquipoExiste){
                var EquipoAEliminar = MenusGenerales.ContenedorGeneral.FirstOrDefault(Equipo=> Equipo.nombre==EquipoElegido);
                if(EquipoAEliminar != null){
                    MenusGenerales.ContenedorGeneral.Remove(EquipoAEliminar);
                    Console.WriteLine("El equipo se ha eliminado con éxito.");
                }
            }else {
                Console.WriteLine("El equipo escogido no exsite. Por favor, presione enter y vuelva a intentarlo.");
                Console.ReadKey(true);
                EliminarEquipos();
            }
        }
    }
}