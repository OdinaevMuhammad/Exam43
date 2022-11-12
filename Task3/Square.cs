public  class Square : Rectangle
{
    public  double side = 1.0;
    public Square()
    {
        
    }
    public Square(double side)
    {
        this.side = side;
      
    }
  public Square(double side, Color color, bool filled) : base(color,filled)
  {
    this.side = side;
    this.color = color;
    this.filled = filled;
  }
    public double GetSide()
    {
        return side;
    }
    public void SetSide(double side)
    {
        this.side = side;
    }
  
    public override void SetWidth(double side)
    {
        this.side = side;
       
    }
    public override void SetLength(double side)
    {
        this.side = side;
    }
  
    public override string  ToString()
     {
        return "Square" + "[" +  "Rectangle" + color + "," + filled + ", "+  width + ", " + length + "]";
     }

}