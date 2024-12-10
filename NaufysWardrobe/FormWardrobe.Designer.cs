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
            // FormWardrobe
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Outfit";
            // Add load event
            this.Load += new System.EventHandler(this.FormWardrobe_Load);
            // 
            // Layout settings
            // 
            int topRowY = 50;
            int comboWidth = 150;
            int comboHeight = 30;
            int spacing = 30;

            this.cmbHat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHat.Location = new System.Drawing.Point(100, topRowY);
            this.cmbHat.Size = new System.Drawing.Size(comboWidth, comboHeight);
            // Add event
            this.cmbHat.SelectedIndexChanged += new System.EventHandler(this.cmbHat_SelectedIndexChanged);

            this.cmbShirt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShirt.Location = new System.Drawing.Point(100 + comboWidth + spacing, topRowY);
            this.cmbShirt.Size = new System.Drawing.Size(comboWidth, comboHeight);
            // Add event
            this.cmbShirt.SelectedIndexChanged += new System.EventHandler(this.cmbShirt_SelectedIndexChanged);

            this.cmbPants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPants.Location = new System.Drawing.Point(100 + (comboWidth + spacing) * 2, topRowY);
            this.cmbPants.Size = new System.Drawing.Size(comboWidth, comboHeight);
            // Add event
            this.cmbPants.SelectedIndexChanged += new System.EventHandler(this.cmbPants_SelectedIndexChanged);

            this.cmbShoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShoes.Location = new System.Drawing.Point(100 + (comboWidth + spacing) * 3, topRowY);
            this.cmbShoes.Size = new System.Drawing.Size(comboWidth, comboHeight);
            // Add event
            this.cmbShoes.SelectedIndexChanged += new System.EventHandler(this.cmbShoes_SelectedIndexChanged);

            this.lblTimer.Location = new System.Drawing.Point(900, 20);
            this.lblTimer.AutoSize = true;
            this.lblTimer.Text = "Time left: 30s";

            this.btnDone.Location = new System.Drawing.Point((1024 / 2) - 50, 700);
            this.btnDone.Size = new System.Drawing.Size(100, 40);
            this.btnDone.Text = "Done";
            // Add event if previously existed
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);

            int imgTop = 100 + comboHeight + 50; // beneath combos
            int imgSize = 120;

            this.picSelectedHat.Location = new System.Drawing.Point(100, imgTop);
            this.picSelectedHat.Size = new System.Drawing.Size(imgSize, imgSize);
            this.picSelectedHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picSelectedShirt.Location = new System.Drawing.Point(100 + (comboWidth + spacing), imgTop);
            this.picSelectedShirt.Size = new System.Drawing.Size(imgSize, imgSize);
            this.picSelectedShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picSelectedPants.Location = new System.Drawing.Point(100 + (comboWidth + spacing) * 2, imgTop);
            this.picSelectedPants.Size = new System.Drawing.Size(imgSize, imgSize);
            this.picSelectedPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picSelectedShoes.Location = new System.Drawing.Point(100 + (comboWidth + spacing) * 3, imgTop);
            this.picSelectedShoes.Size = new System.Drawing.Size(imgSize, imgSize);
            this.picSelectedShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

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

            ((System.ComponentModel.ISupportInitialize)(this.picSelectedHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
