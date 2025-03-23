namespace Example6_Test1;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Привет \nмир";
        string s1 = "Привет \"мир\"";
        string s1 = "Привет \\\\мир";
        string s1 = new string('-', 10);

        Console.WriteLine(s1);

        Console.ReadKey();  
    }
}
