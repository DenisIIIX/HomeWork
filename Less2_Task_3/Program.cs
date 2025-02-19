namespace Less2_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = Convert.ToInt32(Console.ReadLine());
            const double d = 2.54;

            double s = l * d * 10;
            int m = (int)(s / 1000);
            int c_m = (int)((s - m * 1000) / 10);
            double mm = s % 10;

            Console.WriteLine("{0}м {1}см {2}мм", m, c_m, mm);
        }
    }
}
