using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.constructores
{
    public class Jugadores: Personas
    {
        public string Posicion {get;set;}
        
        public int GolesAnotados {get;set;}

        public int TarjetasAmarillas {get;set;}

        public int TarjetasRojas {get;set;}

        public int TotalFaltas {get;set;}

        Jugadores(string id, string nombre, string apellido, string Posicion, int GolesAnotados, int TarjetasAmarillas, int TarjetasRojas, int TotalFaltas, string IdEquipo): base(id,nombre, apellido, IdEquipo){
            this.Posicion = Posicion;
            this.GolesAnotados = GolesAnotados;
            this.TarjetasAmarillas = TarjetasAmarillas;
            this.TarjetasRojas = TarjetasRojas;
            this.TotalFaltas =TotalFaltas;
        }
    }
}