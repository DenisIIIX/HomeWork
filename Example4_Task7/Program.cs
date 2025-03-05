namespace Example4_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            int i;
            int j;

            for (i = 1, j = 10; n / j >= 1; j *=10)
            {
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
