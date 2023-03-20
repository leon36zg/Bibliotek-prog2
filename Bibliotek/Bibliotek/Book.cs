using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek 
{
    public class Book
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Subject { get; set; }
        public string Availability { get; set; } 



        public Book(string Id, string Author, string Price, string Subject, string Availability) 
        {
            this.Id = Id;
            this.Author = Author;
            this.Price = Price;
            this.Subject = Subject;
            this.Availability = Availability; 
            
        }

    }
}
