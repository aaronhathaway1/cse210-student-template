using System;
using System.Collections.Generic;

namespace Mindfulness
{


  class ReflectionActivity : Activity
  {

    private List<string> _firstSet = new List<string>
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
    };

    private List<string> _secondSet = new List<string> {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };


    private string _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


    public ReflectionActivity(int activityType) : base(activityType)
    {
      displayActivityInstructions(_activityDescription);
      _time = getTime();
      displayGetReady();
      displaySpinner(5);
      displayPrompt();
      displayFinishMessage();
    }


    private void displayPrompt()
    {


      displayFirstSet();

      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(_time);

      while (DateTime.Now < endTime)
      {
        displaySecondSet();
        displaySpinner(10);
      }

    }

    private void displayFirstSet()
    {

      Random random = new Random();
      int index = random.Next(_firstSet.Count);

      Console.WriteLine();
      Console.WriteLine("Consider the following prompt:");
      Console.WriteLine();
      Console.WriteLine($"--- {_firstSet[index]} ---");
      Console.WriteLine();
      Console.WriteLine("When you have something in mind, press enter.");
      Console.ReadLine();
      Console.WriteLine("Now ponder on each of the folllowing questions as they relate to this experience.");
      Console.Write("You may begin in: ");

      int s = 6;
      while (s > 0)
      {
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        s--;
      }
      Console.Clear();
    }

    private void displaySecondSet()
    {
      Random random = new Random();
      int index = random.Next(_secondSet.Count);
      Console.Write("\n");
      Console.Write($"{_secondSet[index]} ");
      _secondSet.RemoveAt(index);
    }

  }
}