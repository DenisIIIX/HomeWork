namespace Example6_Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            int g = 0, s = 0;

            for (int i = 0; i<str.Length; i++) 
            {
                if (char.IsLetter(str[i]))
                {
                    if ("aeiouаеёиоуыэюя".Contains(str[i]))
                        g++;
                    else s++;
                }   
            }

            Console.WriteLine("Гласных - {0}. \nСогласных - {1}", g, s);
            Console.ReadKey();
        }

    }
}
