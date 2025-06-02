public static class PetManager
{
    public static Pet adoptPet()
    {
        Console.WriteLine("Choose your new lil pet:");
        int index = 1;
        foreach (var pet in Enum.GetValues(typeof(petType)))
        {
            Console.WriteLine($"{index}. {pet}");
            index++;
        }
        Console.Write("Enter the number of the pet you want to adopt (I hope you don't want to adopt an orange cat...) :");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int selectedIndex) && selectedIndex >= 1 && selectedIndex <= Enum.GetValues(typeof(petType)).Length)
        {
            var selectedPet = (petType)Enum.GetValues(typeof(petType)).GetValue(selectedIndex - 1);
            Console.Write("Please enter a name for your cutie mutie pie pet: ");
            string name = Console.ReadLine();
            var pet = new Pet(name, selectedPet);

            pet.statChanged += (sender, e) =>
            {
                Console.WriteLine($"{((Pet)sender).Name}'s {e.Stat} changed to {e.Value}");
            };

            pet.petDied += (sender, e) =>
            {
                Console.WriteLine($"Oh no! {((Pet)sender).Name} has died due to lack of {e.Stat}!");
            };

            Console.WriteLine($"You adopted a {selectedPet} named {name}! He/she is saying thank you to you with wet eyes.");
            Console.WriteLine("Initial Stats:");
            foreach (petStat stat in Enum.GetValues(typeof(petStat)))
            {
                Console.WriteLine($"{stat}: {pet.GetStat(stat)}");
            }

            return pet;
        }
        else
        {
            Console.WriteLine("Invalid selection. Returning to main menu.");
            return null;
        }
    }
}
