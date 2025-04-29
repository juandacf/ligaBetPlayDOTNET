using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ligaBetplay.constructores
{
    public class Personas
    {

        public int id {get;set;}
        public string nombre {get;set;}
        public string apellido {get;set;}
        public Personas(int id, string nombre, string apellido ){
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}