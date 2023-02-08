using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace MemorizingScripture
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVerses;

            string book;
            int chapter;
            int startVerse;
            string verse;
            List<string> verses = new List<string>();

            Console.WriteLine("How many verses are you studying?");
            numVerses = int.Parse(Console.ReadLine());
            Console.WriteLine($"The the number of verses is {numVerses}");

            Console.WriteLine("What is the book?");
            book = Console.ReadLine();
            Console.WriteLine($"The book is {book}");

            Console.WriteLine("What is the chapter?");
            chapter = int.Parse(Console.ReadLine());
            Console.WriteLine($"The chapter is {chapter}");

            if (numVerses < 1)
            {
                Console.WriteLine("What is the verse?");
                verse = Console.ReadLine();
                Console.WriteLine(verse);
            }
            else
            {
                Console.WriteLine("What is the starting verse number");
                startVerse = int.Parse(Console.ReadLine());
                Console.WriteLine($"The starting verse number is {startVerse}");

                Console.WriteLine("Enter each verse (Do not include the number) and press enter");
                Console.WriteLine("When you're done type 'quit'");

                bool addingVerses = true;
                while (addingVerses)
                {
                    string answer = Console.ReadLine();

                    if (answer != "quit")
                    {
                        verses.Add(answer);
                    }
                    else
                    {
                        addingVerses = false;
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, verses));

            Console.WriteLine("Scripture Memorizer");
            Memorizer memorizer = new Memorizer();
            // Scripture scripture = new Scripture();  // Instantiate in the if/else
            // Reference reference = new Reference();

            memorizer.Begin();
        }
    }
}



// Press enter to continue or type 'quit' to finish:

// Chapter 3 
// 5 Trust in the Lord with all thine heart; and lean not unto thine own understanding.

// 6 In all thy ways acknowledge him, and he shall direct thy paths.