using P_Builder.hamburger.Products;

namespace P_Builder.hamburger;

public class HamburgerBuilder : IHamburgerBuilder
{
    private Hamburger _hamburger = new Hamburger();

    public Hamburger Build() => _hamburger;


    public IHamburgerBuilder BuildUpperRoll()
    {
        _hamburger.UpperRoll = "UPPER ROLL";
        return this;
    }

    public IHamburgerBuilder BuildMiddleProducts(Product product)
    {
       _hamburger.Products.Add(product);
       return this;
    }

    public IHamburgerBuilder BuildBottomRoll()
    {
        _hamburger.BottomRoll = "BOTTOM ROOL";
        return this;
    }

    public Hamburger GetHambutger()
    {
        Hamburger hamburger = _hamburger;
        _hamburger = new Hamburger();
        return hamburger;
    }
}