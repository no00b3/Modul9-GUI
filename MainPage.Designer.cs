using System.Drawing;

namespace UserManagement
{
    partial class MainPage
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private Label label1;

        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.label1 = new Label();
            this.SuspendLayout();

            // button1
            this.button1.Location = new Point(362, 323);
            this.button1.Name = "button1";
            this.button1.Size = new Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Out";
            this.button1.BackColor = Color.FromArgb(0, 123, 255); // Use your preferred color
            this.button1.ForeColor = Color.White; // Use your preferred color
            this.button1.FlatStyle = FlatStyle.Flat; // Optional: Use FlatStyle.Flat for a modern look
            this.button1.FlatAppearance.BorderSize = 0; // Optional: Remove border

            this.button1.Click += new EventHandler(this.button1_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(250, 70);
            this.label1.Name = "label1";
            this.label1.Size = new Size(300, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER MANAGEMENT";
            this.label1.ForeColor = Color.FromArgb(255, 69, 0); // Use your preferred color

            // MainPage
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}