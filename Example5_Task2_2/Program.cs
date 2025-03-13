namespace Example5_Taxk2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            for (int i = 0; i<n; i++)
            {
                t[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", t[i]);
            }

            Console.WriteLine();

            int pLus = 0;
            int mInus = 0;
            int zero = 0;
            foreach (int a in t)
            {
                if (a == 0)
                    ++zero;
                else if (a > 0)
                    ++pLus;
                else
                    ++mInus;
            }
            Console.WriteLine("Количество положительных - {0}, количество отрицательных - {1}, количество нулей - {2}", pLus, mInus, zero);
            Console.ReadKey();
        }
    }
}
