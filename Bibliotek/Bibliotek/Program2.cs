using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    public class Program2 
    {
        static BookSystem system = BookSystem.GetInstance();

        static void Main(string[] args)
        {
            // raderar historiken i terminalen (ascii erase display)
            Console.WriteLine("\u001b[2J\u001b[3J");

            while (true)
            {
                Console.Write("Sök efter en bok: ");
                var query = Console.ReadLine();
                Console.WriteLine("\n");

                // raderar historiken i terminalen (ascii erase display)
                Console.WriteLine("\u001b[2J\u001b[3J");
                Console.Clear();


                Console.WriteLine($"Sök efter en bok: {query}\n");

                var result = system.FindBook(query);

                for (var i = 0; i < result.Count; i++) 
                {
                    var book = result[i]; 

                    Console.WriteLine($"Id: {book.Id}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Subject:{book.Subject}"); 
                    Console.WriteLine($"Price: {book.Price}\n"); 
                }
            }
        }
    }
} 