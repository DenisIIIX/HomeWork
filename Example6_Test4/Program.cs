namespace Example6_Test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            str = string.Format("{0,5}", 123);
            str = string.Format("{0:.00}", 123);
            str = string.Format("{0:#(###)###-##-##}", 89279954249);
            str = string.Format("{0:0,0}", 89279954249);
            str = string.Format("{0:+0; -0; 0}", 5);
            str = string.Format("{0:F3}", 5);
            str = string.Format("{0:D3}", 5);
            str = string.Format("{0:N1}", 5000);
            str = string.Format("{0:P3}", 5);

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
