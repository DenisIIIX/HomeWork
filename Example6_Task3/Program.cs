namespace Example6_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            Console.Write("Введите год: ");
            string year = Console.ReadLine();
            Console.Write("Введите общую сумму: ");
            float sum = float.Parse(Console.ReadLine());
            Console.Write("Введите количество товара: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string r = new string('-', 10);



            float sr = sum / n;

            string sn = n.ToString("0,0");
         

            string ssum = sum.ToString("N2");


            string ssr = sr.ToString("N2");

            Console.WriteLine("{2}\n\nОтчет о продажах за {0} {1}\n\n{2}\n\nОбщая сумма продаж: {3} р.\nКоличество проданных товаров: {4} шт.\nСредняя стоимость товара: {5} р.\n\n{2}", month, year, r, ssum, sn, ssr);
            

            Console.ReadKey();
        }
    }
}
