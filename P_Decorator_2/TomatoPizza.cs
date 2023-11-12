namespace P_Decorator_2
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza( Pizza pizza) : base(pizza.Name + ", with tomato", pizza)
        {
        }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}