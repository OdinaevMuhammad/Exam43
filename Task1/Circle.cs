public class Circle
{
    public double radius { get; set; }
    public double PI = 3.14;

    public Circle()
    {
        
    }
    public Circle(double _radius)
    {
        radius = _radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double _radius)
    {
        radius = _radius;
    }
    public double GetArea()
    {
        return PI * radius * radius;
    }
    public double GetCircumference()
    {
        return 2 * PI * radius;
    }
    public override string ToString()
    {
        return "Circle :" + radius;
    }
}