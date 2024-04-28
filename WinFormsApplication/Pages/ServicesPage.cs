using Database;
using WinFormsApplication.Components;

namespace WinFormsApplication.Pages
{
    public partial class ServicesPage : UserControl
    {
        public ServicesPage()
        {
            InitializeComponent();

            notFoundLabel.Parent?.Controls.Remove(notFoundLabel);
            notFoundLabel.Visible = false;
        }

        public void EnterPage()
        {
            using (var dbContext = new DatabaseContext())
            {
                servicesContainer.Controls.Clear();

                foreach (var service in dbContext.Services)
                {
                    var serviceView = new ServiceView(service.Name, service.Description);

                    servicesContainer.Controls.Add(serviceView);
                }

                if (servicesContainer.Controls.Count < 1)
                {
                    notFoundLabel.Visible = true;

                    servicesContainer.Controls.Add(notFoundLabel);
                }
                else
                {
                    notFoundLabel.Visible = false;
                }
            }
        }
    }
}
