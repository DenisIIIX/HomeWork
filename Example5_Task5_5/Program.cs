namespace Example5_Task5_5
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
                t[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n/2-1; i++)
            {
                for (int j = i+1; j < n/2; j++)
                {
                    if (t[i]>t[j])
                    {
                        int temp = t[i];
                        t[i]=t[j];
                        t[j]=temp;
                    }
                }
            }

            for (int k = 5; k < n - 1 && k > n/2-1; k++)
            {
                for (int l = k+1; l < n; l++)
                {
                    if (t[k] < t[l])
                    {
                        int temp = t[k];
                        t[k]=t[l];
                        t[l]=temp;
                    }
                }
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
