using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Library.Models
{
    public class BookModel
    {
        private int id;
        private int pages;
        private string title;
        private string publisher;
        private List<AuthorModel> authors;

        public BookModel (int id, int pages, string title, string publisher, List<AuthorModel> authors)
        {
            this.id = id;
            this.pages = pages;
            this.title = title;
            this.publisher = publisher;
            this.authors = authors;
        }

        public BookModel()
        {
            authors = new List<AuthorModel>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = "Amount of pages is required!")]
        [Range(1, int.MaxValue, ErrorMessage = "Not allowed! Number must be greater than 1!")]
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        [Required(ErrorMessage = "Title is required!")]
        [MinLength(10, ErrorMessage = "To short! Required at least 10 chars!")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [Required(ErrorMessage = "Publisher is required!")]
        [MinLength(10, ErrorMessage = "To short! Required at least 10 chars!")]
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        [Required(ErrorMessage = "Author is required!")]
        public List<AuthorModel> Authors
        {
            get { return authors; }
            set { authors = value; }
        }
    }
}
