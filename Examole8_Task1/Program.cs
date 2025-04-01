namespace Examole8_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            bool abValid = false;

            while (!abValid)
            {
                try
                {
                    Console.WriteLine("Введите двухзначниые числа");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    abValid = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Введено не число - {ex.Message}");
                }
            }

            int c = 0;
            bool cValid = false;

            while (!cValid)
            {
                try
                {
                    Console.WriteLine("Введите код команды:\n\"1\" - сложение\n\"2\" - вычитание\n\"3\" - умножение\n\"4\" - частное");
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c<1 || c>4)
                    {
                        Console.WriteLine("Введите код операции согласно инструкции (от 1 до 4 включительно)");
                        continue;
                    }
                    cValid = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Введено не число - {ex.Message}");
                }
            }

            double result = 0;

            if (c == 1)
            {
                result = a+b;
                Console.WriteLine($"Ответ = {result}");
            }
            else if (c == 2)
            {
                result = a-b;
                Console.WriteLine($"Ответ = {result}");
            }
            else if (c == 3)
            {
                result = a*b;
                Console.WriteLine($"Ответ = {result}");
            }
            else if (c == 4)
                try
                {
                    result = (double)a/(double)b;
                    Console.WriteLine($"Ответ = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Деление на 0 - {ex.Message}");
                }
            Console.ReadKey();
        }

    }

}

