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
            Console.WriteLine("Hello, I'm student of TPU, third year, but work with ASP.NET I will only in 4th");
        }


    }
}
