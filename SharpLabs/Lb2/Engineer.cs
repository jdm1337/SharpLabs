

namespace SharpLabs.Lb2
{
    public class Engineer : Person, IComparable
    {
        public int WorkExperience { get; set; }
        public string Orientation { get; set; }
        public delegate void EngineerHandler(string message);

        public event EngineerHandler Notify;
        public Engineer(string firstName, string lastName, int workExperience, string orientation ) : base(firstName, lastName)
        {
            WorkExperience = workExperience;
            Orientation = orientation;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Notify?.Invoke("Info was requested");
        }

        public void JustEngineerIt()
        {
            Console.WriteLine("Hello, I'm student of TPU");
        }

        public int CompareTo(object? o)
        {
            if (o is Engineer engineer) return FirstName.CompareTo(engineer.FirstName);
            else throw new ArgumentException("Invalid value");
        }

        ~Engineer()
        {
            Console.WriteLine("Deleted object information:");
            Console.WriteLine($"Type: {typeof(Engineer)} \n" +
                $"Work expiriens {WorkExperience} Orientation {Orientation}" +
                $"First Name: {FirstName} " +
                $"Last Name: {LastName}");
        }

    }
}
