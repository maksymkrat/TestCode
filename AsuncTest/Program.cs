

using System.Text;

public class Program
{
    public  static void Main(string[] args)
    {
        #region async

        // Console.WriteLine("begin");
        // DoWorkAsync();
        // Console.WriteLine("continue main");
        // for (int i = 0; i < 100; i++)
        // {
        //
        //     if (i % 10 == 0)
        //     {
        //         Console.WriteLine("main");
        //     }
        // }
        // Console.WriteLine("end main");
        // Console.ReadKey();

        #endregion

        // var result = SaveFileAsync("d:\\test.txt");
        // var x = Console.ReadLine();
        // Console.WriteLine(result.Result);

        
    }

    static async Task<bool> SaveFileAsync(string path)
    {
       var result = await Task<bool>.Run((() => SaveFile(path)));
       return result;
    }
    static bool SaveFile(string path)
    {
        var rnd = new Random();
        var text = "";

        for (int i = 0; i < 10000; i++)
        {
            text += rnd.Next();

        }

        using (var sw = new StreamWriter(path,false, Encoding.UTF8))
        {
            sw.WriteLine();
        }

        return true;
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("begin async");
         await Task.Run((() => DoWork()));
         Console.WriteLine(" end async");
    }

    static void DoWork()
    {
        for (int i = 0; i < 100; i++)
        { 

            if (i % 10 == 0)
            {
                Console.WriteLine("do 1");
            }
        }
    }
    
    static void DoWork2(object num)
    {
        for (int i = 0; i < (int)num; i++)
        {

            if (i % 10000 == 0)
            {
                Console.WriteLine("do 2");
            }
        }
    }
}