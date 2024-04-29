namespace WinFormsApplication.Forms
{
    partial class RegistrationForm
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
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            middleNameTextBox = new TextBox();
            middleNameLabel = new Label();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            loginTextBox = new TextBox();
            loginLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            repeatPasswordTextBox = new TextBox();
            repeatPasswordLabel = new Label();
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
            titleLabel.Size = new Size(379, 43);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Регистрация";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 52);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(58, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Фамилия";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(12, 70);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(355, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 118);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(355, 23);
            nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 100);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Имя";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(12, 169);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(355, 23);
            middleNameTextBox.TabIndex = 7;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(12, 151);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(58, 15);
            middleNameLabel.TabIndex = 6;
            middleNameLabel.Text = "Отчество";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(12, 222);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(355, 23);
            phoneTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(12, 204);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(55, 15);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Телефон";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 278);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(355, 23);
            emailTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 260);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 15);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Почта";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 332);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(355, 23);
            loginTextBox.TabIndex = 13;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(12, 314);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(41, 15);
            loginLabel.TabIndex = 12;
            loginLabel.Text = "Логин";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 385);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(355, 23);
            passwordTextBox.TabIndex = 15;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 367);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Пароль";
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Location = new Point(12, 438);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(355, 23);
            repeatPasswordTextBox.TabIndex = 17;
            // 
            // repeatPasswordLabel
            // 
            repeatPasswordLabel.AutoSize = true;
            repeatPasswordLabel.Location = new Point(12, 420);
            repeatPasswordLabel.Name = "repeatPasswordLabel";
            repeatPasswordLabel.Size = new Size(109, 15);
            repeatPasswordLabel.TabIndex = 16;
            repeatPasswordLabel.Text = "Повторите пароль";
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(232, 511);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(135, 23);
            registrationButton.TabIndex = 18;
            registrationButton.Text = "Зарегистрироваться";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.OrangeRed;
            errorLabel.Location = new Point(15, 464);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(352, 44);
            errorLabel.TabIndex = 19;
            errorLabel.Text = "Не все даннные введены корректно, проверьте введенные данные";
            errorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 546);
            Controls.Add(errorLabel);
            Controls.Add(registrationButton);
            Controls.Add(repeatPasswordTextBox);
            Controls.Add(repeatPasswordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(middleNameTextBox);
            Controls.Add(middleNameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(titleLabel);
            MaximizeBox = false;
            MaximumSize = new Size(395, 585);
            MinimumSize = new Size(395, 585);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox middleNameTextBox;
        private Label middleNameLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox loginTextBox;
        private Label loginLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox repeatPasswordTextBox;
        private Label repeatPasswordLabel;
        private Button registrationButton;
        private Label errorLabel;
    }
}