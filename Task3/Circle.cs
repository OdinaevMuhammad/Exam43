public class Circle : Shape
{
    public double radius = 1.0;

    public Circle()
    {
        
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius, Color color, bool filled) : base(color , filled)
    {
        this.radius = radius;
        this.color = color;
        this.filled = filled;
    }
    public double GetRadius()
    {
        return radius;
    }
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
     public override double GetPerimetr()
     {
        return 2 * Math.PI * radius;
     }
     public override string ToString()
     {
        return "Circle" + "[" + color + ", " + filled + ", " + radius + "]";
     }

    
}