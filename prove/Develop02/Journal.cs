using System;

namespace Journaling
{
    class Journal
    {
        public List<Entry> Entries { get; set; }



        public void DisplayMenu()
        {
            Console.WriteLine("Please select on of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Savee");
            Console.WriteLine("5. Quit");

            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Display();
            }
            else if (input == 2) { Console.WriteLine("You chose Display"); }
            else if (input == 3) { Console.WriteLine("You chose Load"); }
            else if (input == 4)
            {
                Save();
            }
            else if (input == 5) { Console.WriteLine("You chose Quit"); }
            else
            {
                Console.WriteLine("Please use one of the specified inputs");
                DisplayMenu();
            }
        }


        void Write()
        {

        }

        void Display()
        {
            Console.WriteLine("Please enter the file name of the journal entries you wish to to display.");
            string filename = Console.ReadLine();
            GetEntries(filename);
            // List<Entry> DisplayEntries();
        }

        void Load()
        {

        }

        public void Save()
        {
            //Check for any current entries in memory?
            try
            {
                if (this.Entries.Count > 0)
                {

                }
            }
            catch (System.Exception)
            {

                Console.WriteLine("There are no entries to save \n Please make a new");


                Console.WriteLine("What would you like the name of the file to be? \n Please omit the '.txt' at the end.");

                string fileName = Console.ReadLine();
                throw;
            }




            DisplayMenu();
        }

        void Quit()
        {
            return;
        }

        public List<Entry> GetEntries(string fileName)
        {

            string[] lines = System.IO.File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i += 4)
            {
                string[] parts = lines[i].Split("~|~");

                string entryNumber = parts[0];
                string date = parts[1];
                string prompt = parts[2];
                string answer = parts[3];

                // Create an entry from the class
                Entry newEntry = new Entry();
                newEntry.EntryNumber = entryNumber;
                newEntry.Date = date;
                newEntry.Prompt = prompt;
                newEntry.Answer = answer;

                // Add the entry to the list of entries
                Entries.Add(newEntry);

            }

            return Entries;
        }



    }
}