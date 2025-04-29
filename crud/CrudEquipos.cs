using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ligaBetplay.constructores;
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
                    LigaBetplay.MainContainer.Add(equipo);
                    Console.WriteLine(MenusTexts.MensajeEquipoAgregadoExitoso);
                    Console.ReadKey(true);
                    switchContinuar = Utils.ValidacionBooleana();
                } else {
                    Console.WriteLine("El nombre del equipo ya existe. Por favor, presione enter y vuélvalo a intentar de nuevo:");
                    Console.ReadKey(true);
                }
                }

                

        }
    }
}