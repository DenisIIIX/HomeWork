namespace Example6_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            string[] result = str.Split(" ");

            int mark = 0;

            for (int i = 1; i < result.Length; i++)

                if (result[i].Length > result[mark].Length)
                    mark = i;

            Console.WriteLine(result[mark]);
            Console.ReadKey();
        }
    }
}
