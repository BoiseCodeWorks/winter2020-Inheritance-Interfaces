using System;
using inheritance.Interfaces;

namespace inheritance.Models
{
  public class Cirle : IArea
  {
    public float Radius { get; set; }
    public float Area()
    {
      return (float)(Math.PI * Math.Pow(Radius, 2));
    }
  }
}