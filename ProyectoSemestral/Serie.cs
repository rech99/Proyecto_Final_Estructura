using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Serie
    {
        public string Tit { get; set; }
        public string Sin { get; set; }
        public string Gen { get; set; }
        public string Prod { get; set; }
        public string Dir { get; set; }
        public int Año { get; set; }
        public int Temp { get; set; }

        public int Rat { get; set; }


        public Serie(string tit, string gen, string sin, string prod, string dir, int año, int temp, int rat)
        {
            this.Tit = tit;
            this.Año = año;
            this.Gen = gen;
            this.Dir = dir;
            this.Sin = sin;
            this.Rat = rat;
            this.Temp = temp;
            this.Prod = prod;
        }

        public override string ToString()
        {
            return this.Tit + this.Año;
        }


    }
}
