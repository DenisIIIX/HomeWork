namespace Less2_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int t = a;
            int x = b;
            a = c;
            b = t;
            c = x;

            Console.WriteLine("{0} {1} {2}", a, b, c);        
        }

    }

}
