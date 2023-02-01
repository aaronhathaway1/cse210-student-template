using System;

namespace MemorizingScripture
{

    class Verse
    {
        string _book;
        string _chapter;
        string _verseNum;
        string _text;


        public Verse(string book, string chapter, string verseNum, string text)
        {
            _book = book;
            _chapter = chapter;
            _verseNum = verseNum;
            _text = text;
        }
    }
}