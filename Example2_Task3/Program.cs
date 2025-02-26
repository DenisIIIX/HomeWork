using System;

namespace Example2_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int max1 = (a>=b) ? a : b;
            int max2 = (b>=c) ? b : c;
            int max3 = (c>=d) ? c : d;


            Console.WriteLine();
            Console.WriteLine("Ответm: {0}", max3);
            Console.ReadKey();
        }
    }
}
