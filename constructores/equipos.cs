using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ligaBetplay.constructores
{
    
    
    public class Equipos
    {
        public string id {get;set;}
        public string nombre {get;set;}

        public int PartidosJugados {get;set;}

        public int PartidosGanados {get;set;}
        public int PartidosPerdidos {get;set;}
        public int  PartidosEmpatados {get;set;}
        public int GolesAFavor {get;set;}
        public int GolesEnContra {get;set;}
        public int TotalPuntos {get;set;}
        


        
        public Equipos (string id, string nombre){
            this.id = id;
            this.nombre = nombre;
            this.PartidosJugados = 0;
            this.PartidosGanados=0;
            this.PartidosPerdidos =0;
            this.PartidosEmpatados =0;
            this.GolesAFavor=0;
            this.GolesEnContra=0;
            this.TotalPuntos=0;
        }

    }
}