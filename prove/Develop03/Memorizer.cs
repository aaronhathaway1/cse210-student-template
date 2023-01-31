using System;

namespace MemorizingScripture
{
    class Memorizer
    {

        Scripture _scripture = new Scripture();

        private string _answer { get; set; }

        public void Begin()
        {

            while (_answer != "")
            {



                _answer = Console.ReadLine();
            }

        }



        string[] getScripture()
        {

            //Instatiate the library, 
            //Find out which book, chapters and verses
            //Allow the user to input how many, or
            // Have the option to pick randomly for them.
            return new string[] { "Hey", "Hi" };
        }
    }
}