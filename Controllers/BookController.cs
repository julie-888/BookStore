using BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookStorage _bookStorage;

        public BookController(IBookStorage bookStorage)
        {
            _bookStorage = bookStorage;
        }
        public IActionResult Index()
        {
            var books = _bookStorage.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookStorage.GetBooksById(id);
            return View(book);
        }
    }
}
