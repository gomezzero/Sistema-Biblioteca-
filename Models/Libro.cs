using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Biblioteca_.Models
{
    public class Libro : Publicacion
    {
        private static int ultimoId = 0;
        public int Id = ++ultimoId;
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }
        public string ISBN { get; set; }
        public int Precio { get; set; }

        public Libro( string titulo, string autor, string genero, int añoPublicacion, string isbn, int precio)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Genero = genero;
            this.AñoPublicacion = añoPublicacion;
            this.ISBN = isbn;
            this.Precio = precio;
        }

        public double DescuentoLibro()
        {
            double descueto = Precio;// precio * descuento / 100 
            return (descueto);
        }

        public void DetallesLibro()
        {
            
        }
    }
 
}