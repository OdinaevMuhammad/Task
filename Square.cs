public  class Square : Rectangle 
{
    protected double side = 0;
    public Square()
    {
        
    }
    public Square(double side)
    {
        this.side = side;
      
    }
    public Square(double side, string color , bool filled) : base(color , filled)
    {
        this.side = side;
         this.color = color;
        this.filled = filled;
      
    }
    public double getSide()
    {
        return side;
    }
    public void setSide(double side)
    {
        this.side = side;
    }
  
    public override void setWidth(double side)
    {
        this.side = side;
       
    }
       public override void setLength(double side)
    {
        this.side = side;
    }
  
  
     public override string  ToString()
     {
        return "Square , Rectangle" + color + "," + filled + ", "+  width + ", " + length;
     }

}