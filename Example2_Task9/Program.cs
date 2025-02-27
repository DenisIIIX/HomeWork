namespace Example2_Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 10 && a > -10)
            {
                Console.WriteLine("Нет");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Да");
                Console.ReadKey();
            }
        }
    }
}
