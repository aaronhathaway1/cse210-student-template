using System;

namespace Fractional
{
    class Fraction
    {
        private int _top;
        private int _bottom;


        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }


        public void Display()
        {
            Console.WriteLine($"The top is {_top}");
            Console.WriteLine($"The bottom is {_bottom}");
        }



        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }
        public double GetDecimalValue()
        {
            return ((double)_top / _bottom);
        }
    }

}