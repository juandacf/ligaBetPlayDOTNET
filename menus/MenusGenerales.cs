using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ligaBetplay.constructores;
using ligaBetplay.crud;
using ligaBetplay.resources;
using ligaBetPlayDOTNET.crud;

namespace ligaBetplay.menus
{
    public class MenusGenerales
    {
        public static List<Equipos> ContenedorGeneral = new List<Equipos>();

        public static List<Jugadores> ContenedorJugadores = new List<Jugadores>();

        public static List<Staff> ContenedorStaff = new List<Staff> ();
        public static void MenuPrincipal (){
            Console.Clear();
            Console.WriteLine(MenusTexts.MenuPrincipalTexto);
            int NumeroEscogido = Utils.ValidacionNumero(MenusTexts.MenuPrincipalTexto);
            switch(NumeroEscogido){
                case 1:
                Console.Clear();
                menuEquipos();
                Console.WriteLine("Presione enter y será devuelto al menú principal.");
                Console.ReadKey(true);
                MenuPrincipal();
                break;
                case 2:
                Console.Clear();
                MenuJugadores();
                Console.WriteLine("Presione enter y será devuelto al menú principal.");
                Console.ReadKey(true);
                MenuPrincipal();
                break;
                case 3:
                Console.Clear();
                MenuStaff();
                Console.WriteLine("Presione enter y será devuelto al menú principal.");
                Console.ReadKey(true);
                MenuPrincipal();
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
                CrudJugadores.AgregarJugadores();
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuJugadores();
                break;
                case 2:
                CrudJugadores.VerJugadores();
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuJugadores();
                break;
                case 3:
                CrudJugadores.EditarJugadores();
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuJugadores();
                break;
                case 4:
                CrudJugadores.EliminarJugadores();
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuJugadores();
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

        public static void menuEquipos(){
            Console.Clear();
            Console.WriteLine(MenusTexts.MenuGestorEquiposTexto);
            int NumeroEscogido = Utils.ValidacionNumero(MenusTexts.MenuGestorEquiposTexto);
                switch(NumeroEscogido){
                case 1:
                    CrudEquipos.AgregarEquipos();
                    Console.WriteLine(MenusTexts.MensajeFinal);
                    Console.ReadKey(true);
                    menuEquipos();
                break;
                case 2:
                    CrudEquipos.VerEquipos();
                    Console.WriteLine(MenusTexts.MensajeFinal);
                    Console.ReadKey(true);
                    menuEquipos();
                break;
                case 3:
                    CrudEquipos.EditarEquipos();
                    Console.WriteLine(MenusTexts.MensajeFinal);
                    Console.ReadKey(true);
                    menuEquipos();
                break;
                case 4:
                CrudEquipos.EliminarEquipos();
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                menuEquipos();
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

        public static void MenuStaff(){
            Console.Clear();
            Console.WriteLine(MenusTexts.MenuGestorStaffTexto);
            int NumeroEscogido = Utils.ValidacionNumero(MenusTexts.MenuGestorStaffTexto);
            switch(NumeroEscogido){
                case 1:
                CrudStaff.AgregarStaff(); 
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuStaff();
                break;
                case 2: 
                CrudStaff.VerStaff(); 
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuStaff();
                break;
                case 3:
                CrudStaff.EditarStaff(); 
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuStaff(); 
                break;
                case 4: 
                CrudStaff.EliminarStaff();
                Console.WriteLine(MenusTexts.MensajeFinal);
                Console.ReadKey(true);
                MenuStaff(); 
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