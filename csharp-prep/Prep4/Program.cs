using System;
using System.Collections.Generic;
class Program
{
  static void Main(string[] args)
  {
    List<int> numbers = new List<int>();
    bool keepGoing = true;

    Console.WriteLine("Enter a list of numbers, type 0 when finished.");

    while (keepGoing)
    {
      Console.WriteLine("Enter a number: ");
      int newNum = int.Parse(Console.ReadLine());
      numbers.Add(newNum);
      if (newNum == 0)
      {
        keepGoing = false;
      }
    }

    double sum = 0;

    for (int i = 0; i < numbers.Count - 1; i++)
    {
      sum += numbers[i];
    }

    double avg = sum / (numbers.Count - 1);
    int max = numbers.Max();

    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The average is: {avg}");
    Console.WriteLine($"The largest number is: {max}");
  }
}