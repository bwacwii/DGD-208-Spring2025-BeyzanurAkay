public static class ItemDatabase
{
    public static List<Item> allItems = new List<Item>
    {
        // Otter Items
        new Item {
            name = "Fresh Fish",
            type = ItemType.Food,
            compatibleWith = new List<petType> { petType.Otter, petType.OrangeCat },
            affectedStat = petStat.Hunger,
            effectAmount = 20,
            duration = 2.5f
        },
        new Item {
            name = "Shell Pillow",
            type = ItemType.SleepAid,
            compatibleWith = new List<petType> { petType.Otter },
            affectedStat = petStat.Sleep,
            effectAmount = 25,
            duration = 3.0f
        },
        new Item {
            name = "Floating Toy",
            type = ItemType.Toy,
            compatibleWith = new List<petType> { petType.Otter, petType.Capybara },
            affectedStat = petStat.Fun,
            effectAmount = 30,
            duration = 1.5f
        },

        // Cat Items
        new Item {
            name = "Canned Tuna",
            type = ItemType.Food,
            compatibleWith = new List<petType> { petType.OrangeCat, petType.Otter },
            affectedStat = petStat.Hunger,
            effectAmount = 18,
            duration = 2.0f
        },
        new Item {
            name = "Cozy Blanket",
            type = ItemType.SleepAid,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Sleep,
            effectAmount = 30,
            duration = 2.5f
        },
        new Item {
            name = "Laser Pointer",
            type = ItemType.Toy,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Fun,
            effectAmount = 28,
            duration = 1.0f
        },

        // Capybara Items
        new Item {
            name = "Leafy Greens",
            type = ItemType.Food,
            compatibleWith = new List<petType> { petType.Capybara, petType.AloneNugget },
            affectedStat = petStat.Hunger,
            effectAmount = 25,
            duration = 3.0f
        },
        new Item {
            name = "Mud Bed",
            type = ItemType.SleepAid,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Sleep,
            effectAmount = 35,
            duration = 4.0f
        },
        new Item {
            name = "Bamboo Stick",
            type = ItemType.Toy,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Fun,
            effectAmount = 20,
            duration = 2.0f
        },

        // Nugget Items
        new Item {
            name = "Mystery Meat",
            type = ItemType.Food,
            compatibleWith = new List<petType> { petType.AloneNugget },
            affectedStat = petStat.Hunger,
            effectAmount = 22,
            duration = 2.0f
        },
        new Item {
            name = "Shadow Nest",
            type = ItemType.SleepAid,
            compatibleWith = new List<petType> { petType.AloneNugget },
            affectedStat = petStat.Sleep,
            effectAmount = 28,
            duration = 3.5f
        },
        new Item {
            name = "Squeaky Bone",
            type = ItemType.Toy,
            compatibleWith = new List<petType> { petType.AloneNugget, petType.Otter },
            affectedStat = petStat.Fun,
            effectAmount = 24,
            duration = 1.2f
        }
    };
}
