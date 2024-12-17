using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
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

            this.picCharacterBaseOri.SuspendLayout();
            this.picCharacterBasePlayer.SuspendLayout();
            this.SuspendLayout();

            // Initialize and setup picCharacterBaseOri
            this.picCharacterBaseOri.BackColor = System.Drawing.Color.Transparent;
            this.picCharacterBaseOri.Location = new System.Drawing.Point(528, 118);
            this.picCharacterBaseOri.Name = "picCharacterBaseOri";
            this.picCharacterBaseOri.Size = new System.Drawing.Size(334, 432);
            this.picCharacterBaseOri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacterBaseOri.TabStop = false;

            // Initialize and setup picCharacterBasePlayer
            this.picCharacterBasePlayer.BackColor = System.Drawing.Color.Transparent;
            this.picCharacterBasePlayer.Location = new System.Drawing.Point(136, 118);
            this.picCharacterBasePlayer.Name = "picCharacterBasePlayer";
            this.picCharacterBasePlayer.Size = new System.Drawing.Size(334, 432);
            this.picCharacterBasePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacterBasePlayer.TabStop = false;

            // Setup picOriHat, picOriShirt, picOriPants, picOriShoes as children of picCharacterBaseOri
            this.picOriHat.Parent = this.picCharacterBaseOri;
            this.picOriHat.BackColor = System.Drawing.Color.Transparent;
            this.picOriHat.Location = new System.Drawing.Point(37, -48); // Position relative to parent
            this.picOriHat.Name = "picOriHat";
            this.picOriHat.Size = new System.Drawing.Size(260, 80);
            this.picOriHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriHat.TabStop = false;

            this.picOriShirt.Parent = this.picCharacterBaseOri;
            this.picOriShirt.BackColor = System.Drawing.Color.Transparent;
            this.picOriShirt.Location = new System.Drawing.Point(27, 102); // Position relative to parent
            this.picOriShirt.Name = "picOriShirt";
            this.picOriShirt.Size = new System.Drawing.Size(280, 140);
            this.picOriShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriShirt.TabStop = false;

            this.picOriPants.Parent = this.picCharacterBaseOri;
            this.picOriPants.BackColor = System.Drawing.Color.Transparent;
            this.picOriPants.Location = new System.Drawing.Point(84, 203); // Position relative to parent
            this.picOriPants.Name = "picOriPants";
            this.picOriPants.Size = new System.Drawing.Size(165, 179);
            this.picOriPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriPants.TabStop = false;

            this.picOriShoes.Parent = this.picCharacterBaseOri;
            this.picOriShoes.BackColor = System.Drawing.Color.Transparent;
            this.picOriShoes.Location = new System.Drawing.Point(37, 352); // Position relative to parent
            this.picOriShoes.Name = "picOriShoes";
            this.picOriShoes.Size = new System.Drawing.Size(260, 70);
            this.picOriShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriShoes.TabStop = false;

            // Setup picPlayerHat, picPlayerShirt, picPlayerPants, picPlayerShoes as children of picCharacterBasePlayer
            this.picPlayerHat.Parent = this.picCharacterBasePlayer;
            this.picPlayerHat.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerHat.Location = new System.Drawing.Point(37, -48); // Same relative positioning for consistency
            this.picPlayerHat.Name = "picPlayerHat";
            this.picPlayerHat.Size = new System.Drawing.Size(260, 80);
            this.picPlayerHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerHat.TabStop = false;

            this.picPlayerShirt.Parent = this.picCharacterBasePlayer;
            this.picPlayerShirt.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerShirt.Location = new System.Drawing.Point(27, 102); // Same relative positioning for consistency
            this.picPlayerShirt.Name = "picPlayerShirt";
            this.picPlayerShirt.Size = new System.Drawing.Size(280, 140);
            this.picPlayerShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerShirt.TabStop = false;

            this.picPlayerPants.Parent = this.picCharacterBasePlayer;
            this.picPlayerPants.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerPants.Location = new System.Drawing.Point(84, 203); // Same relative positioning for consistency
            this.picPlayerPants.Name = "picPlayerPants";
            this.picPlayerPants.Size = new System.Drawing.Size(165, 179);
            this.picPlayerPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerPants.TabStop = false;

            this.picPlayerShoes.Parent = this.picCharacterBasePlayer;
            this.picPlayerShoes.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerShoes.Location = new System.Drawing.Point(37, 352); // Same relative positioning for consistency
            this.picPlayerShoes.Name = "picPlayerShoes";
            this.picPlayerShoes.Size = new System.Drawing.Size(260, 70);
            this.picPlayerShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerShoes.TabStop = false;

            // lblScore setup
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(392, 600);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 32);
            this.lblScore.TabIndex = 10;

            // btnRestart setup
            this.btnRestart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(446, 660);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(109, 42);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);

            // Form settings
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.picCharacterBasePlayer);
            this.Controls.Add(this.picCharacterBaseOri);
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.FormResult_Load);

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
            this.picCharacterBaseOri.ResumeLayout(false);
            this.picCharacterBasePlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
