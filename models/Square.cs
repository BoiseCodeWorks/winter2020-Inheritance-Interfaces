using System.Collections.Generic;

namespace inheritance.Models
{
  class Square : Rectangle
  {


    public Square(float sideLength) : base(sideLength, sideLength)
    {
    }
  }
}