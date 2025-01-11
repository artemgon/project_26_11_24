using System;
using project_26_11_24.Classes;

namespace project_26_11_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Books books = new Books
                {
                    [0] = "Book 1",
                    [1] = "Book 2",
                    [2] = "Book 3",
                    [3] = "Book 4",
                    [4] = "Book 5",
                };
                Console.WriteLine(books[0]);
                Console.WriteLine(books[1]);
                Console.WriteLine(books[2]);
                Console.WriteLine(books[3]);
                Console.WriteLine(books[4]);
                books.TenthBook = "Book 10";
                Console.WriteLine(books[9]); // tenth book is inaccessable using property
                Console.WriteLine(books.IsAvailable("Book 1"));
                Console.WriteLine(books.IsAvailable("Book 6"));
                books = books + "Book 6";
                Console.WriteLine(books.IsAvailable("Book 6"));
                Console.WriteLine(books[6]);
                books = books - "Book 6";
                Console.WriteLine(books.IsAvailable("Book 6"));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
