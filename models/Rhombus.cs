namespace inheritance.Models
{
  class Rhombus : Rectangle
  {

    public override float Area()
    {
      return (Height * Width) / 2;
    }

    public Rhombus(float height, float baseLength) : base(height, baseLength)
    {
    }
  }
}