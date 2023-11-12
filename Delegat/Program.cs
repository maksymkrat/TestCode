using System;

namespace Delegat
{
    internal class Program
    {

        public delegate void LogMathOperation(int x, int y);
        
        public static void Main(string[] args)
        {
            // LogMathOperation additionLogging = Add_Logs;
            // LogMathOperation subtracctLogging = Subtract_Logs;
            // LogMathOperation multiplyLogging = (int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");
            // LogMathOperation divisionLogging = Divide_Logs;
            //
            // Console.WriteLine("first example");
            // additionLogging(30, 5);
            // subtracctLogging(30, 5);
            // multiplyLogging(30, 5);
            // divisionLogging(30, 5);
            //
            // LogMathOperation allOperationLogging = additionLogging + subtracctLogging + multiplyLogging + divisionLogging;
            //
            // Console.WriteLine();
            // Console.WriteLine("suma delegats");
            // allOperationLogging(20, 5);
            //
            // LogMathOperation allOperationLogging2 = additionLogging;
            //  allOperationLogging2 += subtracctLogging;
            //  allOperationLogging2 += multiplyLogging;
            //  allOperationLogging2 += divisionLogging;
            //  
            //  Console.WriteLine();
            //  Console.WriteLine("suma delegats example2");
            //  allOperationLogging2(20, 5);

            // PerformOperationWithLogging(Add_Logs, 50, 10);
            //
            // var result = PerformOperation(Subtract, 50, 5);
            // Console.WriteLine(result);


            StockExchange stockExchange = new StockExchange();
            stockExchange.PriceChangeHandler = ShowPrice;
            stockExchange.Start();
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"{price }");
        }

        static void Add_Logs(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
        static void Subtract_Logs(int x, int y) => Console.WriteLine($"{x} - {y} = {x - y}");
        static void Multiply_Logs(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");
        static void Divide_Logs(int x, int y) => Console.WriteLine($"{x} / {y} = {(y == 0 ? 0 : x / y)}");

        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;
        static int Divide(int x, int y) => y == 0 ? 0 : x / y;


        static void PerformOperationWithLogging(Action<int, int> operatorWithLogging, int x, int y) => operatorWithLogging(x, y);
        static int PerformOperation(Func<int, int,int> operatorWithLogging, int x, int y) => operatorWithLogging(x, y);
    }
}   


        // Action<int, int> = void SomeMethodDelegat(int x , int y);
        //Func<int, int,int> = int SomeMethod(int x, int y)