using System.Text;
using P_Builder;
using P_Builder.hamburger;
using P_Builder.hamburger.Products;

class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Ivan", 500),
            new Employee("Boris", 100),
            new Employee("Ivan", 200),
            new Employee("Bob", 300),
        };

        var builder = new EmployeeReportBuilder(employees);
        var director = new EmloyeeReportDirector(builder);
        
        director.Build();

        var report = builder.GetReport();
       // Console.WriteLine(report);
       Console.WriteLine("create hamburger");
       var cook = new HamburgerBuilder();
       var hamburger = cook.BuildUpperRoll()
           .BuildMiddleProducts(new Cutlet())
           .BuildMiddleProducts(new Mayounnaise())
           .BuildMiddleProducts(new Salat())
           .BuildMiddleProducts(new Tomato())
           .BuildMiddleProducts(new Cutlet())
           .BuildBottomRoll()
           .GetHambutger();

       Console.WriteLine(hamburger);
    }
    
    
    
}