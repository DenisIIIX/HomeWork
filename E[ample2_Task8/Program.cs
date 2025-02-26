namespace E_ample2_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a <= 10 && a >= -10)
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
