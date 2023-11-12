using P_Builder.hamburger.Products;

namespace P_Builder.hamburger;

public interface IHamburgerBuilder
{
    IHamburgerBuilder BuildUpperRoll();
    IHamburgerBuilder BuildMiddleProducts(Product product);
    IHamburgerBuilder BuildBottomRoll();

    Hamburger GetHambutger();
}