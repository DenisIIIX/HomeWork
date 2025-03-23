namespace Example6_Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine(); 
            while (str.Contains("  ")) 
            {
                str = str.Replace("  ", " ");
            }
            str = str.Trim();

            Console.WriteLine(str);
            Console.ReadKey();  
        }
    }
}
