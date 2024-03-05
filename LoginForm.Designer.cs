namespace PetShop
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            label2 = new Label();
            label3 = new Label();
            incorrectCredentialsTextBot = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(127, 45);
            label1.Name = "label1";
            label1.Size = new Size(89, 38);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Roboto", 14.25F);
            loginTextBox.Location = new Point(90, 160);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(162, 30);
            loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Cursor = Cursors.IBeam;
            passwordTextBox.Font = new Font("Roboto", 14.25F);
            passwordTextBox.Location = new Point(90, 241);
            passwordTextBox.MaxLength = 16;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "******";
            passwordTextBox.Size = new Size(162, 30);
            passwordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.Location = new Point(127, 369);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(81, 28);
            loginButton.TabIndex = 3;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(90, 138);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 4;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(90, 219);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // incorrectCredentialsTextBot
            // 
            incorrectCredentialsTextBot.AutoSize = true;
            incorrectCredentialsTextBot.BackColor = Color.Transparent;
            incorrectCredentialsTextBot.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incorrectCredentialsTextBot.ForeColor = Color.Red;
            incorrectCredentialsTextBot.Location = new Point(40, 98);
            incorrectCredentialsTextBot.Name = "incorrectCredentialsTextBot";
            incorrectCredentialsTextBot.Size = new Size(273, 19);
            incorrectCredentialsTextBot.TabIndex = 6;
            incorrectCredentialsTextBot.Text = "Неправильный логин и/или пароль";
            incorrectCredentialsTextBot.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tile_background;
            ClientSize = new Size(334, 446);
            Controls.Add(incorrectCredentialsTextBot);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label label2;
        private Label label3;
        private Label incorrectCredentialsTextBot;
    }
}
