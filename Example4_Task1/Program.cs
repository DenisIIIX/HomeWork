using System.Runtime.Serialization.Formatters;

namespace Example4_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int f = 1;
            for (int i = 1; i<=n; i++)
            {
                f *= i;
                            }
            Console.WriteLine(f);
        }
    }
}
