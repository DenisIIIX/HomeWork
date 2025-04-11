using System.Threading.Channels;

namespace Example7_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a1 = 10;
            int b1 = 20;
            int c1 = 30;

            int a2 = 10;
            int b2 = 20;
            int c2 = 30;


            int[] t1 = { 10, 20, 15 };
            int[] t2 = { 5, 10, 10 };

            double s1 = Square(a1, b1, c1);
            double s2 = Square(a2, b2, c2);

            if (s2 > s1)
                Console.WriteLine("Площадь второго больше");
            else if (s2<s1)
                Console.WriteLine("Площадь первого больше");
            else Console.WriteLine("Площади равны");
        }
        static double Square(int a, int b, int c)
        {
            int p = a + b + c;
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }

    }

}
