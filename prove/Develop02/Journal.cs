using System;

namespace Journaling
{
    class Journal
    {
        public List<Entry> Entries { get; set; }

        public void DisplayMenu()
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Write();
            }
            else if (input == 2)
            {
                Display();
            }
            else if (input == 3)
            {
                Load();
            }
            else if (input == 4)
            {
                Save();
            }
            else if (input == 5)
            {
                Quit();
            }
            else
            {
                Console.WriteLine("Please use one of the specified inputs");
                DisplayMenu();
            }
        }

        void Write()
        {
            // Create a new entry
            Entry entry = new Entry();

            // Record the Date
            string dateTimeString = DateTime.Now.ToShortDateString();

            // Create the Prompt
            Prompt promptClass = new Prompt();

            // Ask the user & provide prompt
            promptClass.arrangePrompt();
            // Bring the prompt back for completion of entry object
            string prompt = promptClass.PromptExplicit;
            Console.WriteLine(prompt);
            Console.WriteLine("Please proceed with your entry.");

            // Record the entry
            string answer = Console.ReadLine();

            entry.Date = dateTimeString;
            entry.Prompt = prompt;
            entry.Answer = answer;

            // Stringify the whole entry for storage
            string finalizedEntry = entry.Combine();

            // Add it to list of entries
            // If entries is null
            if (Entries == null)
            {
                //create an entries object
                Entries = new List<Entry>();
            }
            Entries.Add(entry);


            //Return user to the main menu
            DisplayMenu();
        }

        void Display()
        {
            foreach (Entry entry in Entries)
            {
                Console.WriteLine();
                Console.WriteLine("Date: " + entry.Date);
                Console.WriteLine("Prompt: " + entry.Prompt);
                Console.WriteLine("Answer: " + entry.Answer);
            }
            DisplayMenu();
        }

        void Load()
        {
            Console.WriteLine("Please enter the name of the file that you want to load.");

            string fileName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(fileName);

            // Parse the file into Entries
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");

                Entry entry = new Entry();
                entry.Date = parts[0];
                entry.Prompt = parts[1];
                entry.Answer = parts[2];

                // Handle if Entries isn't intialized
                if (Entries == null)
                {
                    Entries = new List<Entry>();
                }

                Entries.Add(entry);

            }

            // Can we sort by the date of the entry? 
            // Take this into account when we save?
            // Create a recursive?
            DisplayMenu();
        }

        public void Save()
        {
            //Check for any current entries in memory?
            if (this.Entries == null)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("* There are no entries to save.");
                Console.WriteLine("* Please make an entry.");
                Console.WriteLine("* Redirecting to the home menu.");
                Console.WriteLine("*******************************");
            }
            else
            {
                // File name to be saved
                string fileName = "";
                Console.WriteLine("What would you like the name of the file to be? \nPlease omit the '.txt' at the end.");

                int errorCount = 0;

                while (fileName == "" || fileName.Contains(".txt"))
                {
                    if (errorCount > 0)
                    {
                        Console.WriteLine("*******************************");
                        Console.WriteLine("* Please enter a valid file name that is not blank and doesn't end in .txt");
                        Console.WriteLine("*******************************");
                    }

                    fileName = Console.ReadLine();
                    errorCount++;
                }

                fileName += ".txt";

                // Save the file & notify user
                Console.WriteLine("The file is being saved as " + fileName + ".txt");

                //Implement a try/catch?
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry entry in Entries)
                    {
                        try
                        {
                            outputFile.WriteLine(entry.Combine());
                        }
                        catch (System.Exception e)
                        {
                            Console.WriteLine($"There was a problem writing to the file: \n{e}");
                            throw;
                        }
                    }
                }
                //File has been saved & redirect user to menu
                Console.WriteLine("The file was saved");
                Console.WriteLine("Redirecting to the home menu.");
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

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("~|~");

                string entryNumber = parts[0];
                string date = parts[1];
                string prompt = parts[2];
                string answer = parts[3];

                // Create an entry from the class
                Entry newEntry = new Entry();
                // newEntry.EntryNumber = entryNumber;
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

// Problem with how the display menu works? // Make everything happen inside a while loop
// Make the exit program on the Program level?
// Confirm quitting the program, especially if there are entries
// Overwrite the file name, or give it a new name?