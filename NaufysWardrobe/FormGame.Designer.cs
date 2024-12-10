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
            // FormGame
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observe the Outfit";
            // Add the load event handler back:
            this.Load += new System.EventHandler(this.FormGame_Load);
            // 
            // picCharacterBase
            // 
            this.picCharacterBase.Location = new System.Drawing.Point(362, 159);
            this.picCharacterBase.Size = new System.Drawing.Size(300, 450);
            this.picCharacterBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // picHat
            // 
            this.picHat.Location = new System.Drawing.Point(412, 120);
            this.picHat.Size = new System.Drawing.Size(200, 80);
            this.picHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHat.BackColor = System.Drawing.Color.Transparent;
            // 
            // picShirt
            // 
            this.picShirt.Location = new System.Drawing.Point(392, 260);
            this.picShirt.Size = new System.Drawing.Size(240, 120);
            this.picShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShirt.BackColor = System.Drawing.Color.Transparent;
            // 
            // picPants
            // 
            this.picPants.Location = new System.Drawing.Point(402, 380);
            this.picPants.Size = new System.Drawing.Size(220, 110);
            this.picPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPants.BackColor = System.Drawing.Color.Transparent;
            // 
            // picShoes
            // 
            this.picShoes.Location = new System.Drawing.Point(412, 490);
            this.picShoes.Size = new System.Drawing.Size(200, 70);
            this.picShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShoes.BackColor = System.Drawing.Color.Transparent;
            // 
            // Add controls
            // 
            this.Controls.Add(this.picShoes);
            this.Controls.Add(this.picPants);
            this.Controls.Add(this.picShirt);
            this.Controls.Add(this.picHat);
            this.Controls.Add(this.picCharacterBase);
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
