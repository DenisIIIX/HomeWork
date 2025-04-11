namespace Example6_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            string res = str.ToLower();
            res = res.Replace(" ", "");

            char[] resrev = new char[res.Length];

            for (int i = 0; i < res.Length; i++)
                resrev[i] = res[res.Length-1-i];

            string revers = new string(resrev);

            if (String.Compare(res, revers) == 0)

                Console.WriteLine("Строки являются полиндромом");

            else
                Console.WriteLine("Строки не являются полиндромом");

           
            Console.ReadKey();
        }
    }
}
