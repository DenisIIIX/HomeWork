using System.Text;

namespace Example6_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите своё город: ");
            string city = Console.ReadLine();

            StringBuilder sb = new StringBuilder("Имя: [имя], Возраст: [возраст], Город: [город]");
            sb.Replace("[имя]", name);
            sb.Replace("[возраст]", age);
            sb.Replace("[город]", city);

            Console.WriteLine(sb);
        }
    }
}
