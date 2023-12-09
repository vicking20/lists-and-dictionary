namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            Console.WriteLine("Please enter your name:");
            string personName = Console.ReadLine();

            // TODO 2: Validate if the person already exists in the personList.
            bool personExists = personList.Contains(personName);

            // TODO 3: Add the person to the personList if they don't already exist.
            if (personExists)

            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            {
                Console.Writeline($"{personName} already exists in the person list.");
            }
            else
            {
                personList.Add(personName);
                Console.WriteLine($"{personName} has been added to the list.");
            }

            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            bool existsInDict = personAgeDictionary.ContainsKey(personName);


            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            if(!existsinDict)
            {
                Console.WriteLine("Please enter your age");
                if (int.TryParse(Console.ReadLine(), out int personAge))
                    { personAgeDictionary.Add(personName, personAge);


            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.

                    Console.WriteLine($"{personName} with the age {personAge} has been added to the personAgeDictionary.");
                }
                else
                {
                    Console.WriteLine("InvalidAgeInput, Please enter a valid age.")
                        }
            else
                {
                    Console.WriteLine($"{personName} with age {personAge} already exists.")

                 }

            }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            // TODO 9: Remove the person from personList if they exist.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
        }
            Console.WriteLine("Please enter the name to be removed: ");
            string removeName = Console.ReadLine();

            if (personList.Contains(removeName))
            {
                personList.Remove(removeName);
                Console.WriteLine($"{removeName} has been removed from the person list.");
            }
            else
            {
                Console.WriteLine($"{removeName} does not exist in the person list. No changes have been made.");
            }

            if (personAgeDictionary.ContainsKey(removeName))
            {
                personAgeDictionary.Remove(removeName);
                Console.WriteLine($"{removeName} has been removed from the personAgeDictionary.");
            }
            else
            {
                Console.WriteLine($"{removeName} does not exist in the personAgeDictionary. No changes have been made.");
            }

        public static void FindPerson()
            {
                // TODO 13: Request user input for the name of the person to find.
                // TODO 14: Check if the person is in personList and provide appropriate feedback.
                // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
                Console.WriteLine("Please enter the name of the person to find: ");
                string personName = Console.ReadLine();
                bool personExistsInList = personList.Contains(personName);
                if (personExistsInList)
                {
                    Console.WriteLine($"{personName} exists in the person list.");
                        }
                else
                {
                    Console.WriteLine($"{personName} does not exist in the person list.");
                }
                if (personAgeDictionary.ContainsKey(personName))
                { Console.WriteLine($"{personName} exists in the personAgeDictionary"); 
                }
                else 
                { 
                    Console.WriteLine($"{personName} does not exist in the personAgeDictionary");
                }
        }

        public static void DisplayAllPersons()
        {
                // TODO 16: Iterate over personList and display each person's name.
                // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
                // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
         Console.WriteLine("Persons in personList:");
                    if (personList.Count == 0)
                    {
                        Console.WriteLine("No persons in the list.");
                    }
                    else
                    {
                        foreach (string person in personList)
                        {
                            Console.WriteLine(person);
                        }
                    }

                    Console.WriteLine("\nPersons in personAgeDictionary:");
                    if (personAgeDictionary.Count == 0)
                    {
                        Console.WriteLine("No persons in the dictionary.");
                    }
                    else
                    {
                        foreach (var entry in personAgeDictionary)
                        {
                            Console.WriteLine($"{entry.Key} - Age: {entry.Value}");
                        }
                    }
}
