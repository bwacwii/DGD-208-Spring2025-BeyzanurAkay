public static class ItemManager
{
    public static async Task ShowFoodMenu(Pet pet)
    {
        var compatibleItems = ItemDatabase.allItems.FindAll(item =>
            item.type == itemType.Food && item.compatibleWith.Contains(pet.Type));

        if (compatibleItems.Count == 0)
        {
            Console.WriteLine("No suitable food for this pet.");
            return;
        }

        Console.WriteLine($"\nChoose a food for {pet.Name}:");
        for (int i = 0; i < compatibleItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {compatibleItems[i].name} (+{compatibleItems[i].effectAmount} {compatibleItems[i].affectedStat})");
        }

        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= compatibleItems.Count)
        {
            var selectedItem = compatibleItems[index - 1];
            pet.adjustStat(selectedItem.affectedStat, selectedItem.effectAmount);
            Console.WriteLine($"{pet.Name} enjoyed the {selectedItem.name}!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        await Task.Delay(500);
    }

    public static async Task ShowToyMenu(Pet pet)
    {
        var compatibleItems = ItemDatabase.allItems.FindAll(item =>
            item.type == itemType.Toy && item.compatibleWith.Contains(pet.Type));

        if (compatibleItems.Count == 0)
        {
            Console.WriteLine("No suitable toys for this pet.");
            return;
        }

        Console.WriteLine($"\nChoose a toy for {pet.Name}:");
        for (int i = 0; i < compatibleItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {compatibleItems[i].name} (+{compatibleItems[i].effectAmount} {compatibleItems[i].affectedStat})");
        }

        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= compatibleItems.Count)
        {
            var selectedItem = compatibleItems[index - 1];
            pet.adjustStat(selectedItem.affectedStat, selectedItem.effectAmount);
            Console.WriteLine($"{pet.Name} had fun with the {selectedItem.name}!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        await Task.Delay(500);
    }

    public static async Task ShowSleepMenu(Pet pet)
    {
        var compatibleItems = ItemDatabase.allItems.FindAll(item =>
            item.type == itemType.SleepAid && item.compatibleWith.Contains(pet.Type));

        if (compatibleItems.Count == 0)
        {
            Console.WriteLine("No suitable sleep items for this lil pet.");
            return;
        }

        Console.WriteLine($"\nChoose a sleep aid for {pet.Name}:");
        for (int i = 0; i < compatibleItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {compatibleItems[i].name} (+{compatibleItems[i].effectAmount} {compatibleItems[i].affectedStat})");
        }

        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= compatibleItems.Count)
        {
            var selectedItem = compatibleItems[index - 1];
            pet.adjustStat(selectedItem.affectedStat, selectedItem.effectAmount);
            Console.WriteLine($"{pet.Name} slept well with the {selectedItem.name}.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        await Task.Delay(500);
    }
}
