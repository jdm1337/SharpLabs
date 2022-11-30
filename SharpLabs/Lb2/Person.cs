using System.Xml.Linq;

namespace SharpLabs.Lb2
{
    public class Person : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public delegate void PersonHandler(string message);

        public event PersonHandler Notify;
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
            Notify?.Invoke("Info was requested");
        }

        public int CompareTo(object? obj)
        {
            if (obj is Person person) return FirstName.CompareTo(person.FirstName);
            else throw new ArgumentException("Некорректное значение параметра");
        }

        ~Person()
        {
            Console.WriteLine("Deleted object information:");
            Console.WriteLine($"Type: {typeof(Person)} \n" +
                $"First Name: {FirstName} " +
                $"Last Name: {LastName}");
        }
    }
}
