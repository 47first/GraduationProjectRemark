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

        public void UpdateData()
        {
            var isAdmin = UserContext.Instance.CurrentUser?.RoleId == 3;

            createButton.Visible = isAdmin;

            servicesContainer.Controls.Clear();

            using var dbContext = new DatabaseContext();

            var categories = dbContext.Categories.ToArray();

            foreach (var service in dbContext.Services.Where(x => x.IsDeleted == false))
            {
                var category = categories.First(x => x.Id == service.CategoryId);

                var serviceView = new ServiceView(
                    service.Id,
                    service.Name,
                    service.Description,
                    category.Name,
                    ImageService.Instance.GetImage(service.ImagePath),
                    UserContext.Instance.CurrentUser.RoleId == 1,
                    isAdmin,
                    isAdmin);

                serviceView.ServiceUpdated += () => UpdateData();

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

        private void createButton_Click(object sender, EventArgs e)
        {
            var setForm = new ServiceSetForm("Создать услугу", "Создать");

            using var dbContext = new DatabaseContext();

            setForm.ValidClick += (service) =>
            {
                dbContext.Services.Add(service);

                dbContext.SaveChanges();

                setForm.Close();

                UpdateData();
            };

            setForm.Show();
        }
    }
}
