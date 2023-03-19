using System;


namespace Shapes
{

  class Program
  {
    static void Main(string[] args)
    {
      //Polymorphism
      // Console.WriteLine("Hello Learning05 World!");

      Square square = new Square("Red", 3);
      // Console.WriteLine(square.getColor());
      // Console.WriteLine(square.getArea());

      Rectangle rectangle = new Rectangle("Blue", 12, 10);
      // Console.WriteLine(rectangle.getColor());
      // Console.WriteLine(rectangle.getArea());

      Circle circle = new Circle("Yellow", 20);
      // Console.WriteLine(circle.getColor());
      // Console.WriteLine(circle.getArea());

      List<Shape> shapes = new List<Shape>();
      shapes.Add(square);
      shapes.Add(rectangle);
      shapes.Add(circle);
      shapes.ForEach(shape =>
      {
        Console.WriteLine(shape.getArea());
        Console.WriteLine(shape.getColor());
      }
      );
    }
  }
}