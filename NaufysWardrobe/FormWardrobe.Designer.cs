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
            this.cmbHat.Location = new System.Drawing.Point(118, 251);
            this.cmbHat.Name = "cmbHat";
            this.cmbHat.Size = new System.Drawing.Size(150, 28);
            this.cmbHat.TabIndex = 0;
            this.cmbHat.SelectedIndexChanged += new System.EventHandler(this.cmbHat_SelectedIndexChanged);
            // 
            // cmbShirt
            // 
            this.cmbShirt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShirt.Location = new System.Drawing.Point(329, 251);
            this.cmbShirt.Name = "cmbShirt";
            this.cmbShirt.Size = new System.Drawing.Size(150, 28);
            this.cmbShirt.TabIndex = 1;
            this.cmbShirt.SelectedIndexChanged += new System.EventHandler(this.cmbShirt_SelectedIndexChanged);
            // 
            // cmbPants
            // 
            this.cmbPants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPants.Location = new System.Drawing.Point(550, 251);
            this.cmbPants.Name = "cmbPants";
            this.cmbPants.Size = new System.Drawing.Size(150, 28);
            this.cmbPants.TabIndex = 2;
            this.cmbPants.SelectedIndexChanged += new System.EventHandler(this.cmbPants_SelectedIndexChanged);
            // 
            // cmbShoes
            // 
            this.cmbShoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShoes.Location = new System.Drawing.Point(752, 251);
            this.cmbShoes.Name = "cmbShoes";
            this.cmbShoes.Size = new System.Drawing.Size(150, 28);
            this.cmbShoes.TabIndex = 3;
            this.cmbShoes.SelectedIndexChanged += new System.EventHandler(this.cmbShoes_SelectedIndexChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(900, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(103, 20);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Time left: 30s";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(460, 569);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 40);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // picSelectedHat
            // 
            this.picSelectedHat.Location = new System.Drawing.Point(130, 303);
            this.picSelectedHat.Name = "picSelectedHat";
            this.picSelectedHat.Size = new System.Drawing.Size(120, 120);
            this.picSelectedHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectedHat.TabIndex = 6;
            this.picSelectedHat.TabStop = false;
            // 
            // picSelectedShirt
            // 
            this.picSelectedShirt.Location = new System.Drawing.Point(344, 303);
            this.picSelectedShirt.Name = "picSelectedShirt";
            this.picSelectedShirt.Size = new System.Drawing.Size(120, 120);
            this.picSelectedShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectedShirt.TabIndex = 7;
            this.picSelectedShirt.TabStop = false;
            // 
            // picSelectedPants
            // 
            this.picSelectedPants.Location = new System.Drawing.Point(563, 303);
            this.picSelectedPants.Name = "picSelectedPants";
            this.picSelectedPants.Size = new System.Drawing.Size(120, 120);
            this.picSelectedPants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectedPants.TabIndex = 8;
            this.picSelectedPants.TabStop = false;
            // 
            // picSelectedShoes
            // 
            this.picSelectedShoes.Location = new System.Drawing.Point(771, 303);
            this.picSelectedShoes.Name = "picSelectedShoes";
            this.picSelectedShoes.Size = new System.Drawing.Size(120, 120);
            this.picSelectedShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectedShoes.TabIndex = 9;
            this.picSelectedShoes.TabStop = false;
            // 
            // FormWardrobe
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
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
            this.Name = "FormWardrobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Outfit";
            this.Load += new System.EventHandler(this.FormWardrobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedPants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedShoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
