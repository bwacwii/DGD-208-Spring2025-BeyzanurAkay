using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Game
{
    private bool isRunning;
    private List<Pet> playerPets = new List<Pet>();
    private const int maxPets = 3;

    public async Task GameLoop()
    {
        Initialize();

        isRunning = true;
        while (isRunning)
        {
            await ShowMainMenu();
        }

        Console.WriteLine("Thanks for playing!");
    }

    private void Initialize()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Pet Adoption Game!");
        Console.WriteLine();
    }

    private async Task ShowMainMenu()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Adopt a Pet");
        Console.WriteLine("2. Check Your Pets");
        Console.WriteLine("3. Play with Your Pets"); // 🔼 Menüde yukarı alındı
        Console.WriteLine("4. Credits");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");

        string userChoice = Console.ReadLine();
        await ProcessUserChoice(userChoice);
    }

    private async Task ProcessUserChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                if (playerPets.Count >= maxPets)
                {
                    Console.WriteLine("\n⚠️ You already have the maximum number of pets (3). Please take care of them first!");
                }
                else
                {
                    Pet newPet = PetManager.adoptPet();
                    if (newPet != null)
                    {
                        playerPets.Add(newPet);
                    }
                }
                break;

            case "2":
                if (playerPets.Count == 0)
                {
                    Console.WriteLine("😢 You don't have any pets yet.");
                }
                else
                {
                    foreach (var pet in playerPets)
                    {
                        Console.WriteLine($"\n{pet.Name} the {pet.Type}:");
                        pet.printStats();
                    }
                }
                break;

            case "3":
                if (playerPets.Count == 0)
                {
                    Console.WriteLine("😢 You don't have any pets to play with.");
                }
                else
                {
                    await ShowPetMenu();
                }
                break;

            case "4":
                Console.Clear();
                Console.WriteLine("👩‍🎓 Beyzanur Akay - 225040069 feat AI!");
                break;

            case "5":
                isRunning = false;
                Console.WriteLine("Exiting the game... Please don't buy animals, adopt them... bye");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        await Task.Delay(500);
        Console.WriteLine();
    }

    private async Task ShowPetMenu()
    {
        Console.WriteLine("\nWhich pet would you like to interact with?");
        for (int i = 0; i < playerPets.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {playerPets[i].Name} the {playerPets[i].Type}");
        }
        Console.Write("Enter the number of the pet: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int index) && index >= 1 && index <= playerPets.Count)
        {
            await ShowSinglePetMenu(playerPets[index - 1]);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private async Task ShowSinglePetMenu(Pet pet)
    {
        Console.WriteLine($"\n{pet.Name}'s Menu:");
        Console.WriteLine("1. Check Stats");
        Console.WriteLine("2. Play");
        Console.WriteLine("3. Feed");
        Console.WriteLine("4. Abandon");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                pet.printStats();
                break;
            case "2":
                pet.adjustStat(petStat.Fun, 10);
                break;
            case "3":
                pet.adjustStat(petStat.Hunger, 10);
                break;
            case "4":
                Console.Write("Are you sure you want to abandon your pet? (yes/no): ");
                if (Console.ReadLine()?.ToLower() == "yes")
                {
                    Console.WriteLine($"😿 You abandoned {pet.Name}. Hope you feel bad!");
                    playerPets.Remove(pet);
                }
                else
                {
                    Console.WriteLine("You chose to keep your pet. Good decision!");
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        await Task.Delay(500);
    }
}
