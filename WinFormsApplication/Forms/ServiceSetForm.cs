using Database;
using Database.Entities;
using WinFormsApplication.Helpers;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class ServiceSetForm : Form
    {
        private ValidationForm _validationForm;

        public event Action ServicesUpdate = delegate { };

        public ServiceSetForm()
        {
            InitializeComponent();

            using var dbContext = new DatabaseContext();

            foreach (var category in dbContext.Categories)
            {
                var categoryItem = new CategoryItem()
                {
                    Id = category.Id,
                    Name = category.Name,
                };

                categoryComboBox.Items.Add(categoryItem);
            }

            var imageNames = ImageService.Instance.GetImagesList();

            imagesComboBox.Items.AddRange(imageNames.ToArray());

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

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            using var dbContext = new DatabaseContext();

            dbContext.Services.Add(new Service()
            {
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text,
                Amount = int.Parse(amountTextBox.Text),
                ImagePath = imagesComboBox.SelectedItem as string,
                CategoryId = (categoryComboBox.SelectedItem as CategoryItem).Id,
            });

            dbContext.SaveChanges();

            ServicesUpdate();

            Close();
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