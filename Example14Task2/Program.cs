using System.Security.Cryptography.X509Certificates;

namespace Example14Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sklad = new Dictionary<string, int>();
            sklad.Add("A001", 10);
            sklad.Add("B205", 25);
            sklad.Add("C307", 25);

            bool hasSmart = sklad.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {hasSmart}");
            Console.WriteLine();

            if (sklad.ContainsKey("A001"))
            {
                Console.WriteLine($"Количество ноутбуков: {sklad["A001"] -= 2}");
            }
            Console.WriteLine();


            if (sklad.TryGetValue("C307", out int count))
                { Console.WriteLine($"Количество наушников: {count}"); }
            Console.WriteLine();

            if (sklad.ContainsKey("B205"))
            {
                Console.WriteLine($"Количество смартфонов: {sklad["B205"] += 5}");
            }
            Console.WriteLine();

            sklad.Remove("C307");

            Console.WriteLine("Текущий инвентарь:");
            foreach (KeyValuePair<string, int> device in sklad) 
            {
                Console.WriteLine($"Артикул: {device.Key}, Количество: {device.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Инвентарь пуст? {sklad.Count<1}");

            sklad.Clear();
            Console.WriteLine($"Количество товаров после очистки: {sklad.Count}");
        }
    }
}
