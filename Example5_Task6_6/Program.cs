namespace Example5_Task6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] t = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((double)i%2 != 0)
                        t[i, j] = (double)j%2 != 0 ? 1 : 0;
                    else
                        t[i, j] = (double)j%2 == 0 ? 1 : 0;

                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
