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
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");

      int input = int.Parse(Console.ReadLine());
      if (input == 1)
      {
        Write();
      }
      else if (input == 2) { Console.WriteLine("You chose Display"); }
      else if (input == 3) { Console.WriteLine("You chose Load"); }
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
      string dateTimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

      //Create the Prompt
      Prompt promptClass = new Prompt();

      //Ask the user & provide prompt
      promptClass.arrangePrompt();
      //Bring the prompt back for completion of entry object
      string prompt = promptClass.PromptExplicit;
      Console.WriteLine(prompt);

      // Record the entry
      string answer = Console.ReadLine();





      Console.WriteLine(dateTimeString);
      Console.WriteLine(prompt);
      Console.WriteLine(answer);

      entry.Date = dateTimeString;
      entry.Prompt = prompt;
      entry.Answer = answer;

      //Stringify the whole entry for storage
      string finalizedEntry = entry.Combine();
      Console.WriteLine(finalizedEntry);
    }




    void DisplayEntries()
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

        Console.WriteLine("What would you like the name of the file to be? \nPlease omit the '.txt' at the end.");

        // File name to be saved
        string fileName = Console.ReadLine();

        // Save the file
        Console.WriteLine("The file is being saved as " + fileName + ".txt");

        //Implement a try/catch?

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