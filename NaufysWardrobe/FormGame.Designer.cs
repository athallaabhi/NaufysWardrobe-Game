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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // picCharacterBase
            // 
            this.picCharacterBase.BackColor = System.Drawing.Color.Transparent;
            this.picCharacterBase.Location = new System.Drawing.Point(262, 173);
            this.picCharacterBase.Name = "picCharacterBase";
            this.picCharacterBase.Size = new System.Drawing.Size(500, 500);
            this.picCharacterBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacterBase.TabIndex = 4;
            this.picCharacterBase.TabStop = false;
            // 
            // picHat
            // 
            this.picHat.BackColor = System.Drawing.Color.Transparent;
            this.picHat.Location = new System.Drawing.Point(451, 121);
            this.picHat.Name = "picHat";
            this.picHat.Size = new System.Drawing.Size(121, 106);
            this.picHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHat.TabIndex = 3;
            this.picHat.TabStop = false;
            // 
            // picShirt
            // 
            this.picShirt.BackColor = System.Drawing.Color.Transparent;
            this.picShirt.Location = new System.Drawing.Point(391, 284);
            this.picShirt.Name = "picShirt";
            this.picShirt.Size = new System.Drawing.Size(240, 120);
            this.picShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShirt.TabIndex = 2;
            this.picShirt.TabStop = false;
            // 
            // picPants
            // 
            this.picPants.BackColor = System.Drawing.Color.Transparent;
            this.picPants.Location = new System.Drawing.Point(401, 391);
            this.picPants.Name = "picPants";
            this.picPants.Size = new System.Drawing.Size(220, 187);
            this.picPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPants.TabIndex = 1;
            this.picPants.TabStop = false;
            // 
            // picShoes
            // 
            this.picShoes.BackColor = System.Drawing.Color.Transparent;
            this.picShoes.Location = new System.Drawing.Point(433, 562);
            this.picShoes.Name = "picShoes";
            this.picShoes.Size = new System.Drawing.Size(161, 147);
            this.picShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShoes.TabIndex = 0;
            this.picShoes.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(218, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Pay attention to Naufy\'s outfit!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormGame
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.textBox1);
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
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox1;
    }
}
