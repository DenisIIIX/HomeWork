namespace Example14Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> userEmail = new HashSet<string>();
            userEmail.Add("alice@example.com");
            userEmail.Add("bob@example.com");
            userEmail.Add("charlie@example.com");

            bool dublicate = userEmail.Add("bob@example.com");
            Console.WriteLine($"Добавлен дубликат bob@example.com? {dublicate}");
            Console.WriteLine();

            Console.WriteLine($"Есть ли почта lice@example.com? {userEmail.Contains("lice@example.com")}");
            Console.WriteLine();


            HashSet<string> userEmail2 = new HashSet<string> { "bob@example.com", "dave@example.com", "eve@example.com" };
            
            HashSet<string> allUser = new HashSet<string>(userEmail);
            allUser.UnionWith(userEmail2);
            Console.WriteLine("Все адреса после объединения:");
            foreach (string email in allUser)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();


            HashSet<string> crossEmail = new HashSet<string>(userEmail);
            crossEmail.IntersectWith(userEmail2);
            Console.WriteLine("Общие адреса:");
            foreach (string email in crossEmail) 
            {
                Console.WriteLine(email);

            }
            Console.WriteLine();


            Console.WriteLine($"Удалили lice@example.com? {crossEmail.Remove("lice@example.com")}");
            Console.WriteLine();

            Console.WriteLine($"Всего подписчиков: {crossEmail.Count}");
            Console.WriteLine();

            Console.WriteLine($"{"bob@example.com"} является подмножеством? {crossEmail.IsSubsetOf(crossEmail)}");
            Console.WriteLine();

            crossEmail.Clear();
            Console.WriteLine($"Количество адресов после очистки: {crossEmail.Count}");
        }
    }
}
