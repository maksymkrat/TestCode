

// shape: square, circle/ triangle
// rendere: raster, vectro

public interface IRenderer
{
    void RenderCircle(float radius);
}
public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"drawing circle of radius {radius}");
    }
}
public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"drawing pixels for circle of radius {radius}");
    }
}


public abstract class Shape
{
    protected IRenderer renderer;

    protected Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public abstract void Draw();
    public abstract void Resize(float factor);
}

public class Cirle : Shape
{
    private float radius;


    public Cirle(IRenderer renderer, float radius) : base(renderer)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
       renderer.RenderCircle(radius);
    }

    public override void Resize(float factor)
    {
        radius *= factor;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // var raster = new RasterRenderer();
        // var vector = new VectorRenderer();
        // var circle = new Cirle(vector, 3);
        //
        // circle.Draw();
        // circle.Resize(4);
        // circle.Draw();
        
    }
}