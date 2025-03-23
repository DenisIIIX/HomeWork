namespace Example4_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double res = 0;

            for (int i = 1; i <= n; i++)
                res += (double)1/i;

            Console.WriteLine(res);
        }
    }
}
