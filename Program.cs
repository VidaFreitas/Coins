using System;
using System.Globalization;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 115.25m;
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}
