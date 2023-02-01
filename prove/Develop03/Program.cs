using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace MemorizingScripture
{

    class Program
    {
        // static void Main(string[] args)
        // {
        // Console.WriteLine("Scripture Memorizer");
        // Memorizer memorizer = new Memorizer();
        // memorizer.Begin();

        //Make API call to return data

        // }

        //Make an api call to get a random set of scriptures
        //https://github.com/bcbooks/scriptures-json        

        string book;
        string chapter;
        string numVerses;
        string startVerse;
        bool test;

        // Console.WriteLine("The end verse must be after the start verse");
        // Console.WriteLine($"{book} only has {totalNumOfVerses} verses in the {chapter} chapter. \nPlease try again.")

        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            int bookNum = 0;
            while (bookNum < 1 || bookNum > 5)
            {
                Console.WriteLine("Which book would you like to study today?");
                Console.WriteLine("1. Old Testament");
                Console.WriteLine("2. New Testament");
                Console.WriteLine("3. Book of Momron");
                Console.WriteLine("4. Doctrine & Covenants");
                Console.WriteLine("5. Pearl of Great Price");

                bookNum = int.Parse(Console.ReadLine());
            }

            string bookString = "";
            switch (bookNum)
            {
                case 1:
                    bookString = "old-testament";

                    break;
                case 2:
                    bookString = "new-testament";
                    break;
                case 3:
                    bookString = "book-of-mormon";

                    break;
                case 4:
                    bookString = "doctrine-and-covenants";
                    break;
                case 5:
                    bookString = "pearl-of-great-price";
                    break;
                default:
                    bookString = "old-testament";
                    break;
            }



            var response = await client.GetAsync($"https://raw.githubusercontent.com/bcbooks/scriptures-json/master/{bookString}.json");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Request was unsuccessful");
            }
        }
    }
}