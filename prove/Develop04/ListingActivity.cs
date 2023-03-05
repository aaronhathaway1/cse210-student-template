using System;

namespace Mindfulness
{


  class ListingActivity : Activity
  {

    private string _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private List<string> _questions = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    private List<string> _answers = new List<string>();



    public ListingActivity(int activityType) : base(activityType)
    {
      displayActivityInstructions(_activityDescription);
      _time = getTime();
      displayGetReady();
      displaySpinner(5);
      displayPrompt();
      getAnswers();
      displayFinishMessage();
    }


    private void displayPrompt()
    {
      Random random = new Random();
      int index = random.Next(_questions.Count);

      Console.WriteLine();
      Console.WriteLine("List as many responses you can to the following prompt:");
      Console.WriteLine();
      Console.WriteLine($"--- {_questions[index]} ---");
      Console.Write("You may begin in: ");
      int s = 6;
      while (s > 0)
      {
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        s--;
      }


    }

    private void getAnswers()
    {
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(_time);
      while (DateTime.Now < endTime)
      {
        string answer = Console.ReadLine();
        _answers.Add(answer);
      }

      Console.WriteLine($"You listed {_answers.Count} items!");
      Thread.Sleep(4000);
    }

  }
}