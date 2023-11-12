

using System.Collections.ObjectModel;



public class Program
{
    
    List<VectorObject> vectorObjects = new List<VectorObject>
    {
        new VectorRectangle(1,1,10,10),
        new VectorRectangle(3,3,6,6)
    };
    static void DrawPoint(Point p)
    {
        Console.Write(".");
    }

    public static void Main(string[] args)
    {
         
    }
    
}


public class Point
{
    public int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
    }
}

public class Line
{

    public Point Start, End;
    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }
}

public abstract class VectorObject : Collection<Line>
{
    
}

public class VectorRectangle : VectorObject
{
    public VectorRectangle(int x, int y, int widht, int height)
    {
        Add(new Line(new Point(x,y), new Point(x+widht,y)));
        Add(new Line(new Point(x+widht, y), new Point(x+widht, y +height)));
        Add(new Line(new Point(x,y), new Point(x,y+height)));
        Add(new Line(new Point(x, y+height), new Point(x+widht, y +height)));
    }
}

public class LineToPointAdapter : Collection<Point>
{
    private static int count = 0;
    public LineToPointAdapter(Line line)
    {
       
    }
}