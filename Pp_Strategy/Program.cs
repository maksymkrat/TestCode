public class Program
{
    public static void Main(string[] args)
    {
        
        Hero hero = new Hero("Squidward");
        hero.SetWeapon(new Plunger());
        hero.Attack();

        Console.ReadLine();
    }
}






public interface IWeapon
{
    void Shoot();
}

public class WaterGun : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("attacks with a water gun");
    }
}

public class Plunger : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("attacks with a plunger");
    }
}

public class Broom : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("attacks with a broom");
    }
}

public class Hero
{
    private readonly string _name;
    private IWeapon _weapon;

    public Hero(string name)
    {
        _name = name;
    }

    public void SetWeapon(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void Attack()
    {
        Console.WriteLine("start attack>>>>");
        if (_weapon is null)
        {
            Console.WriteLine($"{_name} can't attack. Set a weapon.");
            return;
        }

        Console.WriteLine($"{_name} stands menacingly");
        Console.Write($"{_name} ");
        _weapon.Shoot();
        Console.WriteLine($"{_name} ceases to stand menacingly" );
    }
}