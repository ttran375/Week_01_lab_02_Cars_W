using System;
using System.Collections.Generic;

class Pet
{
    public string Name { get; }
    public string Owner { get; private set; }
    public int Age { get; }
    public string Description { get; }
    private bool IsHouseTrained { get; set; }

    public Pet(string name, int age, string description)
    {
        Name = name;
        Age = age;
        Description = description;
        Owner = "no one";
        IsHouseTrained = false;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Description: {Description}, Owner: {Owner}, IsHouseTrained: {IsHouseTrained}";
    }

    public void SetOwner(string newOwner)
    {
        Owner = newOwner;
    }

    public void Train()
    {
        IsHouseTrained = true;
    }
}

class Program
{
    static void Main()
    {
        List<Pet> petList = new List<Pet>();

        // Create four objects
        Pet pet1 = new Pet("Dog1", 2, "Friendly dog");
        Pet pet2 = new Pet("Cat1", 1, "Playful cat");
        Pet pet3 = new Pet("Parrot1", 3, "Colorful parrot");
        Pet pet4 = new Pet("Fish1", 1, "Beautiful fish");

        // Add objects to the list
        petList.Add(pet1);
        petList.Add(pet2);
        petList.Add(pet3);
        petList.Add(pet4);

        // Use some methods
        pet1.Train();
        pet2.SetOwner("John");

        // Display all objects in the collection
        Console.WriteLine("All Pets:");
        foreach (Pet pet in petList)
        {
            Console.WriteLine(pet.ToString());
        }

        // Prompt user for an owner's name
        // Prompt user for an owner's name
        Console.Write("\nEnter owner's name to filter pets: ");
        string? ownerName = Console.ReadLine();

        // Check if the input is not null before proceeding
        if (ownerName != null)
        {
            // Display pets belonging to a particular person
            Console.WriteLine($"\nPets belonging to {ownerName}:");
            foreach (Pet pet in petList)
            {
                if (pet.Owner.Equals(ownerName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(pet.ToString());
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input for owner's name.");
        }


        // Display pets belonging to a particular person
        Console.WriteLine($"\nPets belonging to {ownerName}:");
        foreach (Pet pet in petList)
        {
            if (pet.Owner.Equals(ownerName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(pet.ToString());
            }
        }
    }
}
