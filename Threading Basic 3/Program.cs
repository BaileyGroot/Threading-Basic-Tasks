﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class program
{
    public void Generator()
    {
        int alarmcount = 0;

        while (alarmcount < 3)
        {
            Thread.Sleep(2000);
            Random rd = new Random();
            int rand_num = rd.Next(-20, 120);

            Console.WriteLine(rand_num);

            if (rand_num > 100)
            {
                Console.WriteLine("Alarm");
                alarmcount++;
            }
            else if (rand_num < 0)
            {
                Console.WriteLine("Alarm");
                alarmcount++;
            }
        }
    }
}
class threprog
{
    public static void Main()
    {
        program pg = new program();
        Thread generator = new Thread(pg.Generator);
        generator.Start();

        while (generator.IsAlive)
        {
            Thread.Sleep(10000);
        }
        Console.WriteLine("Alarm-tråd termineret!");
    }
}