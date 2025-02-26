namespace Example2_Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999 включительно");
            Console.ReadKey();

            int n = Convert.ToInt32(Console.ReadLine());
            string res = "";

            if (n >= 100 && n <= 999)
            {
                switch (n / 100)
                {
                    case 1: res += "сто"; break;
                    case 2: res += "двести"; break;
                    case 3: res += "триста"; break;
                    case 4: res += "четыреста"; break;
                    case 5: res += "пятьсот"; break;
                    case 6: res += "шестьсот"; break;
                    case 7: res += "семьсот"; break;
                    case 8: res += "восемьсот"; break;
                    case 9: res += "девятьсот"; break;
                }

                switch ((n / 10)%10)
                {
                    case 1: if (n / 10 == 11) res += ""; else res += " десять"; break;
                    case 2: res += " двадцать"; break;
                    case 3: res += " тридцать"; break;
                    case 4: res += " сорок"; break;
                    case 5: res += " пятьдесят"; break;
                    case 6: res += " шестьдесят"; break;
                    case 7: res += " семьдесят"; break;
                    case 8: res += " восемьдесят"; break;
                    case 9: res += " девяносто"; break;
                }

                switch (n % 10)
                {
                    case 1: if (n / 10 == 11) res += " одиннадцать"; else res += " один"; break;
                    case 2: if (n / 10 == 11) res += " двенадцать"; else res += " два"; break;
                    case 3: if (n / 10 == 11) res += " тринадцать"; else res += " три"; break;
                    case 4: if (n / 10 == 11) res += " четырнадцать"; else res += " четыре"; break;
                    case 5: if (n / 10 == 11) res += " пятнадцать"; else res += " пять"; break;
                    case 6: if (n / 10 == 11) res += " шестнадцать"; else res += " шесть"; break;
                    case 7: if (n / 10 == 11) res += " семнадцать"; else res += " семь"; break;
                    case 8: if (n / 10 == 11) res += " восемнадцать"; else res += " восемь"; break;
                    case 9: if (n / 10 == 11) res += " девятнадцать"; else res += " девять"; break;
                }
                Console.WriteLine(res);
            }
            else { Console.WriteLine("Число должно быть от 100 до 999 включительно"); }


        }
    }
}