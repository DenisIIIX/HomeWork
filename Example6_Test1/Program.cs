namespace Example6_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            Console.Write("Что заменить: ");
            string find = Console.ReadLine();

            Console.Write("На что заменить: ");
            string replace = Console.ReadLine();

            string result = str.Replace(find, replace);


            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
