using BookStore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public interface IBookStorage
    {
        Book AddNewBook(string bookName, DateTime publishDate, string authorName);
        List<Book> GetBooks();
    }
    public class BookStorage : IBookStorage
    {
        public static List<Book> Books = new List<Book>() {
            new Book()
            {
                Id = 1,
                Name = "Война и Мир",
                publishDate = new DateTime(1867, 9,5),
                authorName = "Л.Н. Толстой"
            },
            new Book()
            {
                Id = 2,
                Name = "Аэропорт",
                publishDate = new DateTime(1975, 7,2),
                authorName = "Артур Хейли"
            },
             new Book()
            {
                Id = 3,
                Name = "Идиот",
                publishDate = new DateTime(1897, 1,3),
                authorName = "Ф.М. Достоевский"
            },
             new Book()
            {
                Id = 4,
                Name = "12 стульев",
                publishDate = new DateTime(1957, 9,3),
                authorName = "Ильф и Петров"
            },
        };
        public Book AddNewBook(string bookName, DateTime publishDate, string authorName)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooks()
        {
            //using var sw = new StreamWriter("AllB.txt");

            //var json = JsonSerializer.Serialize<List<Book>>(Books);
            //sw.Write(json);
            using var sw = new StreamReader("AllB.txt");
            var json = sw.ReadToEnd();

            var books = JsonSerializer.Deserialize<List<Book>>(json);
            return Books;
         
        }
    }


}
