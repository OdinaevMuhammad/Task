using System.Reflection.Metadata.Ecma335;
public class Rectangle : Shape
{
    protected double width = 1.0;
     protected double length = 1.0;

public Rectangle()
{
    
}
  public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }
      public Rectangle(double width, double length, string color_ , bool filled_) : base(color_, filled_)
    {
        this.width = width;
        this.length = length;
        color = color_;
        filled = filled_;
    }
    public double getWidth()
    {
        return width;
    }
    public virtual void setWidth(double width)
    {
        this.width = width;
    }
    public double getLength()
    {
        return length;
    }
    public virtual void setLength(double length)
    {
        this.length = length;
    }
    public override double getArea()
    {
        return width * length;
    }
     public override double getPerimetr()
     {
        return 2  * (length + width);
     }
     public override string ToString()
     {
        return "Shape" + color + "," + filled + ", " + width + ", " + length;
     }
}