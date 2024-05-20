using ASP_MVC_Library.Models;
using ASP_MVC_Library.Services;
using ASP_MVC_Library.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Library.Controllers
{
    public class LibraryController : Controller
    {
        private static List<BookModel> books = BookModelParser.GetData("LibraryData.txt");
        private readonly QuoteService quoteService;

        public LibraryController(QuoteService quoteService)
        {
            this.quoteService = quoteService;
        }

        public IActionResult Index()
        {
            return View(books);
        }

        public async Task<IActionResult> GetQuotes()
        {
            QuoteResponseModel quotes = await quoteService.GetQuotesByAuthor("Albert Einstein", 3);

            return View(quotes);
        }
    }
}
