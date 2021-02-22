using System.Collections.Generic;

namespace inheritance.Models
{
  class Trapazoid : Polygon
  {
    public Trapazoid(int sides, List<float> sideLengths) : base(sides, sideLengths)
    {
    }
  }
}