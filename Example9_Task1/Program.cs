namespace Example9_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Война и мир", "Л.Толстой", 1869, 1225);
            var book1 = new Book("Изобретение Мореля", "Адольфо Биой Касарес", 1940, 103);
            var book2 = new Book("Скотный двор", "Джордж Оруэлл", 1945, 112);

            Console.WriteLine(book.GetInfo());
            Console.WriteLine(book1.GetInfo());
            Console.WriteLine(book2.GetInfo());

            Console.ReadKey();
        }
    }

    class Book
    {
        string _title;
        string _author;
        public int Year { get; set; }
        public int Pages { get; set; }
        public Book(string title, string author, int year = 2000, int pages = 100)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }

        public string GetInfo()
        {
            return $"\"{_title}\",{_author}, {Year} г., {Pages} стр.";
        }

    }
}
