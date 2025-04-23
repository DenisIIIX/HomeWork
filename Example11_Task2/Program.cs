using System.Threading.Channels;

namespace Example11_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[]
                {
                    new Bird(400),
                    new Airplane(9000,200)
                };
            foreach (IFlyable flyable in flyables) 
            {
                Console.WriteLine(flyable.Fly());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public interface IFlyable
        {
            public string Fly();
            public int MaxAltitude { get; }
        }
        public class Bird : IFlyable
        {
            public int MaxAltitude { get; }
            public Bird(int maxAltitude)
            {
                MaxAltitude=maxAltitude;
            }
            public string Fly()
            {
                return ($"Лечу на высоте {MaxAltitude} метров");
            }
        }
        public class Airplane : IFlyable
        {
            public int MaxAltitude { get; }
            public int CountPassengers { get; }

            public Airplane(int maxAltitude, int countPassengers)
            {
                MaxAltitude=maxAltitude;
                CountPassengers=countPassengers;
            }
            public string Fly()
            {
                return ($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
            }
        }

    }
}
