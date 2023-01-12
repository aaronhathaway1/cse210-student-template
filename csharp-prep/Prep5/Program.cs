using System;

class Program
{
  static void Main(string[] args)
  {
    displayWelcome();
    string name = getUserName();
    int num = getUserNumber();
    int numberSquared = squareNumber(num);
    DisplayResult(name, numberSquared);
  }

  static void displayWelcome()
  {
    Console.WriteLine("Welcome to the Program!");
  }

  static string getUserName()
  {
    Console.WriteLine("Please enter your name:");
    string userName = Console.ReadLine();
    return userName;
  }

  static int getUserNumber()
  {
    Console.WriteLine("Please enter your favorite number:");
    int userName = int.Parse(Console.ReadLine());
    return userName;
  }

  static int squareNumber(int favoriteNum)
  {
    return favoriteNum * favoriteNum;
  }

  static void DisplayResult(string name, int numberSquared)
  {
    Console.WriteLine($"{name}'s favorite number squared is {numberSquared}");
  }



}
