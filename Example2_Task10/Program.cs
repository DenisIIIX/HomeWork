namespace Example2_Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //int d = n / 10;
            //int u = n % 10;

            string res = "";

            if (n /10 != 1 && n / 10 < 10 && n % 10 >0)
            {
                switch (n / 10)
                {
                    case 0: res = ""; break;
                    case 2: res += "двадцать"; break;
                    case 3: res += "тридцать"; break;
                    case 4: res += "сорок"; break;
                    case 5: res += "пятьдесят"; break;
                    case 6: res += "шестьдесят"; break;
                    case 7: res += "семьдесят"; break;
                    case 8: res += "восемьдесят"; break;
                    case 9: res += "девяносто"; break;
                }
                switch (n % 10)
                {
                    case 1: res += " один"; break;
                    case 2: res += " два"; break;
                    case 3: res += " три"; break;
                    case 4: res += " четыре"; break;
                    case 5: res += " пять"; break;
                    case 6: res += " шесть"; break;
                    case 7: res += " семь"; break;
                    case 8: res += " восемь"; break;
                    case 9: res += " девять"; break;
                }
                if (n % 10 == 1)
                {
                    Console.WriteLine("Мы построили {0} дом", res);
                }
                else if (n % 10 >1 && n % 10 < 5)
                    Console.WriteLine("Мы построили {0} дома", res);
                else if (n % 10 >= 5)
                    Console.WriteLine("Мы построили {0} домов", res);
                
            }

            else if (n / 10 == 1)
            {
                switch (n % 10)
                {
                    case 0: res += "десять"; break;
                    case 1: res += "одиннадцать"; break;
                    case 2: res += "двенадцать"; break;
                    case 3: res += "тринадцать"; break;
                    case 4: res += "четырнадцать"; break;
                    case 5: res += "пятнадцать"; break;
                    case 6: res += "шестнадцать"; break;
                    case 7: res += "семнадцать"; break;
                    case 8: res += "восемнадцать"; break;
                    case 9: res += "девятнадцать"; break;
                }
                Console.WriteLine("Мы построили {0} домов", res);
            }
            else if (n > 99)
                Console.WriteLine("Мы построили много домов");
            else if (n == 0)
                Console.WriteLine("Мы построили ноль домов");




        }
    }
}