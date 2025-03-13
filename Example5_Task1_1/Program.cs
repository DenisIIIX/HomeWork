namespace Example5_Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            int pLus = 0;
            int mInus = 0;

            for (int i = 0; i<n; i++)
            {
                t[i] = rnd.Next(0, 101);
                if ((double)t[i]%2 == 0 || t[i] == 0)
                    ++pLus;
                else
                    ++mInus;
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();
            if (pLus > mInus)
                Console.WriteLine("Четных {0} > Нечетных {1}, Четных больше", pLus, mInus);
            else if (pLus == mInus)
                Console.WriteLine("Четных {0} > Нечетных {1}, Одинаковое количесвто четных и нечетных", pLus, mInus);
            else
                Console.WriteLine("Четных {0} > Нечетных {1}, Нечетных больше", pLus, mInus);
            Console.ReadKey(); ;
        }
    }
}
