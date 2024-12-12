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
            this.picCharacterBase.Location = new System.Drawing.Point(362, 159);
            this.picCharacterBase.Name = "picCharacterBase";
            this.picCharacterBase.Size = new System.Drawing.Size(300, 450);
            this.picCharacterBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacterBase.TabIndex = 4;
            this.picCharacterBase.TabStop = false;
            // 
            // picHat
            // 
            this.picHat.BackColor = System.Drawing.Color.Transparent;
            this.picHat.Location = new System.Drawing.Point(452, 99);
            this.picHat.Name = "picHat";
            this.picHat.Size = new System.Drawing.Size(121, 106);
            this.picHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHat.TabIndex = 3;
            this.picHat.TabStop = false;
            // 
            // picShirt
            // 
            this.picShirt.BackColor = System.Drawing.Color.Transparent;
            this.picShirt.Location = new System.Drawing.Point(392, 260);
            this.picShirt.Name = "picShirt";
            this.picShirt.Size = new System.Drawing.Size(240, 120);
            this.picShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShirt.TabIndex = 2;
            this.picShirt.TabStop = false;
            // 
            // picPants
            // 
            this.picPants.BackColor = System.Drawing.Color.Transparent;
            this.picPants.Location = new System.Drawing.Point(402, 369);
            this.picPants.Name = "picPants";
            this.picPants.Size = new System.Drawing.Size(220, 187);
            this.picPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPants.TabIndex = 1;
            this.picPants.TabStop = false;
            // 
            // picShoes
            // 
            this.picShoes.BackColor = System.Drawing.Color.Transparent;
            this.picShoes.Location = new System.Drawing.Point(432, 526);
            this.picShoes.Name = "picShoes";
            this.picShoes.Size = new System.Drawing.Size(161, 147);
            this.picShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShoes.TabIndex = 0;
            this.picShoes.TabStop = false;
            // 
            // FormGame
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.picShoes);
            this.Controls.Add(this.picPants);
            this.Controls.Add(this.picShirt);
            this.Controls.Add(this.picHat);
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
