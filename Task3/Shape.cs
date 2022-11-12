public abstract class Shape
{
    public  Color color ;
    public bool filled = true;
    public Shape()
    {
        
    } 
    public Shape(Color color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public Color GetColor()
    {
        return color;
    }
    public void SetColor(Color color)
    {
        this.color = color;
    }
     public abstract double GetArea();
     public abstract double GetPerimetr();

     public override  string ToString()
     {
        return "Shape" + "["+ color + "," + filled + "]";
     }

}
     public enum Color
     {
        red,
        blue,
        green,
        black
     }
 