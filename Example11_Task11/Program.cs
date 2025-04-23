namespace Example11_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] 
            { 
                new Dog ("Собака", "Гав!"),
                new Cat ("Кошка", "Мяу!")
            };

            foreach (Animal animal in animals) 
            {
                animal.ShowInfo();
                Console.WriteLine();
            }
            Console.ReadKey();  
        }
        public abstract class Animal
        {
            public abstract string Name { get; }
            public abstract string Say();
            public void ShowInfo()
            {
                Console.WriteLine($"{Name} - {Say()}");
            }
        }
        public class Dog : Animal
        {
            public override string Name { get; }
            public string AnimSay { get; }

            public Dog(string name, string animsay)
            {
                Name = name;
                AnimSay = animsay;
            }
            public override string Say()
            {
                return AnimSay;
            }
        }
        public class Cat : Animal
        {
            public override string Name { get; }
            public string AnimSay { get; }

            public Cat(string name, string animsay)
            {
                Name = name;
                AnimSay = animsay;
            }
            public override string Say()
            {
                return AnimSay;
            }
        }
    }
}
