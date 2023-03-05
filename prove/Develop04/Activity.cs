using System;


namespace Mindfulness
{

  class Activity
  {

    protected int _time;
    protected int _activityTypeInt;
    protected string _activityTypeString;

    public Activity(int activityTypeInt)
    {

      _activityTypeInt = activityTypeInt;

      determineActivity();
      displayGreetingMessage();

    }

    protected void determineActivity()
    {
      switch (_activityTypeInt)
      {
        case 1:
          _activityTypeString = "Breathing";
          break;
        case 2:
          _activityTypeString = "Reflection";
          break;
        case 3:
          _activityTypeString = "Listing";
          break;
      }
    }

    protected void displayGreetingMessage()
    {
      Console.Clear();
      Console.WriteLine($"Welcome to the {_activityTypeString} Activity.");
    }

    public void displayActivityInstructions(string activityDesciption)
    {
      Console.WriteLine();
      Console.WriteLine(activityDesciption);
    }
    protected int getTime()
    {
      Console.WriteLine();
      Console.Write("How long, in seconds, would you like for your session? ");
      return int.Parse(Console.ReadLine());
    }

    protected void displayGetReady()
    {
      Console.Clear();
      Console.Write("Get Ready...");
    }
    protected void displaySpinner(int time)
    {
      List<string> animation = new List<string>();
      animation.Add("|");
      animation.Add("/");
      animation.Add("-");
      animation.Add(@"\");
      animation.Add("|");
      animation.Add("/");
      animation.Add("-");
      animation.Add(@"\");

      int i = 0;
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(time);

      while (DateTime.Now < endTime)
      {
        string s = animation[i];
        Console.Write(s);
        Thread.Sleep(200);
        Console.Write("\b \b");

        i++;

        if (i >= animation.Count)
        {
          i = 0;
        }
      }
    }

    protected void displayFinishMessage()
    {
      Console.Clear();
      Console.WriteLine($"Well done!!");

      Console.WriteLine($"You have completed {_time} seconds of the {_activityTypeString} Activity.");
      displaySpinner(5);
    }


  }
}