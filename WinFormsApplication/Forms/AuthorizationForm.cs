using WinFormsApplication.Exceptions;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();

            AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizationService.Instance.SignIn(loginTextBox.Text, passwordTextBox.Text);

                Close();
            }
            catch (AuthorizationException ex)
            {
                errorLabel.Text = ex.Message;

                errorLabel.Visible = true;
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();

            ShowInTaskbar = false;
            Opacity = 0;

            registrationForm.FormClosed += OnRegistrationFormClosed;

            registrationForm.Show();
        }

        private void OnRegistrationFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (AuthorizationService.Instance.IsAuthorized)
            {
                Close();

                return;
            }

            ShowInTaskbar = true;
            Opacity = 1;
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
