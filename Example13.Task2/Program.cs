using System.Xml.Linq;

namespace Example13.Task2
{
    public delegate void Action(string name, string status);

    public class SmartHomeSystem
    {
        private int _tmp;

        public SmartHomeSystem(int tmp)
        {
            _tmp = tmp;
        }

        public event Action DeviceStateChanged;
        public void TurnOnLight()
        {
            DeviceStateChanged?.Invoke("Light", "Включен");
        }
        public void TurnOfLight()
        {
            DeviceStateChanged?.Invoke("Light", "Выключен");
        }
        public void Thermostat(int tmp)
        {
            string status = $"Температура изменена на {tmp}°C";
            DeviceStateChanged?.Invoke("Thermostat", status);
        }
        public void LockDoor()
        {
            DeviceStateChanged?.Invoke("Door", "Заблокирована");
        }
        public void UnlockDoor()
        {
            DeviceStateChanged?.Invoke("Door", "Разблокирована");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var device = new SmartHomeSystem(20);
            device.DeviceStateChanged += (name, status) =>
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {name}: {status}");
            };
            try
            {
                device.LockDoor();
                device.Thermostat(-10);
                device.TurnOfLight();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

}
