using System;


namespace Mindfulness
{

  class BreathingActivity : Activity
  {

    private string _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    int _startingBreatheInCount = 2;
    int _startingBreatheOutCount = 3;

    public BreathingActivity(int activityTypeInt) : base(activityTypeInt)
    {

      displayActivityInstructions(_activityDescription);
      _time = getTime();

      displayGetReady();

      displaySpinner(5);

      displayPrompt(_time);

      displayFinishMessage();

    }



    private void displayPrompt(int time)
    {

      int totalTime = 0;

      while (totalTime < time)
      {
        Console.WriteLine();
        displayBreatheIn(_startingBreatheInCount);
        displayBreatheOut(_startingBreatheOutCount);
        totalTime += _startingBreatheInCount;
        totalTime += _startingBreatheOutCount;
      }
    }

    private int displayBreatheIn(int count)
    {
      Console.WriteLine();
      Console.Write("Breath in...");
      while (count > 0)
      {
        Console.Write(count);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        count--;
      }
      return _startingBreatheInCount++;
    }

    private void displayBreatheOut(int count)
    {
      Console.WriteLine();
      Console.Write("Now breathe out...");
      while (count > 0)
      {
        Console.Write(count);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        count--;
      }
      _startingBreatheOutCount++;

    }
  }
}