namespace Less2_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            double g2 = (double)g + (double)m * 1 / 60 + (double)s * 1 / 3600;
            double Rad = g2 * Math.PI / 180;


            Console.WriteLine("{0} градусов", g2);
            Console.WriteLine("{0} радин", Rad);
        }
    }
}
