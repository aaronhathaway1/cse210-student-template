using System;

namespace Mindfulness
{

  class Program
  {
    static void Main(string[] args)
    {

      Menu menu = new Menu();

      int answer = 0;

      while (answer != 4)
      {
        answer = int.Parse(menu.presentChoices());
        switch (answer)
        {
          case 1:

            BreathingActivity breathingActivity = new BreathingActivity(answer);
            break;
          case 2:
            ReflectionActivity reflectionActivity = new ReflectionActivity(answer);

            break;
          case 3:
            ListingActivity listingActivity = new ListingActivity(answer);

            break;

        }
      }
    }
  }
}