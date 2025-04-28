using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.crud
{
    public class Staff : Personas
    {

        public string rol {get; set;}
          public Staff(int id, string nombre, string apellido, string rol): base(id, nombre, apellido){
            this.rol =rol;
        }
    }
}