using Database;
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
            else
            {
                pagesControl.Enabled = true;

                UpdateVisiblePages();
            }
        }

        private void servicesPage_Enter(object sender, EventArgs e)
        {
            servicesPage1.UpdateData();
        }

        private void requestsPage_Enter(object sender, EventArgs e)
        {
            requestsPage1.UpdateData();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            AuthorizationService.Instance.Logout();

            OpenAuthorizaitonForm();
        }

        private void OpenAuthorizaitonForm()
        {
            pagesControl.Enabled = false;
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
            pagesControl.Enabled = true;

            UpdateVisiblePages();

            Focus();
        }

        private void UpdateVisiblePages()
        {
            pagesControl.TabPages.Clear();

            if (UserContext.Instance.CurrentUser.RoleId != 2)
            {
                pagesControl.TabPages.Add(servicesPage);

                servicesPage1.UpdateData();
            }

            pagesControl.TabPages.Add(requestsPage);

            requestsPage1.UpdateData();
        }
    }
}
