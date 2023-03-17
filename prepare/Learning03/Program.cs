using System;

namespace Fractional
{
  class Program
  {
    static void Main(string[] args)
    {
      //Encapsulation

      Fraction fraction1 = new Fraction();
      Fraction fraction2 = new Fraction(5);
      Fraction fraction3 = new Fraction(1, 3);

      // fraction1.Display();
      Console.WriteLine(fraction1.GetFractionString());
      Console.WriteLine(fraction1.GetDecimalValue());

      // fraction2.Display();
      Console.WriteLine(fraction2.GetFractionString());
      Console.WriteLine(fraction2.GetDecimalValue());

      // fraction3.Display();
      Console.WriteLine(fraction3.GetFractionString());
      Console.WriteLine(fraction3.GetDecimalValue());
    }


  }
}