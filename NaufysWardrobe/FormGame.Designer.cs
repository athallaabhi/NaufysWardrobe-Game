namespace NaufysWardrobeWinForms
{
    partial class FormGame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picCharacterBase;
        private System.Windows.Forms.PictureBox picHat;
        private System.Windows.Forms.PictureBox picShirt;
        private System.Windows.Forms.PictureBox picPants;
        private System.Windows.Forms.PictureBox picShoes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picCharacterBase = new System.Windows.Forms.PictureBox();
            this.picHat = new System.Windows.Forms.PictureBox();
            this.picShirt = new System.Windows.Forms.PictureBox();
            this.picPants = new System.Windows.Forms.PictureBox();
            this.picShoes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // picCharacterBase
            // 
            this.picCharacterBase.Location = new System.Drawing.Point(50, 30);
            this.picCharacterBase.Size = new System.Drawing.Size(200, 300);
            this.picCharacterBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // picHat
            // (Placed near top of character)
            this.picHat.Location = new System.Drawing.Point(90, 40);
            this.picHat.Size = new System.Drawing.Size(60, 60);
            this.picHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHat.BackColor = System.Drawing.Color.Transparent;
            this.picHat.BringToFront();
            // 
            // picShirt
            // (Placed around torso)
            this.picShirt.Location = new System.Drawing.Point(80, 120);
            this.picShirt.Size = new System.Drawing.Size(80, 80);
            this.picShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShirt.BackColor = System.Drawing.Color.Transparent;
            this.picShirt.BringToFront();
            // 
            // picPants
            // (Placed around lower body)
            this.picPants.Location = new System.Drawing.Point(85, 200);
            this.picPants.Size = new System.Drawing.Size(70, 70);
            this.picPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPants.BackColor = System.Drawing.Color.Transparent;
            this.picPants.BringToFront();
            // 
            // picShoes
            // (Placed near feet)
            this.picShoes.Location = new System.Drawing.Point(90, 270);
            this.picShoes.Size = new System.Drawing.Size(60, 40);
            this.picShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShoes.BackColor = System.Drawing.Color.Transparent;
            this.picShoes.BringToFront();
            // 
            // FormGame
            // 
            this.ClientSize = new System.Drawing.Size(320, 400);
            this.Controls.Add(this.picHat);
            this.Controls.Add(this.picShirt);
            this.Controls.Add(this.picPants);
            this.Controls.Add(this.picShoes);
            this.Controls.Add(this.picCharacterBase);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observe the Outfit";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
