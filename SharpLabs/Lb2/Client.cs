using System.Xml.Linq;

namespace SharpLabs.Lb2
{
    public class Client : Person, ICloneable, IComparable
    {
        public double Balance { get; set; }

        public delegate void ClientHandler(string message);

        public event ClientHandler Notify;
        public Client(string firstName, string lastName, double balance) : base(firstName, lastName)
        {
            Balance = balance;
        }
        public void AddBalance(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Notify?.Invoke($"Balance was added {Balance}");
            }
            else
            {
                Console.WriteLine($"Invalid amount: {amount}");
            }
            
        }
        public void Buy(string product)
        {
            Balance -= 100;
            Console.WriteLine($"{product} was buyed. Current balance: {Balance}");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Current balance: {Balance}");
        }

        public object Clone()
        {
            return new Client(FirstName, LastName, Balance);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Client client) return Balance.CompareTo(client.Balance);
            else throw new ArgumentException("Некорректное значение параметра");
        }

        ~Client()
        {
            Console.WriteLine("Deleted object information:");
            Console.WriteLine($"Type: {typeof(Client)} \n" +
                $"Balance statement: {Balance}" +
                $"First Name: {FirstName} " +
                $"Last Name: {LastName}");
        }     
    }
}
