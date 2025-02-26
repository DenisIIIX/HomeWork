namespace Example2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                if (a == b)
                {
                    Console.WriteLine("{0} = {1}", a, b);
                    Console.ReadKey();  
                }
                else 
                { 
                    Console.WriteLine("{0} > {1}", a, b);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("{0} < {1}", a, b);
                Console.ReadKey();
            }
            
             
        }
    }
}
