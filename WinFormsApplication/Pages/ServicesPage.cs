using Database;
using WinFormsApplication.Components;
using WinFormsApplication.Forms;
using WinFormsApplication.Services.Impl;

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
            var isAdmin = UserContext.Instance.CurrentUser?.RoleId == 3;

            using (var dbContext = new DatabaseContext())
            {
                servicesContainer.Controls.Clear();

                var categories = dbContext.Categories.ToArray();

                foreach (var service in dbContext.Services)
                {
                    var category = categories.First(x => x.Id == service.CategoryId);

                    var serviceView = new ServiceView(
                        ImageService.Instance.GetImage(service.ImagePath),
                        service.Name,
                        service.Description,
                        category.Name,
                        isAdmin);

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

        private void createButton_Click(object sender, EventArgs e)
        {
            var serviceForm = new ServiceSetForm();

            serviceForm.Show();

            serviceForm.ServicesUpdate += EnterPage;
        }
    }
}
