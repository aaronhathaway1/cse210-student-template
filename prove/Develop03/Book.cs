using System;

namespace MemorizingScripture
{

    class Book
    {
        string _bookName;
        Chapter[] _chapters;
        int _numOfChapters;

        public Book(string book, Chapter[] chapters)
        {
            _bookName = book;


        }
    }
}