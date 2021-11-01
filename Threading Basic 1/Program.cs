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
        }
    }
}
class threprog
{
    // Thread

    public static void Main()
    {
        program pg = new program();
        Thread print = new Thread(pg.Printing);
        print.Start();
    }
}