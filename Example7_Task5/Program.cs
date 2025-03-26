namespace Example7_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 2;
            int b1 = 3;

            double a2 = 2.5;
            double b2 = 3.5;

            
            Console.WriteLine(Multiply(a1, b1));

            double s2 = Multiply(a2, b2);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        
    }
}
