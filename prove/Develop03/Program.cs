using System;

namespace MemorizingScripture
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scripture Memorizer");
            Memorizer memorizer = new Memorizer();
            memorizer.Begin();

        }
    }
}