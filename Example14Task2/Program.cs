using System.Security.Cryptography.X509Certificates;

namespace Example14Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Алексей", "+7 (123 456-78-90)");
            phoneBook.Add("Мария", "+7 (123 456-78-90)");
            phoneBook.Add("Иван", "+7 (123 456-78-90)");

            bool hasAlexey = phoneBook.ContainsKey("Алексей");
            Console.WriteLine($"Есть ли контакт'Алексей'? {hasAlexey}");
         

            foreach (KeyValuePair<string, string> phone in phoneBook) 
            {
                Console.WriteLine($"{phone.Key} - {phone.Value}");
            }
            if (phoneBook.ContainsKey("Мария")) 
            {
                string mariaPhone = phoneBook["Мария"];
                Console.WriteLine(mariaPhone);
            }

            if (phoneBook.TryGetValue("Алексей", out string sashaPhone)) 
            { Console.WriteLine(sashaPhone); }

            phoneBook["Иван"] = "+7 999 676-65-88";

            phoneBook.Remove("Алексей");

            foreach (KeyValuePair<string, string> phone in phoneBook)
            {
                Console.WriteLine($"{phone.Key} - {phone.Value}");
            }

        }
    }
}
