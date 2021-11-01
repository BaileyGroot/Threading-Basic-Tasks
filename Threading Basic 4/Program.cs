using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class program
{
    // Char with starting value *
    public char input = '*';

    // Input
    public void Input()
    {
        while (true)
        {
            // Getting key info
            ConsoleKeyInfo c = Console.ReadKey();
            Console.ReadLine();
            input = c.KeyChar;
        }

    }

    // Output
    public void Output()
    {
        while (true)
        {
            Console.Write(input);
            Thread.Sleep(250);
        }
    }
}
class threprog
{
    // Threads
    public static void Main()
    {
        program pg = new program();
        Thread Input = new Thread(pg.Input);
        Input.Start();

        program pg2 = new program();
        Thread Output = new Thread(pg.Output);
        Output.Start();
    }
}