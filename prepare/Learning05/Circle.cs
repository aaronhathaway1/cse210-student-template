using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
  public class Circle : Shape
  {
    private double PI = Math.PI;
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
      _radius = radius;
    }

    public override double getArea()
    {
      return PI * _radius * _radius;
    }

  }
}