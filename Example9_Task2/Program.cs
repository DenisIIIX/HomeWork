using System.Xml.Linq;

namespace Example9_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 1000;
            //bool dep = false;

            var accs = new[]
            {
                new BankAccount(balance, 100, true),
                new BankAccount(balance, 1000, true),
                new BankAccount(balance, 2000, false),
            };
            foreach (var ac in accs)
            {
                try
                {
                    Console.WriteLine(ac);
                    if (ac.dep)
                    {
                        Console.WriteLine($"Остаток на счете: {ac.Deposit(ac.cash)} {BankAccount.UnitOfCash}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Остаток на счете: {ac.Withdraw(ac.cash)} {BankAccount.UnitOfCash}");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
            BankAccount.DisplayTotalAccs();
            Console.ReadKey();
        }
    }
    class BankAccount
    {
        Random rnd = new Random();
        decimal _balance = 1000;
        public const string UnitOfCash = "руб.";
        public decimal cash;
        public bool dep;
        public static int TotalAccounts = 0;

        public readonly int AccountNumber;
        public decimal Balance { get; private set; }

        public BankAccount(decimal balance, decimal cash, bool dep)
        {
            Balance = balance;
            this.dep = dep;
            this.cash = cash;
            AccountNumber = rnd.Next(1000, 10000);
            TotalAccounts++;
        }
        static BankAccount()
        {
            Console.WriteLine("Добрый день!");
            Console.WriteLine();
        }
        public static void DisplayTotalAccs()
        {
            Console.WriteLine($"Всего создано счетов: {TotalAccounts}");
        }
        public decimal Deposit(decimal amount)
        {
            return Balance + cash;
        }
        public decimal Withdraw(decimal amount)
        {
            if (cash < Balance)
                return Balance - cash;
            else
                throw new ArgumentException("Недостаточно средств");
        }
        public override string ToString()
        {
            return $"№ Счета: {AccountNumber}, Ваш баланс {Balance} {UnitOfCash}" +
                   $"{(!dep ? "Снять со счета:" : "Пополнить счет:")} {cash} {UnitOfCash}";
        }



    }
}
