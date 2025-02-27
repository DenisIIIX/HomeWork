namespace Example2_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int eq = 0;

            if (a >= c && a <= b)
                eq = a;
            if (a >= b && a <= c)
                eq = a;
            if (b >= a && b <= c)
                eq = b;
            if (b >= c && b <= a)
                eq = b;
            if (c >= b && c <= a)
                eq = c;
            if (c >= a && a <= b)
                eq = c;

            Console.WriteLine(eq);  

            //int eq1 = (a>=b) ? a : b;
            //int eq2 = (eq1<=c) ? eq1 : c;
            //int eq3 = (eq2<=c) ? eq1 : c;


        }
    }
}
