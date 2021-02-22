using System;
using System.Collections.Generic;

namespace inheritance.Models
{
  class EquilateralTriangle : Triangle
  {
    public float SideLength { get; set; }

    public EquilateralTriangle(float sideLength) : base(new List<float>() { sideLength, sideLength, sideLength })
    {
      SideLength = sideLength;
    }

    public override float Area()
    {
      return (float)Math.Sqrt(3) / 4 * (SideLength * SideLength);
    }



  }
}