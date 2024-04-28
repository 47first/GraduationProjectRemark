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
                ShowInTaskbar = false;
                Opacity = 0;

                var authrozationForm = new AuthorizationForm();

                authrozationForm.Show();
                authrozationForm.FormClosed += OnAuthorizationFormClosed;
            }
        }

        private void OnAuthorizationFormClosed(object? sender, FormClosedEventArgs e)
        {
            ShowInTaskbar = true;
            Opacity = 1;

            Focus();
        }

        private void servicesPage_Enter(object sender, EventArgs e)
        {
            servicesPage1.EnterPage();
        }
    }
}
