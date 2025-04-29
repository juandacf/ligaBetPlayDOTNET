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

        Equipos (string id, string nombre){
            List <string> informacionBasica = new List<string>();            
            informacionBasica.Add(id);
            informacionBasica.Add(nombre);
            List<Staff> MiembrosStaff = new List<Staff>();
            List<Jugadores> Jugadores = new List<Jugadores> ();
            
        }

    }
}