using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur långt hoppade Elin mätt i meter?");
            double x = double.Parse(Console.ReadLine());
          
            Console.WriteLine("Hur långt hoppade Alma mätt i meter?");
            double y = double.Parse(Console.ReadLine());
            double skillnad = x - y;

            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma");
            Console.ReadKey();
        }
    }
}