public class Rectangle : Shape
{
    public double width = 1.0;
    public double length = 1.0;

    public Rectangle()
    {
        
    }
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }
    public Rectangle(double width, double length, Color color , bool filled) : base(color, filled)
    {
        this.width = width;
        this.length = length;
        this.color = color;
        this.filled = filled;
    }
    public double GetWidth()
    {
        return width;
    }
    public virtual void SetWidth(double width)
    {
        this.width = width;
    }
    public virtual double GetLength()
    {
        return length;
    }
    public virtual  void SetLength(double length)
    {
        this.length = length;
    }
    public override double GetArea()
    {
        return width * length;
    }
     public override double GetPerimetr()
     {
        return 2  * (length + width);
     }
     public override string ToString()
     {
        return "Shape" + "[" + color + "," + filled + ", " + width + ", " + length + "]";
     }

}