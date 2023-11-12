
using System.Text;

class Program
{
    
   
    public static void Main(string[] args)
    {
        var drawing = new GraphicsObject {Name = "My Drawing"};
        drawing.Children.Add(new Square{Color = "red"});
        drawing.Children.Add(new Circle{Color = "yellow"});
        
        var group = new GraphicsObject ();
        group.Children.Add(new Square{Color = "Blue"});
        group.Children.Add(new Circle{Color = "Blue"});
        
        drawing.Children.Add(group);
        Console.WriteLine(drawing);
    }
    
}

public class GraphicsObject
{
    public virtual string Name { get; set; } = "Group";
    public string Color;

    private Lazy<List<GraphicsObject>> children = new Lazy<List<GraphicsObject>>(() => new List<GraphicsObject>());
    public List<GraphicsObject> Children => children.Value;

    private void Print(StringBuilder sb, int depth)
    {
        sb.Append(new string('*', depth))
            .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color}")
            .AppendLine($"{Name}");
        foreach (var child in Children)
        {
            child.Print(sb, depth + 1);
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }
}

public class Circle : GraphicsObject
{
    public override string Name => "Circle";
}

public class Square : GraphicsObject
{
    public override string Name => "Square";
   
}