using System.Net.Http.Headers;

namespace Example12_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("F-1", "Война и мир", 1886, "Л.Н.Толстой"),
                new Book<string, int>("F-34", "Ключи от Вселенной", 2011, "Сергей Яков"),
                new Book<string, int>("F-1234", "Преступление и наказание", 1884, "Ф.М.Достоевсий"),
            };
            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string>(55,"Папирус Присса","3350 году до н.э.","Автор из Фивы"),
                new Book<int, string>(42,"Одиссея","VIII век до н. э.","Гомер"),
                new Book<int, string>(42,"Сказание о Гильгамеше","8-9 века до н.э.","НоНейм"),
            };
            var book1 = FindBook(books1, "F-1234");
            Console.WriteLine(book1?.ToString()?? "Книга не найдена");

            var book2 = FindBook(books2, 42);
            Console.WriteLine(book2?.ToString()?? "Книга не найдена");
        }
            public static Book<T, U> FindBook<T, U>(Book<T,U>[] books, T code) 
            {
                foreach (Book<T, U> book in books) 
                { 
                    if (book.Code.Equals(code))
                        return book;
                }
                return null;
            }
    }
    class Book<T, U>
    {
        public T Code { get; set; }
        public string Title { get; set; }
        public U PublicationYear { get; set; }
        public string Author { get; set; }
        public Book(T code, string title, U publicationYear, string author)
        {
            Code=code;
            Title=title;
            PublicationYear=publicationYear;
            Author=author;
        }
        public override string ToString()
            => $"Код: {Code} ({typeof(T).Name}), Названеие: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
    }
}
