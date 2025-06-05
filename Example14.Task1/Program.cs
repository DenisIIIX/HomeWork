namespace Example14.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            tasks.Add("Помыть посуду");
            tasks.Add("Купить продукты");
            tasks.Add("Покормить кота");

            tasks.Insert(1, "Сделать зарядку");

            bool hasCat = tasks.Contains("Покормить кота");
            Console.WriteLine($"Есть ли задача 'Покормить кота'");
            

            int ind1 = tasks.IndexOf("Сделать зарядку");
            Console.WriteLine($"Сделать зарядку - {ind1}");
           


            int ind2 = tasks.IndexOf("Проверить уроки");
            Console.WriteLine($"Сделать зарядку - {ind2}");
            


            tasks.Remove("Купить продукты");
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }

            tasks.Sort();

            for (int i = 0; i<tasks.Count; i++)
            {
                Console.WriteLine($"{i} {tasks[i]}");
            }
        }
    }
}
