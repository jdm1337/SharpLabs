

namespace SharpLabs.Lb2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"LastName: {LastName}\nFirstName: {FirstName}");
        }
    }
}
