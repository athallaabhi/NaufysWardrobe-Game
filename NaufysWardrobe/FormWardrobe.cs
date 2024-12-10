using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NaufysWardrobeWinForms.Models;

namespace NaufysWardrobeWinForms
{
    public partial class FormWardrobe : Form
    {
        private Game game;
        private GameTimer timer;

        public FormWardrobe(Game currentGame)
        {
            InitializeComponent();

            game = currentGame;
        }

        private void FormWardrobe_Load(object sender, EventArgs e)
        {
            cmbHat.DataSource = game.Wardrobe.Hats.Select(x => x.Name).ToList();
            cmbShirt.DataSource = game.Wardrobe.Shirts.Select(x => x.Name).ToList();
            cmbPants.DataSource = game.Wardrobe.Pants.Select(x => x.Name).ToList();
            cmbShoes.DataSource = game.Wardrobe.Shoes.Select(x => x.Name).ToList();

            timer = new GameTimer(30);
            timer.Tick += Timer_Tick;
            timer.TimesUp += Timer_TimesUp;
            timer.StartTimer();
        }

        private void Timer_Tick(int remaining)
        {
            lblTimer.Text = $"Time left: {remaining}s";
        }

        private void Timer_TimesUp()
        {
            SelectOutfit();
            GoToResult();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            timer.StopTimer();
            SelectOutfit();
            GoToResult();
        }

        private void SelectOutfit()
        {
            if (cmbHat.SelectedItem != null)
                game.PlayerOutfit.Hat = game.Wardrobe.Hats.Find(x => x.Name == cmbHat.SelectedItem.ToString());
            else
                game.PlayerOutfit.Hat = game.OriginalOutfit.Hat;

            if (cmbShirt.SelectedItem != null)
                game.PlayerOutfit.Shirt = game.Wardrobe.Shirts.Find(x => x.Name == cmbShirt.SelectedItem.ToString());
            else
                game.PlayerOutfit.Shirt = game.OriginalOutfit.Shirt;

            if (cmbPants.SelectedItem != null)
                game.PlayerOutfit.Pants = game.Wardrobe.Pants.Find(x => x.Name == cmbPants.SelectedItem.ToString());
            else
                game.PlayerOutfit.Pants = game.OriginalOutfit.Pants;

            if (cmbShoes.SelectedItem != null)
                game.PlayerOutfit.Shoes = game.Wardrobe.Shoes.Find(x => x.Name == cmbShoes.SelectedItem.ToString());
            else
                game.PlayerOutfit.Shoes = game.OriginalOutfit.Shoes;
        }

        private void GoToResult()
        {
            FormResult fr = new FormResult(game);
            fr.Show();
            this.Close();
        }

        private void cmbHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemImage(cmbHat, game.Wardrobe.Hats, picSelectedHat);
        }

        private void cmbShirt_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemImage(cmbShirt, game.Wardrobe.Shirts, picSelectedShirt);
        }

        private void cmbPants_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemImage(cmbPants, game.Wardrobe.Pants, picSelectedPants);
        }

        private void cmbShoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemImage(cmbShoes, game.Wardrobe.Shoes, picSelectedShoes);
        }

        private void UpdateSelectedItemImage(ComboBox combo, System.Collections.Generic.List<ClothingItem> items, PictureBox pictureBox)
        {
            if (combo.SelectedItem != null)
            {
                var itemName = combo.SelectedItem.ToString();
                var item = items.Find(x => x.Name == itemName);
                if (item != null && File.Exists(item.ImagePath))
                {
                    pictureBox.Image = System.Drawing.Image.FromFile(item.ImagePath);
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
            else
            {
                pictureBox.Image = null;
            }
        }
    }
}
