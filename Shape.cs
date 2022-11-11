public abstract class Shape
{
    protected string color = "red";
    protected bool filled = true;
    public Shape()
    {
        
    }
    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public string getColor()
    {
        return color;
    }
    public void setColor(string color)
    {
        this.color = color;
    }
    public bool isFilled()
    {
        return filled = false;
    }
    public void setFilled(bool filled)
    {
        this.filled = filled;
    }
    public abstract double getArea();
     public abstract double getPerimetr();
     public override  string ToString()
     {
        return "Shape" + color + "," + filled;
     }

    
}