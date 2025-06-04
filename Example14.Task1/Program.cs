namespace Example14.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> players = new List<string>();

            players.Add("Иванов");
            players.Add("Петров");
            players.Add("Сидоров");

            players.Insert(1, "Козлов");
            foreach (string player in players)
                Console.WriteLine(player);
            Console.WriteLine();
            
            bool hasPlayer1 = players.Contains("Петров");
            Console.WriteLine($"Есть ли Петров в команде? - {hasPlayer1}");
            Console.WriteLine(); ;

            players.Remove("Сидоров");
            foreach (string player in players)
                Console.WriteLine(player);
            Console.WriteLine();

            int ind1 = players.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока Козлов: {ind1}");
            Console.WriteLine();

            players.Sort();
            Console.WriteLine("Текущий состав команды:");
            for (int i =0; i<players.Count; i++)
                Console.WriteLine($"{i+1}. {players[i]}");

            Console.WriteLine($"Команда пуста? {players.Count<1}");
            Console.WriteLine();

            players.Clear();
            Console.WriteLine($"Количество игроков после очистки: {players.Count}");
        }
    }
}
