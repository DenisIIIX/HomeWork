namespace Example5_Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 11);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n/2; i++)
            {
                    int temp = t[i];
                    t[i]=t[n-1-i];
                    t[n-1-i]=temp;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", t[i]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
