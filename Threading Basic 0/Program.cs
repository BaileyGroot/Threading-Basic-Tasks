using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class program
{
    public void WorkThreadFunction()
    {
        // Looping through the method WorkThreadFunction and getting the thread names.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(Thread.CurrentThread.Name);
        }
    }
}
class threprog
{
    // Threads
    public static void Main()
    {
        program pg = new program();
        Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction));
        thread.Name = "Frederik";
        thread.Start();

        program pg2 = new program();
        Thread thread2 = new Thread(pg.WorkThreadFunction);
        thread2.Name = "Markus";
        thread2.Start();


        Console.Read();
    }
}