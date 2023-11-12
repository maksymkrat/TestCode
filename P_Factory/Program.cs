// See https://aka.ms/new-console-template for more information



public class Program
{

    public static void Main(string[] args)
    {

        // Creator creator = new CreatorA();
        // Product product = creator.FactryMethod();
        //
        // product.SomeToDo();
        //
        // creator = new CreatotB();
        // product = creator.FactryMethod();
        // product.SomeToDo();

        // Logistic logistic = new SeaLogistics();
        // Transport transport = logistic.CreateTransport();
        // transport.transportation();
        //
        // logistic = new RoadLoagistics();
        // transport = logistic.CreateTransport();
        // transport.transportation();

        //  Point point = Point.PointFactory.NewCartesianPoint(3,3);



        MembershipFactory membership = GetFactory("pool");
    }

    private static MembershipFactory GetFactory(string membershipType) => membershipType.ToLower() switch
    {
        "gym" => new GymMembershipFactory(100),
        "pool" => new GymPlusPoolMembershipFactory(100),
        "personal" => new PersolanMembershipFactory(100),
        _ => null
    };
}

#region test1

abstract class Product
{
    public abstract void SomeToDo();

}

class  ProductA : Product
{
    public override void SomeToDo()
    {
        Console.WriteLine("Product A");
    }
}
class  ProductB : Product
{
    public override void SomeToDo()
    {
        Console.WriteLine("Product B");
    }
}

abstract class Creator
{
    public abstract Product FactryMethod();
}

class CreatorA : Creator
{
    public override Product FactryMethod()
    {
        return new ProductA();
    }
}

class CreatotB : Creator
{
    public override Product FactryMethod()
    {
        return new ProductB();
    }
}


#endregion

#region test2


public class Point
{
    private double x, y;

    private Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "x = " + x +", "+ "y = " + y;
    }

    public static PointFactory Factory = new PointFactory();

    public class PointFactory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
    
        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho*Math.Cos(theta), theta*Math.Sign(theta));
        }
    }
   
}



#endregion

#region test3

abstract class Transport
{
   public abstract void transportation();
}

class Truck : Transport
{
    public override void transportation()
    {
        Console.WriteLine("ride on road");
    }
}

class Ship : Transport
{
    public override void transportation()
    {
        Console.WriteLine("sail the sea");
    }
}

abstract class Logistic
{
    public abstract Transport CreateTransport();
}

class RoadLoagistics : Logistic
{
    public override Transport CreateTransport()
    {
        return new Truck();
    }
}

class SeaLogistics : Logistic
{
    public override Transport CreateTransport()
    {
        return new Ship();
    }
}




#endregion

#region test4

public interface IMemberShip
{

    public string Name { get; }
    decimal GetPrice();

}

public class GymMembership : IMemberShip
 {
     private readonly string _name;
     private readonly decimal _price;
 
     public GymMembership(decimal price)
     {
         _name = "Gym membership"; 
         _price = price;
     }
 
     public string Name => _name;
     public decimal GetPrice() => _price;
 }

public class GymPlusPoolMembership : IMemberShip
{
    private readonly string _name;
    private readonly decimal _price;

    public GymPlusPoolMembership(decimal price)
    {
        _name = "Gym plus pool membership"; 
        _price = price;
    }

    public string Name => _name;
    public decimal GetPrice() => _price;
}

public class PersonalMembership : IMemberShip
{
    private readonly string _name;
    private readonly decimal _price;

    public PersonalMembership(decimal price)
    {
        _name = "PersonalMembership membership"; 
        _price = price;
    }

    public string Name => _name;
    public decimal GetPrice() => _price;
}

public abstract class MembershipFactory
{
    public abstract IMemberShip GetMembership();
}

public class GymMembershipFactory : MembershipFactory
{
    private readonly decimal _price;

    public GymMembershipFactory(decimal price)
    {
        _price = price;
    }

    public override IMemberShip GetMembership()
    {
        return new GymMembership(_price);
        
    }
}


public class GymPlusPoolMembershipFactory : MembershipFactory
{
    private readonly decimal _price;

    public GymPlusPoolMembershipFactory(decimal price)
    {
        _price = price;
    }

    public override IMemberShip GetMembership()
    {
        return new GymPlusPoolMembership(_price);
    }
}

public class PersolanMembershipFactory : MembershipFactory
{
    private readonly decimal _price;

    public PersolanMembershipFactory(decimal price)
    {
        _price = price;
    }

    public override IMemberShip GetMembership()
    {
        return new PersonalMembership(_price);
    }
}


#endregion
