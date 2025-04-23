namespace Example11_Task300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricShape[] shapes = new GeometricShape[]
            {
                new Triangle(3,4,5),
                new Triangle(5,5,6),
                new Rectangle(5,6),
                new Rectangle(3,3),
            };

            foreach (GeometricShape shape in shapes) 
            {
                shape.PrintInfo();
            }
            Console.ReadKey();
        }
    }

    public abstract class GeometricShape 
    {
        public abstract string Name { get; }
        public abstract double CalculateArea();
        public abstract double CalculatePerimetr();

        public void PrintInfo() 
        {
            Console.WriteLine(Name);
            Console.WriteLine($"S = {CalculateArea()}");
            Console.WriteLine($"P = {CalculatePerimetr()}");
            Console.WriteLine();
        }
    }
    public class Triangle : GeometricShape
    {
        public override string Name => "Треуголник";
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double CalculateArea()
        {
            // Формула Герона
            double p = CalculatePerimetr() / 2;
            return Math.Sqrt(p* (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double CalculatePerimetr() 
        { 
            return SideA + SideB + SideC;
        }
    }

    public class Rectangle : GeometricShape
    {
        public override string Name => "Прямоугольник";
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height) 
        { 
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override double CalculatePerimetr()
        { 
            return 2 * (Width + Height);
        }
    }
}
