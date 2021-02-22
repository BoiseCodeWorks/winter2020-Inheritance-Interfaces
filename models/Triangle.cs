using System.Collections.Generic;
using inheritance.Interfaces;

namespace inheritance.Models
{
  class Triangle : Polygon, IArea
  {
    public float Base { get; set; }
    public float Height { get; set; }

    public virtual float Area()
    {
      return (Base * Height) / 2;
    }

    public Triangle(List<float> sideLengths) : base(3, sideLengths)
    {
    }
  }
}