namespace P_Decorator_2
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        protected PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }
}