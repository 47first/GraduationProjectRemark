using Database;
using Database.Entities;
using WinFormsApplication.Helpers;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class ServiceSetForm : Form
    {
        private int _serviceId;
        private ValidationForm _validationForm;

        public event Action<Service> ValidClick = delegate { };

        public ServiceSetForm(string title, string submit, Service service = null)
        {
            InitializeComponent();

            if (service is not null)
            {
                _serviceId = service.Id;
                nameTextBox.Text = service.Name;
                descriptionTextBox.Text = service.Description;
                amountTextBox.Text = service.Amount.ToString();
            }

            Text = title;
            titleLabel.Text = title;
            submitButton.Text = submit;

            foreach (var category in DatabaseContext.Instance.Categories)
            {
                var categoryItem = new CategoryItem()
                {
                    Id = category.Id,
                    Name = category.Name,
                };

                var createdIndex = categoryComboBox.Items.Add(categoryItem);

                if (service is not null && category.Id == service.CategoryId)
                {
                    categoryComboBox.SelectedIndex = createdIndex;
                }
            }

            var fileNames = ImageService.Instance.GetImagesList();

            foreach (var fileName in fileNames)
            {
                var createdIndex = imagesComboBox.Items.Add(fileName);

                if (service is not null && fileName == service.ImagePath)
                {
                    imagesComboBox.SelectedIndex = createdIndex;
                }
            }

            _validationForm = new ValidationForm();

            _validationForm.MakeBinding(nameTextBox, nameLabel,
                ExprHelper.StringLength(() => nameTextBox.Text, 5, 32));
            _validationForm.MakeBinding(descriptionTextBox, descriptionLabel,
                ExprHelper.StringLength(() => descriptionTextBox.Text, 5, 64));

            _validationForm.MakeBinding(amountTextBox, amountLabel,
                ExprHelper.NumberExpr(() => amountTextBox.Text, 0, 10000));
            _validationForm.MakeBinding(imagesComboBox, imageLabel,
                ExprHelper.StringLength(() => imagesComboBox.SelectedItem as string, 0, 64));

            _validationForm.MakeBinding(categoryComboBox, categoryLabel,
                () => categoryComboBox.SelectedItem is CategoryItem);
        }

        private void imagesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var fileName = imagesComboBox.SelectedItem as string;

            imageBox.Image = ImageService.Instance.GetImage(fileName);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (_validationForm.Verify(out string message) == false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = message;

                return;
            }

            ValidClick(new Service()
            {
                Id = _serviceId,
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text,
                Amount = int.Parse(amountTextBox.Text),
                ImagePath = imagesComboBox.SelectedItem as string,
                CategoryId = (categoryComboBox.SelectedItem as CategoryItem).Id,
            });
        }

        private class CategoryItem
        {
            public int Id { get; set; }

            public string Name { get; set; } = null!;

            public override string ToString()
            {
                return Name;
            }
        }
    }
}