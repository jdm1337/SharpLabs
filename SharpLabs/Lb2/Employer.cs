using SharpLabs.Lb3;

namespace SharpLabs.Lb2
{
    public class Employer : Person, IWeightable, IAgeable, IComparable
    {
        public string Title { get; set; }
        public double Salary { get; set; }
        public float Weight { get; set; }
        public int Age { get; set; }

        public delegate void EmployerHandler (string message);

        public event EmployerHandler Notify;

        public Employer(string firstName, string lastName, string title, double salary, float weight , int age) : base(firstName, lastName)
        {
            Title = title;
            Salary = salary;
            Weight = weight;
            Age = age;
        }

        public void Promote()
        {
            Console.WriteLine("Now I'm boss.");
        }
        public void EditSalary(double amount)
        {
            Salary += amount;
        }
        public void Fire()
        {
            Console.WriteLine("I'm go away.");
            Notify?.Invoke("Employer was fired");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Title: {Title}");
        }

        public float DefineWeight()
        {
            return Weight;
        }

        public int DefineAge()
        {
            return Age;
        }
        public int CompareTo(object? obj)
        {
            if (obj is Employer employer) return Salary.CompareTo(employer.Salary);
            else throw new ArgumentException("Некорректное значение параметра");
        }

        ~Employer()
        {
            Console.WriteLine("Deleted object information:");
            Console.WriteLine($"Type: {typeof(Employer)} \n" +
                $"Title {Title} Salary {Salary}" +
                $"First Name: {FirstName} " +
                $"Last Name: {LastName}");
        }
    }
}
