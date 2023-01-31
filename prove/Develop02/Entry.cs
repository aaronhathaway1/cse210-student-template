using System;
using System.IO;

namespace Journaling
{
    class Entry
    {
        // public string EntryNumber { get; set; }
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Answer { get; set; }

        public string Combine()
        {
            string entry = "";
            entry += Date;
            entry += "~|~";
            entry += Prompt;
            entry += "~|~";
            entry += Answer;

            return entry;
        }

    }
}