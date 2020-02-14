using System;
    
    namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Retrieves name information from user
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your middle initial: ");
            string middleInitial = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            //  Concatenates first, middle, and last names together
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            //  Retrieves height information from user
            Console.Write("Enter your height in feet: ");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("Enter the inches beyond your base height: ");
            double heightInches = double.Parse(Console.ReadLine());

            //  Converts total height to CM
            const int inchesPerFeet = 12;
            const double metricMultiplier = 2.54;
            double totalHeightCM = (heightFeet * inchesPerFeet + heightInches) * metricMultiplier;

            //  Retrieves age and citizen status information from user
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Are you a citizen?  Enter true or false: ");
            bool isCitizen = bool.Parse(Console.ReadLine());

            //  Determines whether the user is eligible to vote
            bool canVote = (age >= 18) && isCitizen;

            //  Writes the user name, height in CM, and voter eligibility.
            Console.WriteLine();
            Console.WriteLine("Name: " + fullName);
            Console.WriteLine("Height: " + totalHeightCM + "CM");
            Console.WriteLine("Voter Eligibility: " + canVote);

            Console.ReadKey();
        }
    }
}
