namespace Example2_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a / 10 >= 1 && a / 10 <= 9 && a % 10 >=0)
            {
                Console.WriteLine("Да");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Нет");
                Console.ReadKey();
            }

        }
    }
}
