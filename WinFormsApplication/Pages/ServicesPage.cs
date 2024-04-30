﻿using Database;
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

            servicesContainer.Controls.Clear();

            var categories = DatabaseContext.Instance.Categories.ToArray();

            foreach (var service in DatabaseContext.Instance.Services)
            {
                var category = categories.First(x => x.Id == service.CategoryId);

                var serviceView = new ServiceView(
                    service.Id,
                    service.Name,
                    service.Description,
                    category.Name,
                    ImageService.Instance.GetImage(service.ImagePath),
                    true,
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

            setForm.ValidClick += (service) =>
            {
                DatabaseContext.Instance.Services.Add(service);

                DatabaseContext.Instance.SaveChanges();

                setForm.Close();

                UpdateData();
            };

            setForm.Show();
        }
    }
}
