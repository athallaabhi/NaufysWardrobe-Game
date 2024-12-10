namespace NaufysWardrobeWinForms.Models
{
    public class ClothingItem
    {
        public string Type { get; set; }    // "Hat", "Shirt", "Pants", "Shoes"
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public ClothingItem(string type, string name, string imagePath)
        {
            Type = type;
            Name = name;
            ImagePath = imagePath;
        }
    }
}
