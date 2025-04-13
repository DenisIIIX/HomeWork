namespace Example7_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edgeLength = 10;

            double volume, surfaceArea;

            CalcCube(edgeLength, out volume, out surfaceArea);

            Console.WriteLine($"Объем куба: {volume}"); // Объем куба: 125
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");  
        }
        static void CalcCube(int edgeLength, out double volume, out double surfaceArea)
        {
            surfaceArea = 6*Math.Pow(edgeLength, 2);
            volume = Math.Pow(edgeLength, 3);
        }
    }
}
