using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ligaBetplay.constructores
{
    public class Personas
    {

        public string Id {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string IdEquipo {get;set;}
        public Personas(string id, string nombre, string apellido, string IdEquipo ){
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.IdEquipo = IdEquipo;
        }
    }
}