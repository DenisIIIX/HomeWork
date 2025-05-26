namespace Example16Task1
{
    internal class Program
    {
        static int[] Array(int n)
        {
            try
            {
                if (n==0)
                    throw new ArgumentException("Размер массива должен быть больше 0");
                Console.WriteLine("Генерация массива...");
                int[] array = new int[n];
                Random rnd = new Random();
                int s = 0;
                for (int i = 0; i < n; i++)
                {
                    array[i] = rnd.Next(0, 999);
                    s += array[i];
                    Console.Write("{0} ", array[i]);
                    Thread.Sleep(500);
                }
                Console.WriteLine("\nМассив сгенерирован!");
                return array;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}"); 
                return null;
            }
        }
        static double Am(int[] array)
        {
            Console.WriteLine("Вычисление средней суммы");
            double average = array.Average();
            Thread.Sleep(800);
            return average;
        }

        static async Task ArrayAsinc(int n) 
        {
            Console.WriteLine( "ArrayAsinc запущен");
            await Task.Run(() => Array(n));
            Console.WriteLine( "ArrayAsinc завершег");
        }

        static async Task<double> AmAsinc(int[] array) 
        {
            Console.WriteLine( "AmAsinc запущен");
            double result = await Task.Run(() => Am(array));
            Console.WriteLine("AmAsinc завершен");
            return result;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество чисел в массиве (БОЛЬШЕ 0)");
                int n = Convert.ToInt32(Console.ReadLine());
                Task<int[]> task1 = Task.Run(() => Array(n));
                Task<double> task2 = task1.ContinueWith(t =>
                {
                    if (t.Result == null)
                        throw new InvalidOperationException("Не удалось создать массив");
                    return Am(t.Result);
                });
                Console.WriteLine($"Среднее значение: {task2.Result}");

                int [] array = Array(n);
                double result = AmAsinc(array).Result;
                Console.WriteLine($"Среднее значение: {result}");
                Console.WriteLine("Завершение Main");

                Console.ReadKey();
            }
            catch(FormatException)
            {
                Console.WriteLine("Ошибка: Введено не число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


        }

    }
}
