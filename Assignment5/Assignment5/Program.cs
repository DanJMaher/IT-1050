using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            int peopleQuantity;
            string input;

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------------Person Array Entry Tool---------------");
            Console.WriteLine("-----------------------------------------------------\n");


            while (true)
            {
                Console.Write("How many people do you wish to add to the array?: ");                
                input = Console.ReadLine();

                if (int.TryParse(input, out peopleQuantity) && peopleQuantity > 0)
                {
                    break;
                }

                Console.WriteLine("\n{0} is not a valid entry! Try again.\n", input );
            }

            Person[] people = new Person[peopleQuantity];

            for (int i = 0; i < people.Length; i++)
            {
                string firstName;
                string lastName;

                Console.Write("\nWhat is person {0}'s first name?: ", i + 1);
                firstName = Console.ReadLine();

                Console.Write("\nWhat is person {0}'s last name?: ", i + 1);
                lastName = Console.ReadLine();

                people[i] = new Person(firstName, lastName);
            }

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("---------------People in array---------------");
            Console.WriteLine("---------------------------------------------");

            foreach (Person person in people)
            {
                person.PrintName();
            }
            Console.ReadKey();
        }
    }
}
