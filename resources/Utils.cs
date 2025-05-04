using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using ligaBetplay.constructores;
using ligaBetplay.menus;

namespace ligaBetplay.resources
{
    public class Utils
    {
           public static bool ValidacionBooleana()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("\n ¿Desea repetir esta acción? S/N");
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            char opcion = char.ToUpper(tecla.KeyChar);
            switch (opcion)
            {
                case 'S':
                    Console.Clear();
                    return true;
                case 'N':
                    Console.Clear();
                    return false;
                default:
                    Console.Write("\nTecla no válida. La preguntá se repetirá ");
                    Console.ReadKey(true);
                    break;
            }

        }
    }

    public static int ValidacionNumero(string message){
        
        while(true){
        try {
            ConsoleKeyInfo tecla = Console.ReadKey();
            int numero = int.Parse(tecla.KeyChar.ToString()); // Toca convertir primero la tecla al caracter
            return numero;
        } catch(Exception error){
            Console.Clear();
            Console.WriteLine("El caracter ingresado no es válido. Por favor, vuelva a intentarlo.");
            Console.WriteLine(message);
            
        }

        }
        

    }

    public static bool ValidarNombreEquipo(string NombreEquipo){

        foreach(Equipos Equipo in MenusGenerales.ContenedorGeneral){
          if (Equipo.nombre==NombreEquipo){
            return true;
          }
          
        }
        return false;
        
    }

    public static bool ValidarIdJugador (string IdJugador){

        foreach (var jugador in MenusGenerales.ContenedorJugadores)
        {
            if(jugador.Id==IdJugador){
                return true;
            } 
            
        }
        return false;
    }

    public static bool ValidarIdStaff(string IdStaff){
        foreach (var miembro in MenusGenerales.ContenedorStaff)
        {
            if(IdStaff == miembro.Id){
                return true;
            }
        
        }
        return false;
    }
    }
    
    }

