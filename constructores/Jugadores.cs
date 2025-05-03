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

        public Jugadores(string id, string nombre, string apellido,  string IdEquipo, string Posicion): base(id,nombre, apellido, IdEquipo){
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido= apellido;
            this.Posicion = Posicion;
            this.GolesAnotados = 0;
            this.TarjetasAmarillas = 0;
            this.TarjetasRojas = 0;
            this.TotalFaltas = 0;
            this.IdEquipo = id;
        }


    }
}