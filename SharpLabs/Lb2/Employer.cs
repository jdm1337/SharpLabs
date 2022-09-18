namespace SharpLabs.Lb2
{
    public class Employer : Person
    {
        public string Title { get; set; }
        public double Salary { get; set; }
        
        public Employer(string firstName, string lastName, string title, double salary) : base(firstName, lastName)
        {
            Title = title;
            Salary = salary;    
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
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Title: {Title}");
        }
    }
}
