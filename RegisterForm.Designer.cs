using System.Drawing;

namespace UserManagement
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameRegister;
        private TextBox PasswordRegister;
        private Button SubmitRegistration;
        private Button BackButton;

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.UsernameRegister = new TextBox();
            this.PasswordRegister = new TextBox();
            this.SubmitRegistration = new Button();
            this.BackButton = new Button();
            this.SuspendLayout();

            // label1 (Register)
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(324, 86);
            this.label1.Name = "label1";
            this.label1.Size = new Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            this.label1.ForeColor = Color.FromArgb(0, 123, 255); // Use your preferred color

            // label2 (Input Username)
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            this.label2.Location = new Point(187, 158);
            this.label2.Name = "label2";
            this.label2.Size = new Size(150, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Username";
            this.label2.ForeColor = Color.FromArgb(0, 123, 255); // Use your preferred color

            // label3 (Input Password)
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            this.label3.Location = new Point(187, 223);
            this.label3.Name = "label3";
            this.label3.Size = new Size(144, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Password";
            this.label3.ForeColor = Color.FromArgb(0, 123, 255); // Use your preferred color

            // UsernameRegister
            this.UsernameRegister.Location = new Point(429, 163);
            this.UsernameRegister.Name = "UsernameRegister";
            this.UsernameRegister.Size = new Size(200, 23);
            this.UsernameRegister.TabIndex = 3;

            // PasswordRegister
            this.PasswordRegister.Location = new Point(429, 228);
            this.PasswordRegister.Name = "PasswordRegister";
            this.PasswordRegister.Size = new Size(200, 23);
            this.PasswordRegister.TabIndex = 4;
            this.PasswordRegister.UseSystemPasswordChar = true; // Optional: Use password char for password input

            // SubmitRegistration
            this.SubmitRegistration.Location = new Point(262, 298);
            this.SubmitRegistration.Name = "SubmitRegistration";
            this.SubmitRegistration.Size = new Size(100, 30);
            this.SubmitRegistration.TabIndex = 5;
            this.SubmitRegistration.Text = "Submit";
            this.SubmitRegistration.BackColor = Color.FromArgb(0, 123, 255); // Use your preferred color
            this.SubmitRegistration.ForeColor = Color.White; // Use your preferred color
            this.SubmitRegistration.Click += SubmitRegistration_Click;

            // BackButton
            this.BackButton.Location = new Point(415, 298);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new Size(100, 30);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.BackColor = Color.FromArgb(255, 69, 0); // Use your preferred color
            this.BackButton.ForeColor = Color.White; // Use your preferred color
            this.BackButton.Click += BackButton_Click;

            // RegisterForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubmitRegistration);
            this.Controls.Add(this.PasswordRegister);
            this.Controls.Add(this.UsernameRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}