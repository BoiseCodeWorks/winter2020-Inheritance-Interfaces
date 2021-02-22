using System;
using System.Collections.Generic;
using inheritance.Interfaces;
using inheritance.Models;

namespace inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      List<IArea> myPolys = new List<IArea>()
      {
          new Rectangle(3,2),
          new Square(5),
          new Rhombus(3,4),
          new Triangle(new List<float>(){4,5,6}),
          new EquilateralTriangle(5),
          new Cirle()
      };

      foreach (Polygon p in myPolys)
      {
        if (p is Rhombus)
        {
          Rhombus r = (Rhombus)p;
          System.Console.WriteLine(r);
        }




      }
    }
  }
}
