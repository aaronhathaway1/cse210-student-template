using System;

namespace MemorizingScripture
{
  class Reference
  {
    string _book;
    int _chapter;
    int _verse;
    int[] _verses;

    public Reference(string book, int chapter, int verse)
    {
      _book = book;
      _chapter = chapter;
    }
  }
}