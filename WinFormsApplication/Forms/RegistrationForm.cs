using Database;
using WinFormsApplication.Helpers;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class RegistrationForm : Form
    {
        private ValidationForm _validationForm;

        public RegistrationForm()
        {
            InitializeComponent();

            _validationForm = new ValidationForm();

            _validationForm.MakeBinding(nameTextBox, nameLabel,
                ExprHelper.StringLength(() => nameTextBox.Text, 5, 64));
            _validationForm.MakeBinding(middleNameTextBox, middleNameLabel,
                ExprHelper.StringLength(() => middleNameTextBox.Text, 5, 64));
            _validationForm.MakeBinding(lastNameTextBox, lastNameLabel,
                ExprHelper.StringLength(() => lastNameTextBox.Text, 5, 64));

            _validationForm.MakeBinding(phoneTextBox, phoneLabel,
                ExprHelper.PhoneExpr(() => phoneTextBox.Text));
            _validationForm.MakeBinding(emailTextBox, emailLabel,
                ExprHelper.EmailExpr(() => emailTextBox.Text));

            _validationForm.MakeBinding(loginTextBox, loginLabel,
                ExprHelper.StringLength(() => loginTextBox.Text, 3, 32));
            _validationForm.MakeBinding(passwordTextBox, passwordLabel,
                ExprHelper.StringLength(() => passwordTextBox.Text, 3, 32));

            _validationForm.MakeBinding(repeatPasswordTextBox, repeatPasswordLabel,
                () => string.IsNullOrEmpty(repeatPasswordTextBox.Text) == false &&
                      repeatPasswordTextBox.Text == passwordTextBox.Text);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (_validationForm.Verify(out string message) == false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = message;

                return;
            }

            using var dbContext = new DatabaseContext();

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

            AuthorizationService.Instance.SignIn(
                loginTextBox.Text,
                passwordTextBox.Text,
                dbContext);

            Close();
        }
    }
}
