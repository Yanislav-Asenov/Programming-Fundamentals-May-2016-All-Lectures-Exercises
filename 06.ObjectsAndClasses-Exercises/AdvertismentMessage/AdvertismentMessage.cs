using System;

namespace AdvertismentMessage
{
    public class AdvertismentMessage
    {
        public static void Main()
        {
            string[] phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int numberOfMessages = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMessages; i++)
            {
                Random rng = new Random(Guid.NewGuid().GetHashCode());

                Console.WriteLine("{0} {1} {2} - {3}",
                    phrases[rng.Next(0, phrases.Length)],
                    events[rng.Next(0, events.Length)],
                    authors[rng.Next(0, authors.Length)],
                    cities[rng.Next(0, cities.Length)]);
            }


        }
    }
}
