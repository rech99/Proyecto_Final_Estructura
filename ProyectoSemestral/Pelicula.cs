using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Pelicula : Conjunto
    {
   
        public Pelicula (string dir, string sin, string gen, string tit, int año, int rat)
        {
            Tit = tit;
            Año = año;
            Gen = gen;
            Dir = dir;
            Sin = sin;
            Rat = rat;
        }

       
    }
}
