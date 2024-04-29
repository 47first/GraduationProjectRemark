using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            if (AuthorizationService.Instance.IsAuthorized == false)
            {
                OpenAuthorizaitonForm();
            }
        }

        private void servicesPage_Enter(object sender, EventArgs e)
        {
            servicesPage1.EnterPage();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            AuthorizationService.Instance.Logout();

            OpenAuthorizaitonForm();
        }

        private void OpenAuthorizaitonForm()
        {
            ShowInTaskbar = false;
            Opacity = 0;

            var authrozationForm = new AuthorizationForm();

            authrozationForm.Show();
            authrozationForm.FormClosed += OnAuthorizationFormClosed;
        }

        private void OnAuthorizationFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (AuthorizationService.Instance.IsAuthorized == false)
            {
                Close();

                return;
            }

            ShowInTaskbar = true;
            Opacity = 1;

            Focus();
        }
    }
}
