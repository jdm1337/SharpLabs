
namespace SharpLabs.Lb2
{
    public class Client : Person
    {
        public double Balance { get; set; }
        public Client(string firstName, string lastName, double balance) : base(firstName, lastName)
        {
            Balance = balance;
        }
        public void AddBalance(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
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
