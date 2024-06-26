namespace Practice_for_class_day_28_
{
    internal class Program
    {
        Person myPerson = new Person();
        static void Main(string[] args)
        {




        }

        static void AddPersonToDictionary(Person person)
        {
           Dictionary<Person, string> dictionary = new Dictionary<Person, string>();
            int num = 0;    
            Console.WriteLine("Please enter your first name");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Please enter yoru mobile number");
            person.MobilePhone = Console.ReadLine();
            Console.WriteLine("Please enter your address");
            person.Address = Console.ReadLine();

            
            
        }
    }

}
