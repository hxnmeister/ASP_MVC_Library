using ASP_MVC_Library.Models;
using ASP_MVC_Library.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace ASP_MVC_Library.Controllers
{
    public class ProductController : Controller
    {
        private static List<BookModel> books = BookModelParser.GetData("LibraryData.txt");

        public IActionResult SearchingResults(string searchingtext)
        {
            List<BookModel> foundedBooks = new List<BookModel>();

            searchingtext = searchingtext.Trim();
            ViewBag.SearchCriteria = searchingtext;

            foreach (var book in books)
            {
                if (CompareRequestToActualData(book, searchingtext))
                {
                    foundedBooks.Add(book);
                }
            }

            return View(foundedBooks);
        }

        public IActionResult CreateBook()
        {
            return View();
        }

        public IActionResult AddingBook(string title, string publisher, string pages, string authors)
        {
            if (ModelState.IsValid)
            {
                System.IO.File.AppendAllText("LibraryData.txt", $"\nId:{books.Count + 1}\nPages:{pages.Trim()}\nTitle:{title.Trim()}\nPublisher:{publisher.Trim()}\nAuthors:{authors.Trim()}");
                books = BookModelParser.GetData("LibraryData.txt");

                return Redirect("/");
            }
            else
            {
                return View("CreateBook");
            }
        }

        public IActionResult GetCurrentProduct(int id)
        {
            BookModel book = books.FirstOrDefault((item) => item.Id == id);

            return View(book);
        }

        private bool CompareRequestToActualData(BookModel book, string request)
        {
            return book.Publisher.Equals(request, StringComparison.CurrentCultureIgnoreCase) ||
                    book.Title.Equals(request, StringComparison.CurrentCultureIgnoreCase) ||
                    book.Authors.Any(author =>
                    author.FirstName.Equals(request, StringComparison.CurrentCultureIgnoreCase) ||
                    author.LastName.Equals(request, StringComparison.CurrentCultureIgnoreCase)) ||
                    (int.TryParse(request, out int pages) && pages == book.Pages);
        }
    }
}
