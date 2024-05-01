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

            var requests = UserContext.Instance.CurrentUser.RoleId == 1 ?
                dbContext.Requests.Where(x => x.UserId == UserContext.Instance.CurrentUser.Id) :
                dbContext.Requests;

            if (requests.Any() == false)
            {
                requestsContainer.Controls.Add(notFoundLabel);

                notFoundLabel.Visible = true;

                return;
            }

            foreach (var request in requests)
            {
                var requestView = new RequestView(
                    request,
                    UserContext.Instance.CurrentUser.RoleId == 2,
                    UserContext.Instance.CurrentUser.RoleId > 1);

                requestsContainer.Controls.Add(requestView);
            }
        }
    }
}
