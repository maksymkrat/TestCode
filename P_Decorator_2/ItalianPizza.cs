namespace P_Decorator_2
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}