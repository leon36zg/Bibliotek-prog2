using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;




namespace Bibliotek
{
    public class BookSystem
    {
        private static BookSystem? instance = null;
        private static string booksFilePath = "C:\\Users\\leon.vidos\\source\\repos\\Bibliotek\\Bibliotek\\book.txt";
        
        private List<Book> books = new List<Book>();  

        public object JsonConvert { get; private set; }

        public List<Book> GetBooks() { return books; } 

        private BookSystem() 
        {
            LoadBooks(); 
        }

        public void AddBook(Book book)  
        {
            books.Add(book); 
            Save();
        }

        public void Save()
        {

            string[] booksStringArr = books.Select(book => $"{book.Id} {book.Author} {book.Price} {book.Subject}").ToArray();


            File.WriteAllLines(booksFilePath, booksStringArr); 
        }

        public static BookSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new BookSystem();
            }
            return instance;
        }

        public List<Book> FindBook(string text) 
        {
            var result = new List<Book>();

            foreach (var book in books) 
            {
                var includeBook = false;

                if (book.Price.ToLower().Contains(text.ToLower()))
                {
                    includeBook = true;
                }

                if (includeBook) 
                {
                    result.Add(book); 
                } 
            }

            return result;
        }

        void LoadBooks() 
        {
            string data = File.ReadAllText(@"C:\Users\leon.vidos\source\repos\Bibliotek\Bibliotek\Book.json");
            dynamic booksData = JsonConvert.DeserializeObject<dynamic>(data); 

            foreach (var c in booksData)
            {
                Book book = new Book((string) c.id, (string) c.book_author, (string) c.book_price, (string) c.book_subject, (string)c.book_availability);  
                books.Add(book); 
            }
        }
    }
}  

