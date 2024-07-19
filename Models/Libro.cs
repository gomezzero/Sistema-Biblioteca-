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

        public Libro(string titulo, string autor, string genero, int añoPublicacion, string isbn, int precio)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Genero = genero;
            this.AñoPublicacion = añoPublicacion;
            this.ISBN = isbn;
            this.Precio = precio;
        }

// pensando como implementar (sera mejor crear una compra y implimentar)
        // public double DescuentoLibro(double valorDescuento)
        // {
        //     double descueto = valorDescuento / 100 * Precio;// precio * descuento / 100 
        //     return (descueto);
        // }

        public void MostrarLibros(List<Libro> lista1)
        {
            Console.Clear();
            foreach (var item in lista1)
            {
                SaltoLinea();
                SaltoLinea();

                Console.Write($"El titulo del libro: {item.Titulo}");
                SaltoLinea();

                Console.Write($"El genero del libro: {item.Genero}");
                SaltoLinea();

                Console.Write($"El precio del libro: {item.Precio}");
            }

            SaltoLinea();
            SaltoLinea();
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }

        public void DetallesLibros(List<Libro> lista1, string busquedaTitulo)
        {
            Console.Clear();
            var encontrado = lista1.Where(l => l.Titulo.Contains(busquedaTitulo)).ToList();

            foreach (var item in encontrado)
            {
                SaltoLinea();
                SaltoLinea();
                Console.Write($"El ID del libro es: {item.Id}");
                SaltoLinea();

                Console.Write($"El titulo del libro: {item.Titulo}");
                SaltoLinea();

                Console.Write($"E autor del libro: {item.Autor}");
                SaltoLinea();

                Console.Write($"El genero del libro: {item.Genero}");
                SaltoLinea();

                Console.Write($"El año de publicacion del libro: {item.AñoPublicacion}");
                SaltoLinea();

                Console.Write($"El ISBN del libro: {item.ISBN}");
                SaltoLinea();

                Console.Write($"El precio del libro: {item.Precio}");
                SaltoLinea();
            }
            
            SaltoLinea();
            Console.WriteLine("presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

// Metodo para saltar una linea
        public void SaltoLinea()
        {
            Console.WriteLine();
        }
    }

}