using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class program
{
    public void Printing()
    {
        // Looping through the method Printing.

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("C#-trådning er nemt!");
            Thread.Sleep(1000);
        }
    }

    public void Printing2()
    {
        // Looping through the method Printing2.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Også med flere tråde …");
            Thread.Sleep(1000);
        }
    }
}
class threprog
{

    // Threads
    public static void Main()
    {
        program pg = new program();
        Thread print = new Thread(pg.Printing);
        print.Start();

        program pg2 = new program();
        Thread print2 = new Thread(pg.Printing2);
        print2.Start();
    }
}