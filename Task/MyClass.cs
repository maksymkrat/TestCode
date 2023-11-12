namespace Task;

public class MyClass
{
    public int Operation()
    {
        
        Console.WriteLine("operation in thred {0}", Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        return 2 + 2;
    }

    public async void OperationAsync()
    {
        Console.WriteLine("operationAsync in thred {0}", Thread.CurrentThread.ManagedThreadId);
        Task<int> task = Task<int>.Factory.StartNew(Operation);
        Console.WriteLine("result: {0}", await task);
    }

}