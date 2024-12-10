using System;
using System.IO;
using System.Windows.Forms;
using NaufysWardrobeWinForms.Models;

namespace NaufysWardrobeWinForms
{
    public partial class FormGame : Form
    {
        private Game game;
        private Timer displayTimer;

        public FormGame(Game currentGame)
        {
            InitializeComponent();

           
            game = currentGame;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            DisplayOutfit();
            displayTimer = new Timer();
            displayTimer.Interval = 5000; // 5 seconds
            displayTimer.Tick += DisplayTimer_Tick;
            displayTimer.Start();
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            displayTimer.Stop();
            var fw = new FormWardrobe(game);
            fw.Show();
            this.Close();
        }

        private void DisplayOutfit()
        {
            // Load the base character first
            LoadImage(picCharacterBase, "Images/characterBase.png");

            // Now load each clothing item
            LoadImage(picHat, game.OriginalOutfit.Hat.ImagePath);
            LoadImage(picShirt, game.OriginalOutfit.Shirt.ImagePath);
            LoadImage(picPants, game.OriginalOutfit.Pants.ImagePath);
            LoadImage(picShoes, game.OriginalOutfit.Shoes.ImagePath);
        }

        private void LoadImage(PictureBox pb, string path)
        {
            if (File.Exists(path))
                pb.Image = System.Drawing.Image.FromFile(path);
        }

        private void picHat_Click(object sender, EventArgs e)
        {

        }
    }
}
