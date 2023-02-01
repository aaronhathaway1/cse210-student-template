using System;

namespace MemorizingScripture
{

    class Text
    {
        string _textName;
        string[] _books;
        Book[] newBooks;




        public Text(string textName, string[] books)
        {
            _textName = textName;
            _books = books;


        }
    }
}