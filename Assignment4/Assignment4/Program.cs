using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
                MovieTime movieTime = new MovieTime();
                string input;

                DisplayHeader();

                Console.Write("Are you bringing anybody? (y/n): ");
                input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    DisplayHeader();

                    Console.Write("How many people (including yourself) are coming?: ");
                    movieTime.people = int.Parse(Console.ReadLine());

                    Console.Write("How many of those people are children?: ");
                    movieTime.children = int.Parse(Console.ReadLine());

                    Console.Write("How many of those people are seniors?: ");
                    movieTime.seniors = int.Parse(Console.ReadLine());

                    movieTime.adults = movieTime.people - movieTime.children - movieTime.seniors;
                }
                else if (input.ToLower() == "n")
                {
                    DisplayHeader();

                    Console.WriteLine("Oh...just you then.  Interesting.  Moving on...");
                    Console.Write("Press any key to continue...");
                    Console.ReadLine();
                }
                else
                {
                    DisplayHeader();

                    Console.WriteLine("Invalid Entry!  I'm going to assume you don't have any friends...");
                    Console.Write("Press any key to continue...");
                }

                DisplayHeader();
                Console.Write("Do you want to see a matinee or an evening film? (m/e): ");
                input = Console.ReadLine();
                if (input.ToLower() == "m" || input.ToLower() == "matinee")
                {
                    movieTime.matinee = true;
                }
                else if (input.ToLower() == "e" || input.ToLower() == "evening")
                {
                    movieTime.matinee = false;
                }
                else
                {
                    DisplayHeader();

                    Console.WriteLine("Invalid Entry!  I'll assume matinee because I like the word.");
                    Console.Write("Press any key to continue...");
                    Console.ReadLine();
                    movieTime.matinee = true;
                }

                DisplayHeader();
                Console.WriteLine("Food time! Please enter quantities in positive whole numbers.\n");
                Console.Write("How many small sodas?: ");
                movieTime.smSodas = int.Parse(Console.ReadLine());
                Console.Write("How many large sodas?: ");
                movieTime.lgSodas = int.Parse(Console.ReadLine());
                Console.Write("How many hot dogs?: ");
                movieTime.hotDogs = int.Parse(Console.ReadLine());
                Console.Write("How many popcorns?: ");
                movieTime.popcorns = int.Parse(Console.ReadLine());
                Console.Write("How many candies?: ");
                movieTime.candies = int.Parse(Console.ReadLine());

                DisplayHeader();
                Console.WriteLine("Your total before discounts/promotions would be: {0:C}\n", movieTime.CalculateTotal());

                movieTime.Promotions();

                Console.WriteLine("After discounts, your total will be: {0:C}", movieTime.totalPrice);

                if (movieTime.freePopcorn)
                {
                    Console.WriteLine("You also get a free popcorn!");
                }

                if (movieTime.freeCandies > 0)
                {
                    Console.WriteLine("You will also get {0} free candies!", movieTime.freeCandies);
                }

                Console.Write("Press any key to exit...");
                Console.ReadLine();
        }

        static void DisplayHeader()
        {
            Console.Clear();
            Console.WriteLine("***************************************");
            Console.WriteLine("******MOVIE PRICE CALCULATOR 3000******");
            Console.WriteLine("***************************************\n");
        }
    }
}
