using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
  public class Square : Shape
  {
    private double _side;


    public Square(string color, double side) : base(color)
    {

    }
    public double getSide()
    {
      return _side;
    }

    public void setSide(double side)
    {
      _side = side;
    }

    public override double getArea()
    {
      return _side * _side;
    }
  }
}