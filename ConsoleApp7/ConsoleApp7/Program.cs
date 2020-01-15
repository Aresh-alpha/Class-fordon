using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fordon> fordonlista = new List<Fordon>();


            Fordon f = new Fordon("BMW", "M 3",2018, 10000 );
            Console.WriteLine(f.Tillverkare);
            Console.WriteLine(f.Modell);
            Console.WriteLine(f.Årsmodell);
            Console.WriteLine(f.Vikt);
          
            Fordon b = new Fordon("BMW", "M 5", 2016, 9000);
            Console.WriteLine(b.Tillverkare);
            Console.WriteLine(b.Modell);
            Console.WriteLine(b.Årsmodell);
            Console.WriteLine(b.Vikt);
            fordonlista.Add(new Fordon("Audi", "R8", 2017, 8000));
            foreach (Fordon element in fordonlista)
            {
                Console.WriteLine(element.Tillverkare);
                Console.WriteLine(element.Modell);
                Console.WriteLine(element.Årsmodell);
                Console.WriteLine(element.Vikt);
            }

        }
    }
}
