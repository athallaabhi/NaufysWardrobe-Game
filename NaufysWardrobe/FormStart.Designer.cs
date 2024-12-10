namespace NaufysWardrobeWinForms
{
    partial class FormStart
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            // Center the button: 
            // 1024/2=512, 512-60=452 for X, 
            // 768/2=384, 384-25=359 for Y
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(452, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // Reattach the event handler:
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormStart
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnStart);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naufy's Wardrobe - Start";
            this.ResumeLayout(false);
        }
    }
}
