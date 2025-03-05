namespace Example4_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            if (a > 0 && b > 0)
            {
                for (int i = 1; i <= b; i++)
                    n *= a;
                Console.WriteLine(n);
            }
            else 
            
                Console.WriteLine("Введите числа больше 0");
            
        }
    }
}
