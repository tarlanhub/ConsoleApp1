using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] isimler = new string[]
            //{

            //    "Tarlan", "Abdullayev", "C", "C#"
            //};

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "Trump";
            //isimler[0] = "Donald";
            //Console.WriteLine( isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string>() {"tarlan", "Abdullayev", "Donald", "Trump"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("C");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
