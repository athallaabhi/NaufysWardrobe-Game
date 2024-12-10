using System;
using System.IO;
using System.Windows.Forms;
using NaufysWardrobeWinForms.Models;

namespace NaufysWardrobeWinForms
{
    public partial class FormResult : Form
    {
        private Game game;

        public FormResult(Game currentGame)
        {
            InitializeComponent();

           
            game = currentGame;
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            // Load base character
            LoadImage(picCharacterBaseOri, "Images/characterBase.png");
            LoadImage(picCharacterBasePlayer, "Images/characterBase.png");

            // Load Original Outfit
            LoadImage(picOriHat, game.OriginalOutfit.Hat.ImagePath);
            LoadImage(picOriShirt, game.OriginalOutfit.Shirt.ImagePath);
            LoadImage(picOriPants, game.OriginalOutfit.Pants.ImagePath);
            LoadImage(picOriShoes, game.OriginalOutfit.Shoes.ImagePath);

            // Load Player Outfit
            LoadImage(picPlayerHat, game.PlayerOutfit.Hat.ImagePath);
            LoadImage(picPlayerShirt, game.PlayerOutfit.Shirt.ImagePath);
            LoadImage(picPlayerPants, game.PlayerOutfit.Pants.ImagePath);
            LoadImage(picPlayerShoes, game.PlayerOutfit.Shoes.ImagePath);

            int correct = game.EvaluateOutfit();
            int score = game.ScoreManager.CalculateScore(correct);
            string stars = new string('★', score) + new string('☆', 4 - score);
            lblScore.Text = $"Score: {stars} ({correct}/4 correct)";
        }

        private void LoadImage(PictureBox pb, string path)
        {
            if (File.Exists(path))
                pb.Image = System.Drawing.Image.FromFile(path);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            FormStart fs = new FormStart();
            fs.Show();
            this.Close();
        }
    }
}
