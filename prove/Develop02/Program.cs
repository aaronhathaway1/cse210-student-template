using System;

namespace Journaling
{
  class Program
  {
    static void Main(string[] args)
    {
      Journal journal = new Journal();
      journal.DisplayMenu();

      // There is quite a bit of error check
      // I null check if entries has been instatiated
      // User input is also checked, although not perfectly
      // There are 30 prompts that are randomly picked fron
      // Or the user can chose no prompt.
    }
  }
}