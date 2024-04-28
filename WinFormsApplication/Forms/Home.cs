using Database;
using WinFormsApplication.Components;

namespace WinFormsApplication.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void servicesPage_Enter(object sender, EventArgs e)
        {
            using (var dbContext = new DatabaseContext())
            {
                foreach (var service in dbContext.Services)
                {
                    var serviceView = new ServiceView(service.Name, service.Description);

                    servicesContainer.Controls.Add(serviceView);
                }

                RecalculateServicesWidth();
            }
        }

        private void servicesContainer_SizeChanged(object sender, EventArgs e)
        {
            RecalculateServicesWidth();
        }

        private void RecalculateServicesWidth()
        {
            //foreach (ServiceView control in servicesContainer.Controls)
            //{
            //    control.Size = new()
            //    {
            //        Width = servicesContainer.Size.Width - servicesContainer.Padding.Left - servicesContainer.Padding.Right - 20,
            //        Height = control.Size.Height
            //    };
            //}
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            RecalculateServicesWidth();
        }
    }
}
