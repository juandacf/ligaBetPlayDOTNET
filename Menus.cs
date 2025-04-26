using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ligaBetplay.resources;

namespace ligaBetplay
{
    public class Menus
    {
        public static void MenuPrincipal (){
            Console.Clear();
            Console.WriteLine(MenusTexts.MenuPrincipalTexto);
            int NumeroEscogido = Utils.ValidacionNumero(MenusTexts.MenuPrincipalTexto);
            switch(NumeroEscogido){
                case 1:
                Console.Clear();
                MenuJugadores();
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                break;
                case 6:
                break;
                default:
                Console.WriteLine(MenusTexts.MensajeOpcionIncorrecta);
                Console.ReadKey(intercept:true);
                MenuPrincipal();
                break;
            }
            
        }

        public static void MenuJugadores(){
            Console.Clear();
            Console.WriteLine(MenusTexts.MenuGestorJugadoresTexto);
            int NumeroEscogido = Utils.ValidacionNumero(MenusTexts.MenuGestorJugadoresTexto);
            switch(NumeroEscogido){
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                MenuPrincipal();
                break;
                default:
                Console.WriteLine(MenusTexts.MensajeOpcionIncorrecta);
                Console.ReadKey(intercept:true);
                MenuPrincipal();
                break;

            }
        }

        
    }
}