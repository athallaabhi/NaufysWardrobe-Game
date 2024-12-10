using System;
using System.Windows.Forms;
using NaufysWardrobeWinForms.Models;

namespace NaufysWardrobeWinForms
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.StartGame();
            FormGame fg = new FormGame(game);
            fg.Show();
            this.Hide();
        }
    }
}
