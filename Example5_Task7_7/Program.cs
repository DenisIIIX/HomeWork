namespace Example5_Task7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] t = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int max = 0;
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = rnd.Next(0, 11);
                    max = t[i, j] > max ? t[i, j] : max;

                    Console.Write("{0,4} ", t[i, j]);
                }
                Console.WriteLine(" Max ={0,3} ", max);
            }
            Console.ReadKey();
        }
    }
}
