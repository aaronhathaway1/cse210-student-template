using System;

class Program
{
  static void Main(string[] args)
  {
    // int randomInt = int.Parse(Console.ReadLine());
    int randomInt = new Random().Next(1, 100);
    bool guessedCorrectly = true;

    while (guessedCorrectly)
    {
      Console.WriteLine("What is your guess?");
      int guessNum = int.Parse(Console.ReadLine());
      if (randomInt > guessNum)
      {
        Console.WriteLine("Higher");
      }
      else if (randomInt < guessNum)
      {
        Console.WriteLine("Lower");
      }
      else
      {
        Console.WriteLine("You guessed it!");
        guessedCorrectly = false;
      }
    }
  }
}