using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_01_lab_02_Cars_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet("Rex", 5, "A playful dog");
            Pet pet2 = new Pet("Mittens", 3, "A lazy cat");
            Pet pet3 = new Pet("Bubbles", 2, "A colorful fish");
            Pet pet4 = new Pet("Tweety", 1, "A chirpy bird");
            List<Pet> pets = new List<Pet> { pet1, pet2, pet3, pet4 };

            pet1.SetOwner("John");
            pet2.SetOwner("Jane");
            pet3.Train();

            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet);
            }

            Console.Write("Enter owner's name: ");
            string ownerName = Console.ReadLine();
            var ownedPets = pets.Where(pet => pet.IsOwnedBy(ownerName));

            foreach (Pet pet in ownedPets)
            {
                Console.WriteLine(pet);
            }
        }
    }

    public class Pet
    {
        public string Name { get; }
        private string Owner { get; set; } = null!;
        public int Age { get; }
        public string Description { get; }
        private bool IsHouseTrained { get; set; }

        public Pet(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = null!;
            IsHouseTrained = false;
        }

        public void SetOwner(string newOwner)
        {
            Owner = newOwner;
        }

        public void Train()
        {
            IsHouseTrained = true;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Description: {Description}, Owner: {Owner}, IsHouseTrained: {IsHouseTrained}";
        }

        public bool IsOwnedBy(string? ownerName)
        {
            return ownerName != null && Owner == ownerName;
        }
    }
}
