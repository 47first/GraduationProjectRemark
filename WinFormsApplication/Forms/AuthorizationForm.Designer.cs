namespace WinFormsApplication.Forms
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            loginLabel = new Label();
            loginTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            registrationButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.RoyalBlue;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.ForeColor = SystemColors.Control;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(244, 43);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Авторизация";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(12, 54);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(40, 13);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginTextBox.Location = new Point(12, 70);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PlaceholderText = "Введите логин";
            loginTextBox.Size = new Size(220, 22);
            loginTextBox.TabIndex = 2;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(12, 104);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(47, 13);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordTextBox.Location = new Point(12, 120);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Введите пароль";
            passwordTextBox.Size = new Size(220, 22);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            loginButton.Location = new Point(157, 201);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            registrationButton.Location = new Point(12, 201);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(139, 23);
            registrationButton.TabIndex = 6;
            registrationButton.Text = "Зарегистрироваться";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.OrangeRed;
            errorLabel.Location = new Point(12, 145);
            errorLabel.MaximumSize = new Size(220, 53);
            errorLabel.MinimumSize = new Size(220, 53);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(220, 53);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "Неправильный логин или пароль\r\nВведите саобольный промокод\r\nМегамаркета начинаем\r\n";
            errorLabel.Visible = false;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 236);
            Controls.Add(errorLabel);
            Controls.Add(registrationButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Controls.Add(titleLabel);
            MaximizeBox = false;
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label loginLabel;
        private TextBox loginTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button registrationButton;
        private Label errorLabel;
    }
}