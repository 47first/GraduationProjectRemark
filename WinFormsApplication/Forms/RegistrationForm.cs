using System.Text.RegularExpressions;
using Database;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class RegistrationForm : Form
    {
        private Dictionary<TextBox, Label> _bindings = new();

        public RegistrationForm()
        {
            InitializeComponent();

            MakeBinding(nameTextBox, nameLabel);
            MakeBinding(middleNameTextBox, middleNameLabel);
            MakeBinding(lastNameTextBox, lastNameLabel);
            MakeBinding(phoneTextBox, phoneLabel);
            MakeBinding(emailTextBox, emailLabel);
            MakeBinding(loginTextBox, loginLabel);
            MakeBinding(passwordTextBox, passwordLabel);
            MakeBinding(repeatPasswordTextBox, repeatPasswordLabel);
        }

        private void MakeBinding(TextBox textBox, Label label)
        {
            _bindings.Add(textBox, label);

            textBox.TextChanged += (s, e) => RemoveMark(textBox);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (VerifyInput() == false)
            {
                return;
            }

            using (var dbContext = new DatabaseContext())
            {
                dbContext.Users.Add(new()
                {
                    FirstName = nameTextBox.Text,
                    MiddleName = middleNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    Login = loginTextBox.Text,
                    Password = passwordTextBox.Text,
                    RoleId = 1
                });

                dbContext.SaveChanges();

                AuthorizationService.Instance.SignIn(loginTextBox.Text, passwordTextBox.Text, dbContext);
            }

            Close();
        }

        private bool VerifyInput()
        {
            var isValid = true;

            isValid = Verify(StringLengthExpr(nameTextBox.Text, 5, 64), nameTextBox) &
                      Verify(StringLengthExpr(middleNameTextBox.Text, 5, 64), middleNameTextBox) &
                      Verify(StringLengthExpr(lastNameTextBox.Text, 5, 64), lastNameTextBox) &
                      Verify(EmailExpr(emailTextBox.Text), emailTextBox) &
                      Verify(PhoneExpr(phoneTextBox.Text), phoneTextBox) &
                      Verify(StringLengthExpr(loginTextBox.Text, 3, 32), loginTextBox) &
                      Verify(StringLengthExpr(passwordTextBox.Text, 3, 32), passwordTextBox) &
                      Verify(() => string.IsNullOrEmpty(passwordTextBox.Text) == false &&
                                   repeatPasswordTextBox.Text == passwordTextBox.Text, repeatPasswordTextBox);

            errorLabel.Visible = isValid == false;

            return isValid;
        }

        private Func<bool> StringLengthExpr(string text, int minLength, int maxLength)
        {
            return () => text.Length > minLength && text.Length < maxLength;
        }

        private Regex _phoneRegex = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", RegexOptions.Compiled);
        private Func<bool> PhoneExpr(string phone)
        {
            return () => _phoneRegex.IsMatch(phone);
        }

        private Regex _emailRegex = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", RegexOptions.Compiled);
        private Func<bool> EmailExpr(string email)
        {
            return () => _emailRegex.IsMatch(email);
        }

        private bool Verify(Func<bool> predicate, TextBox textBox)
        {
            var isValid = predicate();

            if (isValid)
            {
                MarkAsValid(textBox);
            }
            else
            {
                MarkAsInvalid(textBox);
            }

            return isValid;
        }

        private void MarkAsInvalid(TextBox textBox)
        {
            var label = _bindings[textBox];

            textBox.ForeColor = Color.OrangeRed;

            label.ForeColor = Color.OrangeRed;
        }

        private void MarkAsValid(TextBox textBox)
        {
            var label = _bindings[textBox];

            textBox.ForeColor = Color.Green;

            label.ForeColor = Color.Green;
        }

        private void RemoveMark(TextBox textBox)
        {
            var label = _bindings[textBox];

            textBox.ForeColor = Color.Black;

            label.ForeColor = Color.Black;
        }
    }
}
