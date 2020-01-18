namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Retrieves name information from user
            System.Console.Write("Enter your first name: ");
            string firstName = System.Console.ReadLine();
            System.Console.Write("Enter your middle initial: ");
            string middleInitial = System.Console.ReadLine();
            System.Console.Write("Enter your last name: ");
            string lastName = System.Console.ReadLine();

            //  Concatenates first, middle, and last names together
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            //  Retrieves height information from user
            System.Console.Write("Enter your height in feet: ");
            int heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter the inches beyond your base height: ");
            double heightInches = double.Parse(System.Console.ReadLine());

            //  Converts total height to CM
            double totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;

            //  Retrieves age and citizen status information from user
            System.Console.Write("Enter your age: ");
            int age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a citizen?  Enter true or false: ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            //  Determines whether the user is eligible to vote
            bool canVote = (age >= 18) && isCitizen;

            //  Writes the user name, height in CM, and voter eligibility.
            System.Console.WriteLine();
            System.Console.WriteLine("Name: " + fullName);
            System.Console.WriteLine("Height: " + totalHeightCM + "CM");
            System.Console.WriteLine("Voter Eligibility: " + canVote);

            System.Console.ReadKey();
        }
    }
}
