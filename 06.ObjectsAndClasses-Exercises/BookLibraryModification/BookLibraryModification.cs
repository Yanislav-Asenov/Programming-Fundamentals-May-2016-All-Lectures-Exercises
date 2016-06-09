using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibraryModification
{
    public class BookLibraryModification
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] currentBookInfo = Console.ReadLine().Split();
                Book currentBook = new Book();
                DateTime currentDate =
                    DateTime.ParseExact(currentBookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string currentTitle = currentBookInfo[0];

                currentBook.Title = currentTitle;
                currentBook.ReleaseDate = currentDate;
                books.Add(currentBook);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books = books.Where(x => x.ReleaseDate > date).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title).ToList();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbnnumber { get; set; }
        public decimal Price { get; set; }
    }
}
