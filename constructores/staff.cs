using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.constructores
{
    public class Staff : Personas
    {

        public string rol {get; set;}
          public Staff(string id, string nombre, string apellido, string rol, string IdEquipo): base(id, nombre, apellido, IdEquipo){
            this.rol =rol;
        }
    }
}