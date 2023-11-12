using System.Numerics;

namespace RefactoringFauler;

public class Customer
{
    private String _name;
    private List<Rental> _rentals = new List<Rental>();

    public Customer(String name)
    {
        _name = name;
    }

    public void addRental(Rental arg)
    {
        _rentals.Add(arg);
    }

    public String getName()
    {
        return _name;
    }


    public String Statement()
    {
        List<Rental> rentals = _rentals;
        String result = "Rent accounting for " + getName() + "\n";
        foreach (var nexElement in _rentals)
        {
            Rental each = nexElement;
            result += "\t" + each.getMovie().GetTitle() + "\t" + each.GetCharge().ToString() + "\n";
        }

        result += "THe sum" + GetTotalCharge() + "\n";
        result += "You earned" + GetTotalFrequentRenterPoints() + "points of activity";
        return result;
    }
    
    public String HTMLStatement()
    {
        List<Rental> rentals = _rentals;
        String result = "<h1>Rent accounting for <em> " + getName() + "</em></h1><p>\n";
        foreach (var nexElement in _rentals)
        {
            Rental each = nexElement;
            result += "\t" + each.getMovie().GetTitle() + "\t" + each.GetCharge().ToString() + "<br>\n";
        }

        result += "<p>THe sum <em> " + GetTotalCharge() + "</em><p>\n";
        result += "You earned <em>" + GetTotalFrequentRenterPoints() + " </em> points of activity <p>";
        return result;
    }



    private int GetTotalFrequentRenterPoints()
    {
        int result = 0;
        List<Rental> rentals = _rentals;
        foreach (var rent in rentals)
        {
            Rental each = rent;
            result += each.getFrequentRenterPoints();

        }

        return result;
    }

    private double GetTotalCharge()
    {
        double result = 0;
        List<Rental> rentals = _rentals;
        foreach (var rent in rentals)
        {
            Rental each = rent;
            result += each.GetCharge();

        }

        return result;
    }
}