using System;

namespace MemorizingScripture
{
    class Scripture
    {
        // Private Properties
        private string _verse { get; set; }
        private string _text { get; set; }
        private int _numVerses;

        // Constructors
        public Scripture(string book, int numVerses, int chapter, int verse)
        {

        }

        public Scripture(string book, int numVerses, int chapter, int verse, bool moreThanOneVerse)
        {

        }

        // Methods
        private string getBook(string book)
        {

            return "Alma";
        }

        private int getChapter(int chapter)
        {
            return 32;
        }

        private int getVerse(int verse)
        {
            return 25;
        }

        private string getText(string text)
        {
            return "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge.";
        }

    }
}