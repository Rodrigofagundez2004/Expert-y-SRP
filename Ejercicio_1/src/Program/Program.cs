using System;
using infolibreria;
using Ucu.Poo.Expert;

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Crear objeto Book
            Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "ABC123");

            // Crear objeto InfoLibreria
            infolibreria.Infolibreria libraryInfo = new infolibreria.Infolibreria("A", "7");

            // Imprimir información del libro y la biblioteca
            Console.WriteLine($"Book Information:");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Code: {book.Code}");
            Console.WriteLine();
            libraryInfo.PrintInfo();
        }
    }
}