using System;


namespace Mindfulness
{


  class Menu
  {

    public string presentChoices()
    {
      Console.Clear();
      Console.WriteLine("Menu Options");
      Console.WriteLine("   1. Start Breathing Activity");
      Console.WriteLine("   2. Start Reflecting Activity");
      Console.WriteLine("   3. Start Listing Activity");
      Console.WriteLine("   4. Quit");
      Console.Write("Select a choice from the menu: ");
      return Console.ReadLine();
    }

  }
}