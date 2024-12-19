using System.Runtime.InteropServices;

//string[] ourAnimals = new string[] { "101.dog.3 years.pastor brown color.dynamic, happy.nick: Rocket.","101.dog.3 years.pastor brown color.dynamic, happy.nick: Rocket.","101.dog.3 years.pastor brown color.dynamic, happy.nick: Rocket."};
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// Create a 2D array to store information about the animals, no persistent storage
string[,] ourAnimals = new string[maxPets, 6];
// create some initial ourAnimals array entries
// Populate initial entries for the `ourAnimals` array
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }
// Store the data in the `ourAnimals` array
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// Main program loop for menu-driven options
int option = 0; // Initialize option variable
do{
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:1-9");
    Console.WriteLine("1. List all of our current pet information");
    Console.WriteLine("2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine("3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine("5. Edit an animal's age");
    Console.WriteLine("6. Edit an animal's personality description");
    Console.WriteLine("7. Display all cats with a specified characteristic");
    Console.WriteLine("8. Display all dogs with a specified characteristic");
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
// Capture menu selection from the user
    menuSelection = Console.ReadLine();
string anotherPet ="";
 int petCount = 0;
switch(menuSelection)
{
    case "1":
        // Option 1: List all current pet information
        anotherPet = "y";
        petCount = 0;
        Console.WriteLine("Press the Enter key to continue.");
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                petCount += 1;
                Console.WriteLine(ourAnimals[i, 0]);
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(ourAnimals[i, j]);
                }
            }
        }
        if (petCount < maxPets)
        {
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
        }

        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "2":
        // Option 2: Add a new animal to the `ourAnimals` array
		//Add a new animal friend to the ourAnimals array 
        anotherPet = "y";
        petCount = 0;
        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                    petCount += 1;
            }

        }

        if (petCount < maxPets)
        {
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);
                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)

                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                // get the pet's age. can be ? at initial entry. 
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }                    
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");                

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                   Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                   readResult = Console.ReadLine(); 
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }

                } while (animalPersonalityDescription == "");
                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");                
                
                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
        }

        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;        


    case "3":
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "4":
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();    
        break;

    case "5":
        break;

    case "6":
        break;

    case "7":
        break;

    case "8":
        break;

    case "Exit":
        Console.WriteLine($"You selected menu option {menuSelection}.");
        break;
    default:
        break;        
}    
} while (menuSelection != "exit"); // Continue loop until user chooses to exit