﻿using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Tarlan");

            Console.WriteLine(isimler.Length);
            isimler.Add("Tarlan");

            Console.WriteLine("Hello World!");
        }
    }
}
