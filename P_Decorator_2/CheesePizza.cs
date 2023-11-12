namespace P_Decorator_2
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + ", with cheese", pizza)
        {
        }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}