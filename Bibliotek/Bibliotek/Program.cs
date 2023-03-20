using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Vill du skapa konto? Tryck 1");
            Console.WriteLine("Vill du logga in? Tryk 2\n");
            Console.WriteLine("Välj en siffra: ");
            string number = Console.ReadLine(); 

            if (number == "1")
            {
                Console.WriteLine("Här skapar du konto!"); 
            }
            else if (number == "2")
            {
                Console.WriteLine("Här loggar du in"); 

            }
            else
            {
                Console.WriteLine("Ogiltigt nummer");
            }

            if (number == "1")
            {

                Console.WriteLine(""); 
                Registration.RegistrationPage();  
            } 

            if (number == "2") 
            {
                Console.WriteLine("");  
                Login.LoginPage();  
            }

        } 



        
    }
}



