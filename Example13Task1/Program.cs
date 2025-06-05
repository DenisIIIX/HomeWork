namespace Example13Task1
{
    internal class Program
    {
        public delegate int Transformer(int number);

        public static int[] Transform(int[] numbers, Transformer condition)
        {
            int[] result = new int[numbers.Length];
            int index = 0;
            foreach (var number in numbers)
            {
                result[index]= condition(number);
                index++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, -2, 3, 4, -5 };
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine();

            int[] num1 = Transform(numbers, n => n*2);
            Console.WriteLine(string.Join(",", num1));

            int[] num2 = Transform(numbers, n => n*n);
            Console.WriteLine(string.Join(",", num2));

            int[] num3 = Transform(numbers, n => Math.Abs(n));
            Console.WriteLine(string.Join(",", num3));

            Console.ReadKey();
        }
    }
}
