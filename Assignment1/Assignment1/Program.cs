namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Variable declarations
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            //  Retrieves name information from user
            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();
            System.Console.Write("Enter your middle initial: ");
            middleInitial = System.Console.ReadLine();
            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            //  Concatenates first, middle, and last names together
            fullName = firstName + " " + middleInitial + ". " + lastName;

            //  Retrieves height information from user
            System.Console.Write("Enter your height in feet: ");
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter the inches beyond your base height: ");
            heightInches = double.Parse(System.Console.ReadLine());

            //  Converts total height to CM
            totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;

            //  Retrieves age and citizen status information from user
            System.Console.Write("Enter your age: ");
            age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a citizen?  Enter true or false: ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            //  Determines whether the user is eligible to vote
            canVote = (age >= 18) && isCitizen;

            //  Writes the user name, height in CM, and voter eligibility.
            System.Console.WriteLine();
            System.Console.WriteLine("Name: " + fullName);
            System.Console.WriteLine("Height: " + totalHeightCM + "CM");
            System.Console.WriteLine("Voter Eligibility: " + canVote);

            System.Console.ReadKey();
        }
    }
}
