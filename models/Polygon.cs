using System;
using System.Collections.Generic;

namespace inheritance.Models
{
  abstract class Polygon
  {
    public int Sides { get; set; }

    public List<float> SideLengths { get; set; }

    public float Perimeter()
    {
      float total = 0;
      foreach (float s in SideLengths)
      {
        total += s;
      }
      return total;
    }

    public Polygon(int sides, List<float> sideLengths)
    {
      Sides = sides;
      SideLengths = sideLengths;
    }
  }
}