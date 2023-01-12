using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("What was your grade percentage?");
    int letterGrade = int.Parse(Console.ReadLine());
    bool passed = true;
    char letter = 'A';

    if (letterGrade >= 90)
    {
      letter = 'A';
    }
    else if (letterGrade >= 80)
    {
      letter = 'B';
    }
    else if (letterGrade >= 70)
    {
      letter = 'C';
    }
    else if (letterGrade >= 60)
    {
      letter = 'D';
      passed = false;
    }
    else
    {
      letter = 'F';
    }

    Console.WriteLine($"You got a(n) {letter}.");

    if (passed)
    {
      Console.WriteLine("You passed. Congratulations!");
    }
    else
    {
      Console.WriteLine("You failed. You can always try again next semester!");
    }
  }
}