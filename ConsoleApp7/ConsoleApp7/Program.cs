using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fordon f = new Fordon();
            f.SetModell("M 5");
            f.SetTillverkare("BMW");
            f.SetÅrsmodell(2018);
            f.SetVikt(10000);
            Console.WriteLine(f.GetModell());
            Console.WriteLine(f.GetTillverkare());
            Console.WriteLine(f.GetÅrsmodell());
            Console.WriteLine(f.GetVikt());
            Fordon b = new Fordon();
            b.SetModell()
            


        }
    }
}
