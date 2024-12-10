namespace NaufysWardrobeWinForms
{
    partial class FormResult
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picCharacterBaseOri;
        private System.Windows.Forms.PictureBox picOriHat;
        private System.Windows.Forms.PictureBox picOriShirt;
        private System.Windows.Forms.PictureBox picOriPants;
        private System.Windows.Forms.PictureBox picOriShoes;

        private System.Windows.Forms.PictureBox picCharacterBasePlayer;
        private System.Windows.Forms.PictureBox picPlayerHat;
        private System.Windows.Forms.PictureBox picPlayerShirt;
        private System.Windows.Forms.PictureBox picPlayerPants;
        private System.Windows.Forms.PictureBox picPlayerShoes;

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRestart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picCharacterBaseOri = new System.Windows.Forms.PictureBox();
            this.picOriHat = new System.Windows.Forms.PictureBox();
            this.picOriShirt = new System.Windows.Forms.PictureBox();
            this.picOriPants = new System.Windows.Forms.PictureBox();
            this.picOriShoes = new System.Windows.Forms.PictureBox();
            this.picCharacterBasePlayer = new System.Windows.Forms.PictureBox();
            this.picPlayerHat = new System.Windows.Forms.PictureBox();
            this.picPlayerShirt = new System.Windows.Forms.PictureBox();
            this.picPlayerPants = new System.Windows.Forms.PictureBox();
            this.picPlayerShoes = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBaseOri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriShoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBasePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // FormResult
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.FormResult_Load);

            // Original Character
            this.picCharacterBaseOri.Location = new System.Drawing.Point(150, 100);
            this.picCharacterBaseOri.Size = new System.Drawing.Size(300, 450);
            this.picCharacterBaseOri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picOriHat.Location = new System.Drawing.Point(170, 90);
            this.picOriHat.Size = new System.Drawing.Size(260, 80);
            this.picOriHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriHat.BackColor = System.Drawing.Color.Transparent;

            this.picOriShirt.Location = new System.Drawing.Point(160, 220);
            this.picOriShirt.Size = new System.Drawing.Size(280, 140);
            this.picOriShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriShirt.BackColor = System.Drawing.Color.Transparent;

            this.picOriPants.Location = new System.Drawing.Point(165, 360);
            this.picOriPants.Size = new System.Drawing.Size(270, 110);
            this.picOriPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriPants.BackColor = System.Drawing.Color.Transparent;

            this.picOriShoes.Location = new System.Drawing.Point(170, 470);
            this.picOriShoes.Size = new System.Drawing.Size(260, 70);
            this.picOriShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriShoes.BackColor = System.Drawing.Color.Transparent;

            // Player Character
            this.picCharacterBasePlayer.Location = new System.Drawing.Point(550, 100);
            this.picCharacterBasePlayer.Size = new System.Drawing.Size(300, 450);
            this.picCharacterBasePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picPlayerHat.Location = new System.Drawing.Point(570, 90);
            this.picPlayerHat.Size = new System.Drawing.Size(260, 80);
            this.picPlayerHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerHat.BackColor = System.Drawing.Color.Transparent;

            this.picPlayerShirt.Location = new System.Drawing.Point(560, 220);
            this.picPlayerShirt.Size = new System.Drawing.Size(280, 140);
            this.picPlayerShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerShirt.BackColor = System.Drawing.Color.Transparent;

            this.picPlayerPants.Location = new System.Drawing.Point(565, 360);
            this.picPlayerPants.Size = new System.Drawing.Size(270, 110);
            this.picPlayerPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerPants.BackColor = System.Drawing.Color.Transparent;

            this.picPlayerShoes.Location = new System.Drawing.Point(570, 470);
            this.picPlayerShoes.Size = new System.Drawing.Size(260, 70);
            this.picPlayerShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerShoes.BackColor = System.Drawing.Color.Transparent;

            this.lblScore.Location = new System.Drawing.Point(362, 600);
            // (1024 / 2) = 512, 512 - 150 = 362
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            this.btnRestart.Location = new System.Drawing.Point(462, 650);
            // (1024 / 2) = 512, 512 - 150 = 362
            this.btnRestart.Size = new System.Drawing.Size(100, 40);
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);

            // Add all controls
            this.Controls.Add(this.picCharacterBaseOri);
            this.Controls.Add(this.picOriHat);
            this.Controls.Add(this.picOriShirt);
            this.Controls.Add(this.picOriPants);
            this.Controls.Add(this.picOriShoes);

            this.Controls.Add(this.picCharacterBasePlayer);
            this.Controls.Add(this.picPlayerHat);
            this.Controls.Add(this.picPlayerShirt);
            this.Controls.Add(this.picPlayerPants);
            this.Controls.Add(this.picPlayerShoes);

            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRestart);

            // Adjust layering
            this.picCharacterBaseOri.SendToBack();
            this.picCharacterBasePlayer.SendToBack();

            this.picOriHat.BringToFront();
            this.picOriShirt.BringToFront();
            this.picOriPants.BringToFront();
            this.picOriShoes.BringToFront();

            this.picPlayerHat.BringToFront();
            this.picPlayerShirt.BringToFront();
            this.picPlayerPants.BringToFront();
            this.picPlayerShoes.BringToFront();

            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBaseOri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriShoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBasePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerShoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
