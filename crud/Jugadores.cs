using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.crud
{
    public class Jugadores: Personas
    {
        public string Posicion {get;set;}
        
        public int GolesAnotados {get;set;}

        public int TarjetasAmarillas {get;set;}

        public int TarjetasRojas {get;set;}

        public int TotalFaltas {get;set;}

        Jugadores(int id, string nombre, string apellido, string Posicion, int GolesAnotados, int TarjetasAmarillas, int TarjetasRojas, int TotalFaltas): base(id,nombre, apellido){
            this.Posicion = Posicion;
            this.GolesAnotados = GolesAnotados;
            this.TarjetasAmarillas = TarjetasAmarillas;
            this.TarjetasRojas = TarjetasRojas;
            this.TotalFaltas =TotalFaltas;
        }
    }
}