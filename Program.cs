using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n =");
            int count = int.Parse(Console.ReadLine());
            double result = 0;
            for (int a = 1; a <= count; a++)
            {
                result = result = 1 / a;
            }
            Console.WriteLine($"r={result}"); 
        }
    }
}
