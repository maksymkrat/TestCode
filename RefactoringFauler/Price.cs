namespace RefactoringFauler;

public abstract class Price
{
    public abstract int GetPriceCode();

    public abstract double getCharge(int daysRented);
    
    public virtual int getFrequentRenterPoints(int daysRented)
    {
        return 1;
    }
}