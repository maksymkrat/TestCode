// See https://aka.ms/new-console-template for more information

Console.WriteLine("start");

//
//
// Thread mainThread = Thread.CurrentThread;
//
// mainThread.Name = "Main thread";
//
// Thread thread1 = new Thread((() => { CountDown(); }));
// Thread thread2 = new Thread((() => { CountUp(); }));
// thread1.Start();
// thread2.Start();
//
// Console.WriteLine(mainThread.Name + "is complete");
//  void CountDown(){
//   for (int i = 100; i >= 0; i--)
//   {
//       Console.WriteLine($"Timer #1 : {i} seconds");
//       //Thread.Sleep(1000);
//   }
//
//   Console.WriteLine($"Time #1 complete!");
//
// }
//
// void CountUp(){
//     for (int i = 0; i <= 100; i++)
//     {
//         Console.WriteLine($"Timer #2 : {i} seconds");
//        // Thread.Sleep(1000);
//     }
//
//     Console.WriteLine($"Time #2 complete!");
//
// }


// int x = 0;
// object locker = new();  // объект-заглушка
// // запускаем пять потоков
// for (int i = 1; i < 6; i++)
// {
//     Thread myThread = new(Print);
//     myThread.Name = $"Поток {i}";   // устанавливаем имя для каждого потока
//     myThread.Start();
// }
//  
// void Print()
// {
//     lock (locker)
//     {
//        x = 1;
//         for (int i = 1; i < 6; i++)
//         {
//             Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//             x++;
//             Thread.Sleep(100);
//         }
//
//         Console.WriteLine(" ---");
//     }
// }


// int x = 0;
// object locker = new();  // объект-заглушка
// // запускаем пять потоков
// for (int i = 1; i < 6; i++)
// {
//     Thread myThread = new(Print);
//     myThread.Name = $"Поток {i}";
//     myThread.Start();
// }
//  
// void Print()
// {
//     bool acquiredLock = false;
//     try
//     {
//         Monitor.Enter(locker, ref acquiredLock);
//         x = 1;
//         for (int i = 1; i < 6; i++)
//         {
//             Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//             x++;
//             Thread.Sleep(100);
//         }
//     }
//     finally
//     {
//         if (acquiredLock) Monitor.Exit(locker);
//     }
// }





// int x = 0;  // общий ресурс
//  
// AutoResetEvent waitHandler = new AutoResetEvent(true);  // объект-событие
//  
// // запускаем пять потоков
// for (int i = 1; i < 6; i++)
// {
//     Thread myThread = new(Print);
//     myThread.Name = $"Поток {i}";
//     myThread.Start();
// }
//  
//  
// void Print()
// {
//     waitHandler.WaitOne();  // ожидаем сигнала
//     x = 1;
//     for (int i = 1; i < 6; i++)
//     {
//         Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//         x++;
//         Thread.Sleep(100);
//     }
//     waitHandler.Set();  //  сигнализируем, что waitHandler в сигнальном состоянии
// }



// int x = 0;
// Mutex mutexObj = new();
//  
// // запускаем пять потоков
// for (int i = 1; i < 6; i++)
// {
//     Thread myThread = new(Print);
//     myThread.Name = $"Поток {i}";
//     myThread.Start(); 
// }
//  
// void Print()
// {
//     mutexObj.WaitOne();     // приостанавливаем поток до получения мьютекса
//     x = 1;
//     for (int i = 1; i < 6; i++)
//     {
//         Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//         x++;
//         Thread.Sleep(100);
//     }
//     mutexObj.ReleaseMutex();    // освобождаем мьютекс
// }



// запускаем пять потоков
for (int i = 1; i < 6; i++)
{
    Reader reader = new Reader(i);
}

class Reader
{
    // создаем семафор
    static Semaphore sem = new Semaphore(3, 3);
    Thread myThread;
    int count = 3; // счетчик чтения

    public Reader(int i)
    {
        myThread = new Thread(Read);
        myThread.Name = $"Читатель {i}";
        myThread.Start();
    }

    public void Read()
    {
        while (count > 0)
        {
            sem.WaitOne(); // ожидаем, когда освободиться место

            Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

            Console.WriteLine($"{Thread.CurrentThread.Name} читает");
            Thread.Sleep(10000);

            Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

            sem.Release(); // освобождаем место

            count--;
            Thread.Sleep(10000);
        }
    }
}