using System.Drawing;

namespace UserManagement
{
    partial class EditPage
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EditUsername;
        private TextBox EditPassword;
        private Button SubmitEdit;
        private Button button1;

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.EditUsername = new TextBox();
            this.EditPassword = new TextBox();
            this.SubmitEdit = new Button();
            this.button1 = new Button();
            this.SuspendLayout();

            // label1 (Edit User)
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(250, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(300, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit User";

            // label2 (Username)
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            this.label2.Location = new Point(200, 150);
            this.label2.Name = "label2";
            this.label2.Size = new Size(150, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Username";

            // label3 (Password)
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            this.label3.Location = new Point(200, 220);
            this.label3.Name = "label3";
            this.label3.Size = new Size(150, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Password";

            // EditUsername
            this.EditUsername.Location = new Point(380, 155);
            this.EditUsername.Name = "EditUsername";
            this.EditUsername.Size = new Size(200, 30);
            this.EditUsername.TabIndex = 3;

            // EditPassword
            this.EditPassword.Location = new Point(380, 225);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.Size = new Size(200, 30);
            this.EditPassword.UseSystemPasswordChar = true;

            // SubmitEdit
            this.SubmitEdit.Location = new Point(300, 300);
            this.SubmitEdit.Name = "SubmitEdit";
            this.SubmitEdit.Size = new Size(120, 40);
            this.SubmitEdit.TabIndex = 4;
            this.SubmitEdit.Text = "Submit";
            this.SubmitEdit.BackColor = Color.FromArgb(0, 123, 255);
            this.SubmitEdit.ForeColor = Color.White;
            this.SubmitEdit.Click += SubmitEdit_Click;

            // button1 (Back)
            this.button1.Location = new Point(450, 300);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.BackColor = Color.FromArgb(255, 69, 0);
            this.button1.ForeColor = Color.White;
            this.button1.Click += button1_Click;

            // EditPage
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SubmitEdit);
            this.Controls.Add(this.EditPassword);
            this.Controls.Add(this.EditUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPage";
            this.Text = "Edit Page";
            this.ResumeLayout(false);
        }
    }
}