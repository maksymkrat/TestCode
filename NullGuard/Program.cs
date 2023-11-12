
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        PrintUpper(null);
        object x = "d";
        object c = new string("d");
        
        Console.WriteLine(x.GetHashCode());
        Console.WriteLine(c.GetHashCode());

        Console.WriteLine(x == c);
        Console.WriteLine(x.Equals(c));

        IDictionary<string, int> elements = new SortedList<string, int>();
        IList<string> IList = new List<string>();
        
        IEnumerable values = new int[] { 5, 8, 12, 6 };
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        LinkedList<string> linkedList = new LinkedList<string>();
        HashSet<string> hashSet = new HashSet<string>();
        
        Person person = new Person("Bob");
        person.Print();     // Bob
        Employee employee = new Employee("Tom", "Microsoft");
        employee.Print();   // Tom
    }
    
    


    static void  PrintUpper(string text)
    {
      
        
            Console.WriteLine(text?.ToUpper());
         
    }
    
    public class MyClass
    {
        public int G { get; set; }
    }
    
    class Person
    {
        public string Name { get; set;}
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
 
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            
            Company = company;
        }
    }
}