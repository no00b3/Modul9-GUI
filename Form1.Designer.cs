using System.Drawing;

namespace UserManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameLogin;
        private TextBox PasswordLogin;
        private Button button1;
        private Button button2;

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.UsernameLogin = new TextBox();
            this.PasswordLogin = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.SuspendLayout();

            // label1 (Login)
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(300, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(200, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";

            // label2 (Username)
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            this.label2.Location = new Point(200, 150);
            this.label2.Name = "label2";
            this.label2.Size = new Size(100, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";

            // label3 (Password)
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            this.label3.Location = new Point(200, 200);
            this.label3.Name = "label3";
            this.label3.Size = new Size(100, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";

            // UsernameLogin
            this.UsernameLogin.Location = new Point(350, 150);
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.Size = new Size(200, 30);
            this.UsernameLogin.TabIndex = 3;

            // PasswordLogin
            this.PasswordLogin.Location = new Point(350, 200);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new Size(200, 30);
            this.PasswordLogin.UseSystemPasswordChar = true;

            // button1 (Register)
            this.button1.Location = new Point(250, 280);
            this.button1.Name = "button1";
            this.button1.Size = new Size(100, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.BackColor = Color.FromArgb(0, 123, 255);
            this.button1.ForeColor = Color.White;
            this.button1.Click += button1_Click;

            // button2 (Login)
            this.button2.Location = new Point(450, 280);
            this.button2.Name = "button2";
            this.button2.Size = new Size(100, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Login";
            this.button2.BackColor = Color.FromArgb(40, 167, 69);
            this.button2.ForeColor = Color.White;
            this.button2.Click += button2_Click;

            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.UsernameLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += Form1_Load;
            this.ResumeLayout(false);
        }
    }
}