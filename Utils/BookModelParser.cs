using ASP_MVC_Library.Models;
using System;
using System.Collections.Generic;

namespace ASP_MVC_Library.Utils
{
    public class BookModelParser
    {
        public static List<BookModel> GetData(string filePath)
        {
            List<BookModel> books = new List<BookModel>();
            string[] fileData = System.IO.File.ReadAllLines(filePath);

            for (int i = 0; i < fileData.Length;)
            {
                int id = int.Parse(fileData[i++].Split(':')[1]);
                int pages = int.Parse(fileData[i++].Split(':')[1]);
                string title = fileData[i++].Split(':')[1];
                string publisher = fileData[i++].Split(':')[1];
                string[] authorsNames = fileData[i++].Split(':')[1].Split(',');

                List<AuthorModel> authors = new List<AuthorModel>();

                foreach (var authorName in authorsNames)
                {
                    string[] separatedName = authorName.Trim().Split(' ');

                    if(separatedName.Length == 1)
                    {
                        authors.Add(new AuthorModel { FirstName = separatedName[0], LastName = "", BirthDate = DateTime.Now });
                        continue;
                    }

                    authors.Add(new AuthorModel { FirstName = separatedName[0], LastName = separatedName[1], BirthDate = DateTime.Now });
                }

                books.Add(new BookModel
                {
                    Id = id,
                    Title = title,
                    Publisher = publisher,
                    Pages = pages,
                    Authors = authors
                });
            }

            return books;
        }
    }
}
