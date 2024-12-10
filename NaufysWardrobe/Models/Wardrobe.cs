using System;
using System.Collections.Generic;

namespace NaufysWardrobeWinForms.Models
{
    public class Wardrobe
    {
        public List<ClothingItem> Hats { get; set; } = new List<ClothingItem>();
        public List<ClothingItem> Shirts { get; set; } = new List<ClothingItem>();
        public List<ClothingItem> Pants { get; set; } = new List<ClothingItem>();
        public List<ClothingItem> Shoes { get; set; } = new List<ClothingItem>();

        private Random rand = new Random();

        public Wardrobe()
        {
            // Two variants for each category:
            Hats.Add(new ClothingItem("Hat", "Hat1", "Images/Hats/hat1.png"));
            Hats.Add(new ClothingItem("Hat", "Hat2", "Images/Hats/hat2.png"));

            Shirts.Add(new ClothingItem("Shirt", "Shirt1", "Images/Shirts/shirt1.png"));
            Shirts.Add(new ClothingItem("Shirt", "Shirt2", "Images/Shirts/shirt2.png"));

            Pants.Add(new ClothingItem("Pants", "Pants1", "Images/Pants/pants1.png"));
            Pants.Add(new ClothingItem("Pants", "Pants2", "Images/Pants/pants2.png"));

            Shoes.Add(new ClothingItem("Shoes", "Shoes1", "Images/Shoes/shoes1.png"));
            Shoes.Add(new ClothingItem("Shoes", "Shoes2", "Images/Shoes/shoes2.png"));
        }

        public Outfit GetRandomOutfit()
        {
            return new Outfit
            {
                Hat = Hats[rand.Next(Hats.Count)],
                Shirt = Shirts[rand.Next(Shirts.Count)],
                Pants = Pants[rand.Next(Pants.Count)],
                Shoes = Shoes[rand.Next(Shoes.Count)]
            };
        }
    }
}
