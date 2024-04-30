using Database;
using WinFormsApplication.Components;

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

            if (DatabaseContext.Instance.Requests.Any() == false)
            {
                requestsContainer.Controls.Add(notFoundLabel);

                notFoundLabel.Visible = true;

                return;
            }

            foreach (var request in DatabaseContext.Instance.Requests)
            {
                var requestView = new RequestView(request, true, false);

                requestsContainer.Controls.Add(requestView);
            }
        }
    }
}
