
namespace RandomDataGenerator
{
    

    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1. Create a new person");
            Console.WriteLine("#2. View all persons");
            Console.WriteLine("#3. Remove a person");
            Console.WriteLine("#4. Random last name");
            Console.WriteLine("#5. Random SSN");
            Console.WriteLine("#6. Random phone number");
        }

        
    }

    public class Person
    {
        // fields
        public string[] _arrayOfFirstNames = new string[] {"Fredrick", "Jasper", "William", "Rosanne", "Helen", "Benjamin", "Thomas", };
        public string[] _dependents = new string[] {"billy", "bobby", "tony", "freddy",
                                                    "willy", "tommy", "johnny", "bonny",
                                                    "pauly", "molly"};
        // properties
        public string[] FirstName
        {
            get { return _arrayOfFirstNames; }
            init
            {
                Random rnd = new Random();
                int fName = rnd.Next(_arrayOfFirstNames.Length);
            }
        }
}

