using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ligaBetplay.resources
{
    public class Menus
    {
        public static string MenuPrincipal(){
            Console.Clear();
            return "Bienvenido al sistema de gestión de la Liga Betplay. Por favor, escoja alguna de las siguientes opciones: \n1.Gestionar Equipos \n2.Gestionar Jugadores \n3.Gestionar Staff \n 4. Agregar Fecha \n 5.Ver Estadísticas";
        }
        
        public static string MenuGestorEntidades(string entidad){
            Console.Clear();
            return $"Escoja la opción de su preferencia: \n1.Agregar {entidad}. \n2.Ver {entidad}. \n3.Modificar {entidad}. \n4.Eliminar {entidad}. \n5. Volver al menú principal. ";
        }

        public static string MenuGestorEstadisticas(){
            Console.Clear();
            return $"Escoja la opción de su preferencia: \n1.Ver estadísticas notables de equipos.  \n2.Ver estadísticas notables de jugadores. \n3.Ver estadísticas un equipo específico. \n4. Volver al menú principal";
        }
    }
}