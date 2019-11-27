using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Serie : Conjunto
    {


       
        public Serie(string tit, string gen, string sin, string prod, string dir, int año, string temp, string rat)
        {
            Tit = tit;
            Año = año;
            Gen = gen;
            Dir = dir;
            Sin = sin;
            Rat = rat;
            Temp = temp;
            Prod = prod;
            Categoria = "Serie";
        }

      


    }
}
