using System;

namespace MemorizingScripture
{
    class Scripture
    {
        // Private Properties
        private string _book;
        private int _chapter;
        private string _text;
        private int _verseStartNum;
        private int _numVerses;
        private int _start;
        private bool _usingDefaultScripture;
        List<string> verses = new List<string>();


        // Constructors
        public Scripture(bool usingDefaultScripture)
        {

            _usingDefaultScripture = usingDefaultScripture;
            if (usingDefaultScripture)
            {

            }
            else
            {


                // What book are we studying from
                _book = getBook();

                // What chapter are we studying
                _chapter = getChapter();

                // Are we studying multiple verses or not


                // 
            }

        }

        public Scripture(string book, int numVerses, int chapter, int verse)
        {

        }

        public Scripture(string book, int numVerses, int chapter, int verse, bool moreThanOneVerse)
        {

        }



        // Methods
        private string getDefaultBook()
        {

            return "Proverbs";
        }

        private int getDefaultChapter()
        {
            return 32;
        }

        private int getDefaultVerse(int verse)
        {
            return 25;
        }

        private string getDefaultText(string text)
        {
            return "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge.";
        }

        private Reference getReference()
        {
            if (_usingDefaultScripture)
            {
                return new Reference(_book, _chapter, _verseStartNum);
            }
            else
            {
                return new Reference(_book, _chapter, _verseStartNum);
            }
        }

        private string getBook()
        {

            return "Alma";
        }

        private int getChapter()
        {
            Console.WriteLine("What is the chapter?");
            int chapter = int.Parse(Console.ReadLine());
            Console.WriteLine($"The chapter is {chapter}");
            return chapter;
        }

        private int getVerse(int verse)
        {
            return 25;
        }

        private string getText(string text)
        {
            return "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge.";
        }

        private int getNumVerses()
        {
            Console.WriteLine("How many verses are you studying?");
            return _numVerses = int.Parse(Console.ReadLine());
        }

    }
}