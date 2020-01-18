namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();
            System.Console.Write("Enter your middle initial: ");
            middleInitial = System.Console.ReadLine();
            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("Enter your height in feet: ");
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter the inches beyond your base height: ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;

            System.Console.Write("Enter your age: ");
            age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a citizen?  Enter true or false: ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = (age >= 18) && isCitizen;

            System.Console.WriteLine();
            System.Console.WriteLine("Name: " + fullName);
            System.Console.WriteLine("Height: " + totalHeightCM + "CM");
            System.Console.WriteLine("Voter Eligibility: " + canVote);


            System.Console.ReadKey();
        }
    }
}
