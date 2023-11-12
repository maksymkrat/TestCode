

using System.Reflection;

class Program
{
    delegate void Deleg( string str);

    private static event Deleg Notify;
    
    public static void Main(string[] args)
    {
        Employee employee = new Employee("bob");
        Employee employee1 = employee;
        Deleg deleg;


        Notify += Display;
        
        Notify.Invoke("kus");

    }

    public static void Display(string str) => Console.WriteLine(str);


}



public class Person : IJumping
{

    private string CardPass = "12345";
    public string Many { get; set; }
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    public void EatM()
    {
        Console.WriteLine("eat");
    }
    
    
    public void JumpM()
    {
        Console.WriteLine("jump");
    }
}

public class Employee : Person
{
    public void WorkM()
    {
        Console.WriteLine("work");
    }

    public Employee(string name) : base(name)
    {
        
    }
}
public interface IJumping
{
    public void JumpM();
}


abstract class Component
{
    public abstract void Operation();
}
class ConcreteComponent : Component
{
    public override void Operation()
    {
        
        
    }
}
abstract class Decorator : Component
{
    protected Component component;
 
    public void SetComponent(Component component)
    {
        this.component = component;
    }
 
    public override void Operation()
    {
        if (component != null)
            component.Operation();
    }
}
class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation();
    }
}
class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
    }
}