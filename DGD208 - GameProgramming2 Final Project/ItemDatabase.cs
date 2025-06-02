public static class ItemDatabase
{
    public static List<Item> allItems = new List<Item>
    {
        // Otter Items
        new Item {
            name = "Fresh Fish",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.Otter, petType.OrangeCat },
            affectedStat = petStat.Hunger,
            effectAmount = 25,
            duration = 2.5f
        },
        new Item {
            name = "Crab Treat",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.Otter },
            affectedStat = petStat.Hunger,
            effectAmount = 15,
            duration = 1.5f 
        },
        new Item {
            name = "River Snack",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.Otter },
            affectedStat = petStat.Hunger,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "Shell Pillow",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.Otter },
            affectedStat = petStat.Sleep,
            effectAmount = 20,
            duration = 2.0f
        },
        new Item {
            name = "Water Hammock",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.Otter },
            affectedStat = petStat.Sleep,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "Floating Toy",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.Otter, petType.Capybara },
            affectedStat = petStat.Fun,
            effectAmount = 20,
            duration = 2.0f
        },
        new Item {
            name = "River Pebbles",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.Otter },
            affectedStat = petStat.Fun,
            effectAmount = 20,
            duration = 2.0f
        },

        // Cat Items
        new Item {
            name = "Canned Tuna",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.OrangeCat, petType.Otter },
            affectedStat = petStat.Hunger,
            effectAmount = 15,
            duration = 1.5f
        },
        new Item {
            name = "Chicken Bites",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Hunger,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "Milk Bowl",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Hunger,
            effectAmount = 20,
            duration = 2.0f
        },
        new Item {
            name = "Cozy Blanket",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Sleep,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "Radiator Bed",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Sleep,
            effectAmount = 40,
            duration = 4.0f
        },
        new Item {
            name = "Laser Pointer",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Fun,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "Yarn Ball",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.OrangeCat },
            affectedStat = petStat.Fun,
            effectAmount = 15,
            duration = 1.5f
        },

        // Capybara Items
        new Item {
            name = "Leafy Greens",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Hunger,
            effectAmount = 15,
            duration = 1.5f
        },
        new Item {
            name = "Watermelon Slice",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Hunger,
            effectAmount = 20,
            duration = 2.0f
        },
        new Item {
            name = "Sweet Potato",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Hunger,
            effectAmount = 40,
            duration = 4.0f
        },
        new Item {
            name = "Mud Bed",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Sleep,
            effectAmount = 40,
            duration = 4.0f
        },
        new Item {
            name = "Shade Mat",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Sleep,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "Bamboo Stick",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Fun,
            effectAmount = 20,
            duration = 2.0f
        },
        new Item {
            name = "Water Splash Pad",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.Capybara },
            affectedStat = petStat.Fun,
            effectAmount = 25,
            duration = 2.5f
        },

        // Nugget Items
        new Item {
            name = "Nugget's Favorite Mystery Snack",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.AloneNugget },
            affectedStat = petStat.Hunger,
            effectAmount = 50,
            duration = 5.0f
        },

       
        new Item {
            name = "Ketchup",
            type = itemType.Food,
            compatibleWith = new List<petType> { petType.AloneNugget },
            affectedStat = petStat.Hunger,
            effectAmount = 25,
            duration = 2.5f
        },
        new Item {
            name = "Plate with lettuce on it",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.AloneNugget },
            affectedStat = petStat.Sleep,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "Small nugget to cuddle",
            type = itemType.SleepAid,
            compatibleWith = new List<petType> { petType.AloneNugget },
            affectedStat = petStat.Sleep,
            effectAmount = 40,
            duration = 4.0f
        },
        new Item {
            name = "Small nugget textured stone",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.AloneNugget, petType.Otter },
            affectedStat = petStat.Fun,
            effectAmount = 30,
            duration = 3.0f
        },
        new Item {
            name = "A packet of sauce for dipping",
            type = itemType.Toy,
            compatibleWith = new List<petType> { petType.AloneNugget },
            affectedStat = petStat.Fun,
            effectAmount = 40,
            duration = 4.0f
        }
    };
}
