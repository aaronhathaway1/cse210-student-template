using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
  public class Rectangle : Shape
  {

    private double _length { get; set; }
    private double _width { get; set; }

    public Rectangle(string color, double width, double length) : base(color)
    {

      _length = length;
      _width = width;

    }

    public override double getArea()
    {
      return _length * _width;
    }

  }
}