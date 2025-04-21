using System;

namespace Example10_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Демонстрация наследования и переопределения методов
            Building building1 = new Building("г.Москва, ул. Красная, д.1", 200, 2015);
            building1.DisplayInfo();

            Console.WriteLine();

            MultiBuilding building2 = new MultiBuilding("г.Сочи, ул. Солнечная, д.45", 6555, 2010, 10, true);
            building2.DisplayInfo();

            Console.WriteLine();


            // 2. Upcasting - приведение к базовому типу
            MultiBuilding buildingUpcast = building2;
            Console.WriteLine("\nПосле upcasting:");
            buildingUpcast.DisplayInfo();
            //Console.WriteLine(buildingUpcast.IsMultiFloor);

            // 3. Downcasting - приведение к производному типу
            if (buildingUpcast is MultiBuilding)
            { 
                MultiBuilding buildingDowncast = (MultiBuilding)buildingUpcast;
                Console.WriteLine("\nПосле downcasting:");
                buildingDowncast.DisplayInfo();

                // Альтернативный безопасный способ с as
                var buildingAs = buildingUpcast as MultiBuilding;
                if (buildingAs != null) 
                {
                    Console.WriteLine("\nПосле downcasting с as:");
                    buildingAs.DisplayInfo();
                }
            }
        }

    }
    class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;
        public Building(string adress, double area, int yearBuild)
        {
            _address = adress;
            _area = area;
            _yearBuilt = yearBuild;
        }
        protected int BuildingAge
        {
            get
            {
                return DateTime.Now.Year - _yearBuilt;
            }
        }
        public virtual double CalculateTax()
        {
            return _area * 1000;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Здание одноэтажное.\nРасположенное по адресу: {_address}");
            Console.WriteLine($"Площадь здания: {_area}. Возрасn: {BuildingAge}. Налог: {CalculateTax()}");
        }
    }
    sealed class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;
        public MultiBuilding(string adress, double area, int yearBuild, int _floors, bool _hasElevator)
                : base(adress, area, yearBuild)
        {
            this._floors = _floors;
            this._hasElevator = _hasElevator;
        }
        public double AreaPerFloor
        {
            get
            {
                return _area/_floors;
            }
        }
        public override double CalculateTax()
        {
            double elevatorTax = _hasElevator ? 5000 : 0;
            return base.CalculateTax() * (1 + (_floors - 1) * 0.05) + elevatorTax;
        }
        //public override double CalculateTax()
        //{
        //    if (!_hasElevator)
        //    {
        //        return _area*1000 * (1+((double)_floors - 1)*0.05);
        //    }
        //    else
        //    {
        //        return _area*1000 * (1+((double)_floors - 1)*0.05)+5000;
        //    }
        //}
        public override void DisplayInfo()
        {
            Console.WriteLine($"Здание многоэтажное. Количество этажей: {_floors}. Наличие лифта: {(_hasElevator?"есть":"нет")}\nРасположенное по адресу: {_address}");
            Console.WriteLine($"Площадь здания: {_area}. Возраст: {BuildingAge}. Средняя площадь этажа: {AreaPerFloor}. Налог: {CalculateTax()}");
        }
        public bool IsMultiFloor 
        {
            get
            {
                return _floors > 1;
            }
        }

    }
}
