namespace NaufysWardrobeWinForms.Models
{
    public class Game
    {
        public Outfit OriginalOutfit { get; set; }
        public Outfit PlayerOutfit { get; set; }
        public Wardrobe Wardrobe { get; set; }
        public ScoreManager ScoreManager { get; set; }

        public Game()
        {
            Wardrobe = new Wardrobe();
            ScoreManager = new ScoreManager();
        }

        public void StartGame()
        {
            OriginalOutfit = Wardrobe.GetRandomOutfit();
            PlayerOutfit = new Outfit();
        }

        public int EvaluateOutfit()
        {
            return OriginalOutfit.Compare(PlayerOutfit);
        }
    }
}
