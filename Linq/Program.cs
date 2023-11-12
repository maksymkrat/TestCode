

class Program
{
    public static string sss { get; set; }
    public static void Main(string[] args)
    {
        // Numbers numbers = new Numbers();
        // foreach (int n in numbers)
        // {
        //     Console.WriteLine(n);
        // }

        // string[] arr = {"Tom", "Bob", "Tim", "Kus", "Bill"};
        //
        //
        // List<string> list = new List<string>();
        // list.Add("one");
        // list.Add("two");
        // list.Add("tree");
        // list.Add("four");
        //
        // var x = 3;
        // Console.WriteLine(list.Where(x => x.Contains("o")));

        // var selectedName = arr.Where(x => x.StartsWith("T"));
        // foreach (var VARIABLE in selectedName)
        // {
        //     Console.WriteLine(VARIABLE);
        // }
        //
        // Random rand = new Random();
        // int addSeconds = rand.Next(1200);
        // Console.WriteLine(addSeconds);
        int x = 10;
        int y = 3;
        int result = x % y;
    }
}

class Numbers
{
    public IEnumerator<int> GetEnumerator()
    {

        yield return 1;
        yield return 5;
        yield return 3;

    }
}
 

