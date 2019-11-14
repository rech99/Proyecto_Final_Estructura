using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Pelicula
    {
        public string Titulo { get; set; }
        public int Año { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Sinopsis { get; set; }
        public int  Rating {get; set;} 

        public Pelicula (string director, string sinopsis, string genero, string titulo, int año, int rating)
        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Director = director;
            this.Sinopsis = sinopsis;
            this.Rating = rating;
        }

        public override string ToString()
        {
            return this.Titulo + " Año: " + this.Año;
        }

    }
}
