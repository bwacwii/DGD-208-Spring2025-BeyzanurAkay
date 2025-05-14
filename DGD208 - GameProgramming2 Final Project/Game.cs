using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DGD208___GameProgramming2_Final_Project;


public class PetEventArgs : EventArgs
{
    public PetStat Stat { get; }
    public int Value { get; }

    public PetEventArgs(PetStat stat, int value)
    {
        Stat = stat;
        Value = value;
    }
}

public class Pet
{
    public string Name { get; }
    public PetType Type { get; }
    private Dictionary<PetStat, int> stats;

    public event EventHandler<PetEventArgs> StatChanged;
    public event EventHandler<PetEventArgs> PetDied;

    public Pet(string name, PetType type)
    {
        Name = name;
        Type = type;
        stats = new Dictionary<PetStat, int>
        {
            { PetStat.Hunger, 50 },
            { PetStat.Sleep, 50 },
            { PetStat.Fun,   50 }
        };
    }

    public int GetStat(PetStat stat) => stats[stat];

    public void AdjustStat(PetStat stat, int amount)
    {
        if (!stats.ContainsKey(stat)) return;

        stats[stat] = Math.Clamp(stats[stat] + amount, 0, 100);
        OnStatChanged(stat, stats[stat]);

        if (stats[stat] == 0)
        {
            OnPetDied(stat);
        }
    }

    protected virtual void OnStatChanged(PetStat stat, int newValue)
        => StatChanged?.Invoke(this, new PetEventArgs(stat, newValue));

    protected virtual void OnPetDied(PetStat stat)
        => PetDied?.Invoke(this, new PetEventArgs(stat, 0));
}



public class Game
{
    private bool _isRunning;
    private Pet _playerPet;

    public async Task GameLoop()
    {
        Initialize();

        _isRunning = true;
        while (_isRunning)
        {
            if (_playerPet == null)
                await ShowMainMenu();
            else
                await ShowPetMenu();
        }

        Console.WriteLine("Thanks for playing!");
    }

    private void Initialize()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Pet Adoption Game! Would you like to get one?");
        Console.WriteLine();
    }

    private async Task ShowMainMenu()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Adopt a Pet");
        Console.WriteLine("2. Check Your Pet");
        Console.WriteLine("3. Credits");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");

        string userChoice = Console.ReadLine();
        await ProcessUserChoice(userChoice);
    }

    private async Task ShowPetMenu()
    {
        Console.WriteLine("\nPet Menu:");
        Console.WriteLine("1. Check your pet");
        Console.WriteLine("2. Play with your pet");
        Console.WriteLine("3. Feed your pet");
        Console.WriteLine("4. Throw it on the street (are you sure?)");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine($"Pet Name: {_playerPet.Name}");
                Console.WriteLine($"Pet Type: {_playerPet.Type}");
                foreach (PetStat stat in Enum.GetValues(typeof(PetStat)))
                {
                    Console.WriteLine($"{stat}: {_playerPet.GetStat(stat)}");
                }
                break;
            case "2":
                _playerPet.AdjustStat(PetStat.Fun, 10);
                break;
            case "3":
                _playerPet.AdjustStat(PetStat.Hunger, 10);
                break;
            case "4":
                Console.Write("Are you really sure you want to throw your pet like skipping stones on the sea ? (yes/no): ");
                string confirmation = Console.ReadLine()?.ToLower();
                if (confirmation == "yes")
                {
                    Console.WriteLine($"You left {_playerPet.Name} on the street. Hope you feel bad. Ohh and also he/she found a better fam. IF YOU CARE!");
                    _playerPet = null;
                }
                else
                {
                    Console.WriteLine("Good choice.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        await Task.Delay(500);
    }

    private async Task ProcessUserChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                Console.Clear();
                _playerPet = PetManager.AdoptPet();
                break;
            case "2":
                Console.Clear();
                if (_playerPet != null)
                {
                    Console.WriteLine($"Pet Name: {_playerPet.Name}");
                    Console.WriteLine($"Pet Type: {_playerPet.Type}");
                    foreach (PetStat stat in Enum.GetValues(typeof(PetStat)))
                    {
                        Console.WriteLine($"{stat}: {_playerPet.GetStat(stat)}");
                    }
                }
                else
                {
                    Console.WriteLine("You don't have a pet yet. Please choose a pet first. I HOPE YOU BROUGHT YOUR MONEY WITH YOU!");
                }
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Beyzanur Akay - 225040069 feat AI!");
                break;
            case "4":
                _isRunning = false;
                Console.WriteLine("Exiting the game...Please don't buy animals, adopt them.. bye");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        await Task.Delay(500);
        Console.WriteLine();
    }
}

public class Program
{
    public static async Task Main()
    {
        Game game = new Game();
        await game.GameLoop();
    }
}
