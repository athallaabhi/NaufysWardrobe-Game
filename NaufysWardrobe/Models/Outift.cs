namespace NaufysWardrobeWinForms.Models
{
    public class Outfit
    {
        public ClothingItem Hat { get; set; }
        public ClothingItem Shirt { get; set; }
        public ClothingItem Pants { get; set; }
        public ClothingItem Shoes { get; set; }

        public int Compare(Outfit otherOutfit)
        {
            int correct = 0;
            if (Hat != null && otherOutfit.Hat != null && Hat.Name == otherOutfit.Hat.Name) correct++;
            if (Shirt != null && otherOutfit.Shirt != null && Shirt.Name == otherOutfit.Shirt.Name) correct++;
            if (Pants != null && otherOutfit.Pants != null && Pants.Name == otherOutfit.Pants.Name) correct++;
            if (Shoes != null && otherOutfit.Shoes != null && Shoes.Name == otherOutfit.Shoes.Name) correct++;
            return correct;
        }
    }
}
