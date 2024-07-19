using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Biblioteca_.Models
{
    public class Biblioteca
    {

        private static int ultimoId = 0;
        public int Id = ++ultimoId;
        public List<Libro> LibroList;

        public void AgregarLibro(string titulo, string autor, string genero, int añoPublicacion, string isbn, int precio)
        {
            LibroList.Add(new Libro(titulo, autor, genero, añoPublicacion, isbn, precio));
        }

// incompleto 
        public void Busqueda(string? busquedaTitulo)
        { 
             var encontrado = LibroList.Where(l => l.Titulo.Contains(busquedaTitulo)).ToList();
        }

        public void EliminarLibro()
        { }

        public void OrdenarAño()
        { }

        public void FiltradoPorRecientes()
        { }
    }
}