public class Circle : Shape
{
    protected double radius = 1.0;

    public Circle()
    {
        
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius , string color, bool filled) : base (color , filled)
    {
        this.radius = radius;
        this.color = color;
        this.filled = filled;
    }
    public double getRadius()
    {
        return radius;
    }
    public void setRadius(double radius)
    {
        this.radius = radius;
    }
   
    public override double getArea()
    {
        return Math.PI * radius * radius;
    }
     public override double getPerimetr()
     {
        return 2 * Math.PI * radius;
     }
     public override string ToString()
     {
        return "Circle" + color + ", " + filled + ", " + radius;
     }

    
}