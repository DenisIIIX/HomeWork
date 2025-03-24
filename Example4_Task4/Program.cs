namespace Example4_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            double n = 1;
            if (a > 0 && b < 0)
            {
                for (int i = 1; i <= b * (-1); i++)

                    n *= (double) 1/a;
                Console.WriteLine(n);
            }
            else

                Console.WriteLine("Введите число a > 0, число b < 0");

        }
    }
}
