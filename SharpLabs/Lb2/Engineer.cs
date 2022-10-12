namespace SharpLabs.Lb2
{
    public class Engineer : Person
    {
        public int WorkExperience { get; set; }
        public string Orientation { get; set; }
        public Engineer(string firstName, string lastName, int workExperience, string orientation ) : base(firstName, lastName)
        {
            WorkExperience = workExperience;
            Orientation = orientation;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }

        public void JustEngineerIt()
        {
            Console.WriteLine("Hello, I'm student of TPU");
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
