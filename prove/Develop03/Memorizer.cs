// using System;

// namespace MemorizingScripture
// {
//     class Memorizer
//     {

//         Scripture _scripture;

//         private string _answer { get; set; } // Holds either blank or 'quit'
//         private int _difficultyLevel { get; set; }



//         public void Begin()
//         {

//             while (_answer != "")
//             {

//                 Console.WriteLine("Press enter to continue or type 'quit' to finish:");

//                 _answer = Console.ReadLine();
//             }

//         }



//         // Constructor
//         public Memorizer()
//         {
//             // _scripture = getScripture();
//         }

//         // Please choose a book to study

//         // Please choose from the following

//         // Please choose a chapter

//         //Which of the verses from Chapter of Book would you like to memorize?
//         //There are a total of x verses in this chapter.
//         //Would you like to study one verse in particular or a group of verses?


//         Scripture getScripture()
//         {

//             //Find out which book, chapters and verses
//             //Allow the user to input how many, or
//             // Have the option to pick randomly for them.

//             Console.WriteLine("test");
//             Console.WriteLine();
//             Console.ReadLine();
//             Console.ReadLine();

//             string book = "Alma";
//             int chapter = 32;
//             int verse = 25;


//             Console.WriteLine("");
//             int numOfVerses = 1;


//             if (numOfVerses == 1)
//             {

//                 return new Scripture(book, numOfVerses, chapter, verse);
//             }
//             else
//             {
//                 return new Scripture(book, numOfVerses, chapter, verse, true);
//             }

//         }

//         void DisplayScripture() { }

//         void RemoveWords() { }

//     }
// }