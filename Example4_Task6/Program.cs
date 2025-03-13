namespace Example4_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double res;
            

            for (int i = 2; n / i >= 2; i *= 2)
            {
                
                res = (double) n /  i;
                if (res % 1 > 0)
                {
                    Console.WriteLine("НЕТ. Число НЕ является степенью 2ки");
                    break;
                }
                else if (res == 2)
                    Console.WriteLine("ДА. Число является степенью 2ки");
                else 
                    continue;

            }
            
        }
    }
}
