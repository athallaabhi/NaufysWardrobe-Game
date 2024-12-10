namespace NaufysWardrobeWinForms
{
    partial class FormWardrobe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbHat;
        private System.Windows.Forms.ComboBox cmbShirt;
        private System.Windows.Forms.ComboBox cmbPants;
        private System.Windows.Forms.ComboBox cmbShoes;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnDone;

        private System.Windows.Forms.PictureBox picSelectedHat;
        private System.Windows.Forms.PictureBox picSelectedShirt;
        private System.Windows.Forms.PictureBox picSelectedPants;
        private System.Windows.Forms.PictureBox picSelectedShoes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbHat = new System.Windows.Forms.ComboBox();
            this.cmbShirt = new System.Windows.Forms.ComboBox();
            this.cmbPants = new System.Windows.Forms.ComboBox();
            this.cmbShoes = new System.Windows.Forms.ComboBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();

            this.picSelectedHat = new System.Windows.Forms.PictureBox();
            this.picSelectedShirt = new System.Windows.Forms.PictureBox();
            this.picSelectedPants = new System.Windows.Forms.PictureBox();
            this.picSelectedShoes = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.picSelectedHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedPants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShoes)).BeginInit();

            this.SuspendLayout();
            // 
            // cmbHat
            // 
            this.cmbHat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHat.Location = new System.Drawing.Point(30, 50);
            this.cmbHat.Name = "cmbHat";
            this.cmbHat.Size = new System.Drawing.Size(100, 21);
            this.cmbHat.SelectedIndexChanged += new System.EventHandler(this.cmbHat_SelectedIndexChanged);
            // 
            // picSelectedHat
            // 
            this.picSelectedHat.Location = new System.Drawing.Point(30, 80);
            this.picSelectedHat.Size = new System.Drawing.Size(100, 100);
            this.picSelectedHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // cmbShirt
            // 
            this.cmbShirt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShirt.Location = new System.Drawing.Point(150, 50);
            this.cmbShirt.Name = "cmbShirt";
            this.cmbShirt.Size = new System.Drawing.Size(100, 21);
            this.cmbShirt.SelectedIndexChanged += new System.EventHandler(this.cmbShirt_SelectedIndexChanged);
            // 
            // picSelectedShirt
            // 
            this.picSelectedShirt.Location = new System.Drawing.Point(150, 80);
            this.picSelectedShirt.Size = new System.Drawing.Size(100, 100);
            this.picSelectedShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // cmbPants
            // 
            this.cmbPants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPants.Location = new System.Drawing.Point(270, 50);
            this.cmbPants.Name = "cmbPants";
            this.cmbPants.Size = new System.Drawing.Size(100, 21);
            this.cmbPants.SelectedIndexChanged += new System.EventHandler(this.cmbPants_SelectedIndexChanged);
            // 
            // picSelectedPants
            // 
            this.picSelectedPants.Location = new System.Drawing.Point(270, 80);
            this.picSelectedPants.Size = new System.Drawing.Size(100, 100);
            this.picSelectedPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // cmbShoes
            // 
            this.cmbShoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShoes.Location = new System.Drawing.Point(390, 50);
            this.cmbShoes.Name = "cmbShoes";
            this.cmbShoes.Size = new System.Drawing.Size(100, 21);
            this.cmbShoes.SelectedIndexChanged += new System.EventHandler(this.cmbShoes_SelectedIndexChanged);
            // 
            // picSelectedShoes
            // 
            this.picSelectedShoes.Location = new System.Drawing.Point(390, 80);
            this.picSelectedShoes.Size = new System.Drawing.Size(100, 100);
            this.picSelectedShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // lblTimer
            // 
            this.lblTimer.Location = new System.Drawing.Point(400, 10);
            this.lblTimer.Size = new System.Drawing.Size(100, 20);
            this.lblTimer.Text = "Time left: 30s";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(230, 200);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 30);
            this.btnDone.Text = "Done";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);

            // 
            // FormWardrobe
            // 
            this.ClientSize = new System.Drawing.Size(520, 250);
            this.Controls.Add(this.cmbHat);
            this.Controls.Add(this.cmbShirt);
            this.Controls.Add(this.cmbPants);
            this.Controls.Add(this.cmbShoes);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnDone);

            this.Controls.Add(this.picSelectedHat);
            this.Controls.Add(this.picSelectedShirt);
            this.Controls.Add(this.picSelectedPants);
            this.Controls.Add(this.picSelectedShoes);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Outfit";
            this.Load += new System.EventHandler(this.FormWardrobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShoes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
