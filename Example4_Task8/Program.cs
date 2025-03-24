namespace Example4_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 0;

            int i;
            int r;

          

            if (n % 10 == 0 && n != 0)
            {
                
                int s = 0;
                r = n / 10;
                for (i = 1; r / i > 1 || (r / i) % 10 >= 1; i *=10)
                {

                    p += (r / i) % 10;

                    if (r / i >= 10)
                        p *= 10;

                }
                Console.WriteLine("Ответ {0}{1}", s, p);
            }
            else if (n ==0)
                Console.WriteLine("Ответ 0");
            else 
            {
                for (i = 1; (n / i) % 10 >= 1 || n / i > 1; i *=10)
                {
                    if ((n / i) % 10 <1 && n / i < 1)
                        break;
                    p += (n / i) % 10;

                    if (n / i >= 10)
                        p *= 10;

              
                }
                Console.WriteLine("Ответ {0}", p);
            }


            
        }
    }
}
