using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Pelicula
    {
        public string Tit { get; set; }
        public int Año { get; set; }
        public string Dir { get; set; }
        public string Gen { get; set; }
        public string Sin { get; set; }
        public int  Rat {get; set;} 

        public Pelicula (string dir, string sin, string gen, string tit, int año, int rat)
        {
            this.Tit = tit;
            this.Año = año;
            this.Gen = gen;
            this.Dir = dir;
            this.Sin = sin;
            this.Rat = rat;
        }

        public override string ToString()
        {
            return this.Tit + this.Año;
        }

    }
}
