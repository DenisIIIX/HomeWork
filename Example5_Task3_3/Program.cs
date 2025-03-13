namespace Example5_Task3_3
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
                t[i] = rnd.Next(0, 51);
                Console.Write("{0} ", t[i]);
            }

            Console.WriteLine();

            int max = t[0];
            int indexMax = 0;
            int min = t[0];
            int indexMin = 0;

            for (int i = 0; i<n; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                    indexMax = i;
                }
                else if (t[i] < min) 
                {
                    min = t[i];
                    indexMin = i;
                }
            }
            Console.WriteLine("{0}, {1}", max, indexMax);
            Console.WriteLine("{0}, {1}", min, indexMin);
            Console.ReadKey();
        }
    }
}
