using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    public class Login
    
    {

        public static void LoginPage() 
        {
            Console.Clear();

            Console.WriteLine("Välkommen!");


            Console.WriteLine("För att logga in ange personnummer och lösenord.");
            Console.WriteLine("");

            Console.Write("Personnummer: ");
            var personalNumber = Console.ReadLine();

        Console.Write("Ange ditt Lösenord: ");
            var password = Console.ReadLine();
            Console.Write("Nu är du inloggad!:-)"); 
    }

    static bool UserRegistered(string personalNumber)
    {
        string[] users = System.IO.File.ReadAllLines(@"C:\Users\leon.vidos\source\repos\Bibliotek\Bibliotek\registration.txt"); 

        for (int i = 0; i < users.Length; i++)
        {
            var line = users[i].Trim();
            string[] parts = line.Split(' ');

            var currentPersonalNumber = parts[2];

            if (currentPersonalNumber == personalNumber) 
            {
                return true;
            }
        }

        return false;
    }

    static bool UserInfoIncomplete(string? firstName, string? lastName, string? personalNumber, string? password)
    {
        if (firstName == null || firstName == "") return true;
        if (lastName == null || lastName == "") return true;
        if (personalNumber == null || personalNumber == "") return true;
        if (password == null || password == "") return true;

        return false; 
    }
}
}
