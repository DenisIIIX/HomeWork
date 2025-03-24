namespace Example4_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.WriteLine("Введите число в диапазоне от 20 до 60 включительно");
                n = Convert.ToInt32(Console.ReadLine());

            }
            while (n >60 || n < 20);


            Console.WriteLine("Вы ввели то самое число");


        }
    }
}
