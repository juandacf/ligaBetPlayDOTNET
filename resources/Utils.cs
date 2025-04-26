using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.resources
{
    public class Utils
    {
           public static bool ValidacionBooleana()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("\n ¿Desea repetir esta acción? con el programa? S/N");
            ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
            char opcion = char.ToUpper(tecla.KeyChar);
            switch (opcion)
            {
                case 'S':
                    return true;
                case 'N':
                    return false;
                default:
                    Console.Write("\nTecla no válida. La preguntá se repetirá ");
                    Console.ReadKey(true);
                    break;
            }

        }
    }

    public static int ValidacionNumero (){
        
        while(true){
        try {
            ConsoleKeyInfo tecla = Console.ReadKey();
            int numero = int.Parse(tecla.KeyChar.ToString()); // Toca convertir primero la tecla al caracter
            return numero;
        } catch(Exception error){
            Console.Clear();
            Console.WriteLine("El caracter ingresado no es válido. Por favor, vuelva a intentarlo.");
            Console.WriteLine($"El error fue {error.Message}");
        }

        }
        

        


    }

    
    }
}