namespace P_Decorator_2
{
    public class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Bulgeran pizza")
        {
        }

        public override int GetCost()
        {
            return 8;
        }
    }
}