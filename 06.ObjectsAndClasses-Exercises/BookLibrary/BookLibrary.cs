using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                Book currentBook = new Book();

                string[] currnetBookInfo = Console.ReadLine().Split();
                string currentTitle = currnetBookInfo[0];
                string currentAuthor = currnetBookInfo[1];
                string currentPublisher = currnetBookInfo[2];
                string currentReleaseDate = currnetBookInfo[3];
                string currentIsbn = currnetBookInfo[4];
                decimal currentPrice = decimal.Parse(currnetBookInfo[5]);

                currentBook.Title = currentTitle;
                currentBook.Author = currentAuthor;
                currentBook.Publisher = currentPublisher;
                currentBook.ReleaseDate = currentReleaseDate;
                currentBook.Isbnnumber = currentIsbn;
                currentBook.Price = currentPrice;

                books.Add(currentBook);
            }

            Dictionary<string, decimal> currentInfo = new Dictionary<string, decimal>();
            foreach (var book in books)
            {
                if (currentInfo.ContainsKey(book.Author))
                {
                    currentInfo[book.Author] += book.Price;
                }
                else
                {
                    currentInfo[book.Author] = book.Price;
                }
            }

            List<string> resultAuthors = currentInfo.OrderByDescending(x => x.Value).ThenBy(y => y.Key).Select(x => x.Key).ToList();
            List<decimal> resultPrices = currentInfo.OrderByDescending(x => x.Value).ThenBy(y => y.Key).Select(x => x.Value).ToList();

            for (int i = 0; i < resultAuthors.Count; i++)
            {
                Console.WriteLine($"{resultAuthors[i]} -> {resultPrices[i]:F2}");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string Isbnnumber { get; set; }
        public decimal Price { get; set; }
    }
}
