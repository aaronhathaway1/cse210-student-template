using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
  public abstract class Shape
  {
    private string _color;

    public string getColor()
    {
      return _color;
    }

    public void setColor(string color)
    {
      _color = color;
    }

    public Shape(string color)
    {
      setColor(color);
    }

    public abstract double getArea();




  }
}