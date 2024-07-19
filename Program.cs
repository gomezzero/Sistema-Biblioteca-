using Sistema_Biblioteca_.Models;

// instanciando metodo
var biblioteca1 = new Biblioteca();

// crando libro
var libro1 = new Libro("therion", "Oliver", "fantacia", 2015, "sdq2134", 1500);

var lista1 = new List<Libro>()
{
    libro1
};
biblioteca1.LibroList = lista1;

// Metodo para el estilo de los titulos
static void MostrarEncabezado(string titulo)
{
    Console.Clear();
    Console.WriteLine(new string('-', 60));
    Console.WriteLine(titulo.ToUpper());
    Console.WriteLine(new string('-', 60));
}

// Menu de accion

while (true)
{
    Console.Clear();
    Console.WriteLine("----- Sistema de Gestión de Biblioteca -----");
    Console.WriteLine("1. Registrar Un Nuevo Libro");
    Console.WriteLine("2. Detalles De Un Libro");
    Console.WriteLine("3. Busqueda De Libros");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opción: ");

    switch (Console.ReadLine())
    {
        case "1":
            while (true)
            {
                MostrarEncabezado("Ingresa Los Atributos Del Libro Que Quieres Agregar");

                Console.Write("Ingresa el titulo del libro: ");
                string titulo = Console.ReadLine();

                Console.Write("Ingresa el autor del libro: ");
                string autor = Console.ReadLine();

                Console.Write("Ingresa el genero del libro: ");
                string genero = Console.ReadLine();

                Console.Write("Ingresa el año de publicacion del libro: ");
                int añoPublicacion = Convert.ToInt16(Console.ReadLine());

                Console.Write("Ingresa el ISBN del libro: ");
                string isbn = Console.ReadLine();

                Console.Write("Ingresa el precio del libro: ");
                int precio = Convert.ToInt16(Console.ReadLine());

                biblioteca1.AgregarLibro(titulo, autor, genero, añoPublicacion, isbn, precio);

                Console.WriteLine("El libro fue añadido a la biblioteca");
                Console.Write("Quieres ingresar otro libro? \n(si) (no) :");

                string decidion = Console.ReadLine();

                if (decidion == "no")
                {
                    break;
                }
            }
            break;

        case "2":
            MostrarEncabezado("Ingresa El Titulo Del Libro Que Quieres Consultar");

            MostrarEncabezado("Si Queres ver todos nuestros libros Escribe 2");
            libro1.SaltoLinea();
            string busquedaTitulo = Console.ReadLine();

            if (busquedaTitulo == "2")
            {
                libro1.MostrarLibros(lista1);
            }
            else if (busquedaTitulo != "2")
            {
                libro1.DetallesLibros(lista1, busquedaTitulo);
            }
            break;

// incompleto
        case "3":
            MostrarEncabezado("Bienvelido a nuesto apartado de busqueda");

            Console.WriteLine("----- Por que tipo de atributo quieres buscar tu libro -----");
            Console.WriteLine("1. Titulo");
            Console.WriteLine("2. Autor");
            Console.WriteLine("3. Genero");
            Console.WriteLine("4. Año de publicacion");
            Console.WriteLine("5. ISBN");
            Console.WriteLine("6. Precio");
            Console.Write("Selecciona una opción: ");

            biblioteca1.Busqueda();

            break;

        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
}