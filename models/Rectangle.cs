using System.Collections.Generic;
using inheritance.Interfaces;

namespace inheritance.Models
{
  class Rectangle : Polygon, IArea
  {
    public float Height { get; set; }
    public float Width { get; set; }


    public virtual float Area()
    {
      return Height * Width;
    }


    public Rectangle(float height, float width) : base(4, new List<float>() { height, height, width, width })
    {
      Height = height;
      Width = width;
    }
  }
}