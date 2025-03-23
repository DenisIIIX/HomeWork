using System.Text.RegularExpressions;

namespace Example6_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер сот.телефона: ");
            string tel = Console.ReadLine();

            string pattern = @"^\+7\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}$";
            

            Regex regex = new Regex(pattern);
            if (regex.IsMatch(tel))
            {
                Console.WriteLine("{0} - Подходит", tel);
            }
            else Console.WriteLine("{0} - не Подходит", tel);

            Console.ReadKey();

           
        }
    }
}
