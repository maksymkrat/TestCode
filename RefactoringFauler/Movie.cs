namespace RefactoringFauler;

public class Movie
{
    public  static  int CHILDRENS = 2;
    public static  int REGULAR = 0;
    public static  int NEW_RELEASE = 1;

    private Price _price;

    private String _title;
    private int _priceCode;

    public Movie(string title, int priceCode)
    {
        _title = title;
        SetPriceCode(priceCode);
    }

    public int GetPriceCode()
    {
        return _price.GetPriceCode();
    }

    public void SetPriceCode(int arg)
    {
        if (REGULAR == arg)
        {
            _price = new RegularPrice();
        }
        else if(CHILDRENS == arg)
        {
            _price = new ChildrensPrice();
        }
        else if (NEW_RELEASE == arg)
        {
            _price = new NewReleasePrice();
        }
        else
        {
            throw new ArgumentException("Incorrect Price Code");
        }
    }

    public String GetTitle()
    {
        return _title;
    }

    public double getCharge(int daysRented)
    {
        return _price.getCharge(daysRented);
    }
    
    public int getFrequentRenterPoints(int daysRented)
    {
        return _price.getFrequentRenterPoints(daysRented);
    }

}