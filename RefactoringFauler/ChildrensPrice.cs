namespace RefactoringFauler;

public class ChildrensPrice : Price
{
    public override double getCharge(int daysRented)
    {
        double result = 1.5;
        if (daysRented > 3)
            result += (daysRented - 3) * 1.5;
        return result;
    }

    public override int GetPriceCode()
    {
        return Movie.CHILDRENS;
    }
}