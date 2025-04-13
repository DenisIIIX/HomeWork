namespace Example7_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const int n = 10;
            int[] numbers = new int[n];
            Random rnd = new Random();


            for (int i = 0; i<n; i++)
            {
                numbers[i] = rnd.Next(0, 51);
                
            }

            int max = FindMax(numbers);

            foreach (int number in numbers)
                Console.Write("{0,4}", number);
            Console.WriteLine();

            Console.WriteLine($"Максимально занчение = {max}");
            Console.ReadKey();

            
        }
        static int FindMax(params int[] a)
        {
            int max = 0;

            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] > max)

                    max = a[i];
            }
            return max;

        }
    }
}