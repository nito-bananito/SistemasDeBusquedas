using SistemasDeBusquedas.Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeBusquedas.Clases
{
    public class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AgregarLibro(new Libro { Titulo = "Algoritmos", Autor = "Knuth", Anio = 1998, Descripcion = "Fundamentos de búsqueda y ordenamiento" });
            biblioteca.AgregarLibro(new Libro { Titulo = "IA Moderna", Autor = "Russell", Anio = 2021, Descripcion = "Aplicaciones de búsqueda en inteligencia artificial" });
            biblioteca.AgregarLibro(new Libro { Titulo = "Estructuras de Datos", Autor = "Cormen", Anio = 2009, Descripcion = "Búsqueda en listas y árboles" });

            // Ejemplo de búsquedas
            var libro1 = biblioteca.BuscarPorTitulo("Algoritmos");
            var libro2 = biblioteca.BuscarPorAutor("Russell");
            var extremos = biblioteca.BuscarExtremos();
            var coincidencias = biblioteca.BuscarPorDescripcion("inteligencia");

            Console.WriteLine($"Encontrado por título: {libro1?.Autor}");
            Console.WriteLine($"Encontrado por autor: {libro2?.Titulo}");
            Console.WriteLine($"Más antiguo: {extremos.antiguo?.Titulo}, más reciente: {extremos.reciente?.Titulo}");
            Console.WriteLine($"Coincidencias en descripción: {coincidencias.Count}");
        }
    }
}
