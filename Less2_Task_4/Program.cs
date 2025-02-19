namespace Less2_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = n / 1000;
            int b = (n - a * 1000) / 100;
            int c = (n / 10) % 10;
            int d = n % 10;

            n = a * 1000 + d * 100 + c * 10 + b;

            Console.WriteLine(a);
            
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("Новое число = {0}", n);
        }
    }
}
