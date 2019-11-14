using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class Serie
    {
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Genero { get; set; }
        public string Productora { get; set; }
        public string Director { get; set; }
        public int Año { get; set; }
        public int Temporadas { get; set; }

        public int Rating { get; set; }


        public Serie(string titulo, string genero, string sinopsis, string productora, string director, int año, int temporadas, int rating)
        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Director = director;
            this.Sinopsis = sinopsis;
            this.Rating = rating;
            this.Temporadas = temporadas;
            this.Productora = productora;
        }

        public override string ToString()
        {
            return this.Titulo + this.Año;
        }


    }
}
