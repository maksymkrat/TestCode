using System.Text;
using P_Builder.hamburger.Products;

namespace P_Builder.hamburger;

public class Hamburger
{
    public string UpperRoll { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
    public string BottomRoll { get; set; }
    
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder()
            .Append(UpperRoll);
        foreach (var product in Products)
        {
            stringBuilder.Append($"\n{product.Name}");
        }
        ;
        stringBuilder
            .Append(Environment.NewLine)
            .Append(BottomRoll);
        return stringBuilder.ToString();
    }
}