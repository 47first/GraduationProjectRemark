using Database;
using WinFormsApplication.Components;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Pages
{
    public partial class RequestsPage : UserControl
    {
        public RequestsPage()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            requestsContainer.Controls.Clear();

            using var dbContext = new DatabaseContext();

            if (dbContext.Requests.Any() == false)
            {
                requestsContainer.Controls.Add(notFoundLabel);

                notFoundLabel.Visible = true;

                return;
            }

            foreach (var request in dbContext.Requests)
            {
                var requestView = new RequestView(
                    request,
                    UserContext.Instance.CurrentUser.RoleId == 1,
                    UserContext.Instance.CurrentUser.RoleId > 0);

                requestsContainer.Controls.Add(requestView);
            }
        }
    }
}
