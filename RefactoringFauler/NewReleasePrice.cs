namespace RefactoringFauler;

public class NewReleasePrice : Price
{
    public override double getCharge(int daysRented)
    {
        return daysRented * 3;
    }

    public override int GetPriceCode()
    {
        return Movie.NEW_RELEASE;
    }

    public override int getFrequentRenterPoints(int daysRented)
    {
        return (daysRented > 1) ? 2 : 1;
    }
}