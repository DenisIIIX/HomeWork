using System;

namespace Example15Task1
{
    class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public int CpuFrequency { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public int Vram { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>()
            {
                new Computer(){Id = 1, Name = "Asus", CPU = "Intel", CpuFrequency = 3600, Ram = 16, Hdd = 1000, Vram = 8, Cost = 1200, Count = 5},
                new Computer(){Id = 2, Name = "MSI", CPU = "AMD", CpuFrequency = 4200, Ram = 32, Hdd = 2000, Vram = 12, Cost = 1800, Count = 3},
                new Computer(){Id = 3, Name = "Acer", CPU = "Intel", CpuFrequency = 2900, Ram = 8, Hdd = 500, Vram = 4, Cost = 700, Count = 8},
                new Computer(){Id = 4, Name = "Dell", CPU = "Intel", CpuFrequency = 3300, Ram = 16, Hdd = 1000, Vram = 6, Cost = 950, Count = 6},
                new Computer(){Id = 5, Name = "Asus", CPU = "AMD", CpuFrequency = 3800, Ram = 32, Hdd = 2000, Vram = 16, Cost = 2100, Count = 2},
                new Computer(){Id = 6, Name = "MSI", CPU = "Intel", CpuFrequency = 4500, Ram = 64, Hdd = 4000, Vram = 24, Cost = 3500, Count = 1},
                new Computer(){Id = 7, Name = "Acer", CPU = "AMD", CpuFrequency = 3100, Ram = 16, Hdd = 1000, Vram = 8, Cost = 850, Count = 7},
                new Computer(){Id = 8, Name = "Dell", CPU = "Intel", CpuFrequency = 2700, Ram = 8, Hdd = 500, Vram = 4, Cost = 600, Count = 10},
                new Computer(){Id = 9, Name = "Asus", CPU = "AMD", CpuFrequency = 3900, Ram = 16, Hdd = 1000, Vram = 12, Cost = 1300, Count = 4},
                new Computer(){Id = 10, Name = "MSI", CPU = "Intel", CpuFrequency = 3400, Ram = 32, Hdd = 2000, Vram = 8, Cost = 1600, Count = 3}
            };

            Console.WriteLine("Введите название процессора");
            try
            {
                string cpu = Console.ReadLine();

                if (cpu == "AMD" || cpu == "Intel")
                {
                    var compIntel = list
                    .Where(Computer => Computer.CPU == cpu);
                    foreach (var comp in compIntel) 
                    {
                        Console.WriteLine($"ID: {comp.Id}, Модель: {comp.Name}, Цена: {comp.Cost}");
                    }
                }
                else
                    throw new ArgumentException("Ошибка: допустимы только Intel или AMD");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Введите минимальное количество памяти");
            try
            {
                int ram = Convert.ToInt32(Console.ReadLine());

                if (ram > 0)
                {
                    var compNeededRam = list
                    .Where(Computer => Computer.Ram>=ram); ;
                    foreach (var comp in compNeededRam)
                    {
                        Console.WriteLine($"ID: {comp.Id}, Модель: {comp.Name}, Память: {comp.Ram} Цена: {comp.Cost}");
                    }
                }
                else
                    throw new ArgumentException("Ошибка:введите целое число больше 0");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            Console.WriteLine();

            Console.WriteLine("Список по увеличению стоимости");
            var compCost = list
                .OrderBy(Computer => Computer.Cost);
            foreach (var computer in compCost)
            {
                Console.WriteLine($"{computer.Name}: процессор {computer.CPU}, цена - {computer.Cost} у.е.");
            }
            Console.WriteLine();

            var compCPUsorted = list
                .GroupBy(Computer => Computer.CPU);

            foreach (var group in compCPUsorted)
            {
                Console.WriteLine($"Процессор {group.Key}");
                foreach (var computer in group)
                {
                    Console.WriteLine($"{computer.Name}: процессор {computer.CPU}, цена - {computer.Cost} у.е.");
                }
            }
            Console.WriteLine();

            var compMaxCost = list
                .OrderByDescending(Computer => Computer.Cost)
                .First();
            Console.WriteLine($"Самый дорогой компьютер: {compMaxCost.Name}, {compMaxCost.CPU}, {compMaxCost.Cost} у.е.");
            Console.WriteLine();

            var compMinCost = list
                .OrderByDescending(Computer => Computer.Cost)
                .Last();
            Console.WriteLine($"Самый недорогой компьютер: {compMinCost.Name}, {compMinCost.CPU}, {compMinCost.Cost} у.е.");
            Console.WriteLine();

            Console.WriteLine("Есть ли компьютер в количестве не менее 30 штук?");
            var checkCount = list
                .Count(Computer => Computer.Count>=30);
            if (checkCount >=30)
            {
                Console.WriteLine("есть");
            }
            Console.WriteLine("нет");
        }
    }
}
