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

        public void AgregarLibro()
        { }

        public void Busqueda()
        { }

        public void EliminarLibro()
        { }

        public void OrdenarAño()
        { }

        public void FiltradoPorRecientes()
        { }
    }
}