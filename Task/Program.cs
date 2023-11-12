
using Task;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("main thredID {0}", Thread.CurrentThread.ManagedThreadId);
        MyClass myClass = new MyClass();

        myClass.OperationAsync();
    }
}