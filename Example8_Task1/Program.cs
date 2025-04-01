using System.Threading.Channels;

namespace Example8_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine($"Возраст корректен");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено не число!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Проверка возраста завершена.");
            }

            Console.ReadKey();
        }
        static void ValidateAge(int a)
        {
            if (a < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");
            if (a > 150)
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
        }
        
    }
}
