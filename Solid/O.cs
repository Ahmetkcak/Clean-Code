using System;

#region Circle
public class NotOpenClosedCircle
{
    public double Radius { get; set; }
    public double CalculateArea
    {
        get { return Math.PI * Math.Pow(Radius, 2); }
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}
#endregion

#region Rectangle
public class NotOpenClosedRectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int CalculateArea
    {
        get { return Width * Height; }
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}
#endregion
