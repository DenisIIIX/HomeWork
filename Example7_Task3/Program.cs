namespace Example7_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool reverse = false;
            const int n = 10;
            int[] numbers = new int[n];
            Random rnd = new Random();


            for (int i = 0; i<n; i++)
            {
                numbers[i] = rnd.Next(0, 51);
                Console.Write("{0} ", numbers[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Введите \"1\" для обратного порядка, \"0\" для прямого");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark == 1)
                reverse = true;

            PrintNumbers(numbers, reverse);


            Console.ReadKey();
        }
        static void PrintNumbers(int[] a, bool reverse = false)
        {
            int mark = a.Length-1;
            if (reverse)

                for (int i = mark; i >= 0; i--)
                    Console.Write("{0,3}", a[i]);
            else
                foreach (int element in a)
                    Console.Write("{0,3}", element);
        }
    }
}
