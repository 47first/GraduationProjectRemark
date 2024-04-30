using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            pagesControl.TabPages.Remove(usersPage);

            if (AuthorizationService.Instance.IsAuthorized == false)
            {
                OpenAuthorizaitonForm();
            }
            else
            {
                pagesControl.Enabled = true;

                if (UserContext.Instance.CurrentUser.RoleId == 3)
                {
                    pagesControl.TabPages.Add(usersPage);
                }
            }
        }

        private void servicesPage_Enter(object sender, EventArgs e)
        {
            servicesPage1.UpdateData();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            AuthorizationService.Instance.Logout();

            pagesControl.TabPages.Remove(usersPage);

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

            if (UserContext.Instance.CurrentUser.RoleId == 3)
            {
                pagesControl.TabPages.Add(usersPage);
            }

            ShowInTaskbar = true;
            Opacity = 1;
            pagesControl.Enabled = true;

            Focus();
        }
    }
}
