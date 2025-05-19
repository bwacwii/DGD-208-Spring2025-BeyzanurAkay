using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;



public enum petStat
{
    Hunger,
    Sleep,
    Fun
}

public class PetEventArgs : EventArgs
{
    public petStat Stat { get; }
    public int Value { get; }

    public PetEventArgs(petStat stat, int value)
    {
        Stat = stat;
        Value = value;
    }
}

public class Pet
{
    public string Name { get; }
    public petType Type { get; }
    private Dictionary<petStat, int> stats;
    private CancellationTokenSource statDecayTokenSource;

    public event EventHandler<PetEventArgs> statChanged;
    public event EventHandler<PetEventArgs> petDied;

    public Pet(string name, petType type)
    {
        Name = name;
        Type = type;
        stats = new Dictionary<petStat, int>
        {
            { petStat.Hunger, 50 },
            { petStat.Sleep, 50 },
            { petStat.Fun,   50 }
        };

        startStatDecay();
    }

    public int GetStat(petStat stat) => stats[stat];

    public void adjustStat(petStat stat, int amount, bool silent = false)
    {
        if (!stats.ContainsKey(stat)) return;

        stats[stat] = Math.Clamp(stats[stat] + amount, 0, 100);

        if (!silent)
            onStatChanged(stat, stats[stat]);

        if (stats[stat] == 0)
        {
            onPetDied(stat);
        }
    }

    protected virtual void onStatChanged(petStat stat, int newValue)
    {
        statChanged?.Invoke(this, new PetEventArgs(stat, newValue));
    }

    protected virtual void onPetDied(petStat stat)
    {
        petDied?.Invoke(this, new PetEventArgs(stat, 0));
        statDecayTokenSource?.Cancel();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n💀 Your pet {Name} has died because their {stat} dropped to zero! You don't seem responsible enough to adopt an animal. Please don't adopt again. ");
        Console.ResetColor();
    }

    private async void startStatDecay()
    {
        statDecayTokenSource = new CancellationTokenSource();
        var token = statDecayTokenSource.Token;

        try
        {
            while (!token.IsCancellationRequested)
            {
                await Task.Delay(1000);

                foreach (petStat stat in Enum.GetValues(typeof(petStat)))
                {
                    adjustStat(stat, -1, true);
                }
            }
        }
        catch (TaskCanceledException)
        {
       
        }
    }

    public async Task useItemAsync(petStat targetStat, int effectAmount)
    {
        Console.WriteLine($"\n Using item on {targetStat}...");
        await Task.Delay(500);
        adjustStat(targetStat, effectAmount);
        Console.WriteLine($" {Name}'s {targetStat} increased by {effectAmount}!");
    }

    public void printStats()
    {
        Console.WriteLine($"\n {Name}'s Current Stats:");
        foreach (var pair in stats)
        {
            Console.WriteLine($" - {pair.Key}: {pair.Value}");
        }
    }

    internal void adjustStat(petStat hunger, int v)
    {
        throw new NotImplementedException();
    }

    internal object getStat(petStat stat)
    {
        throw new NotImplementedException();
    }
}
