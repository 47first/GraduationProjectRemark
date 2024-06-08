using System.ComponentModel;
using Database;
using Database.Entities;
using Database.Enums;
using Microsoft.EntityFrameworkCore.Update;
using WinFormsApplication.Helpers;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class ServiceSetForm : Form
    {
        private int _serviceId;
        private string _imagePath;
        private ValidationForm _validationForm;

        public event Action<Service> ValidClick = delegate { };

        public ServiceSetForm(string title, string submit, Service service = null)
        {
            InitializeComponent();

            if (service is not null)
            {
                _serviceId = service.Id;

                _imagePath = service.ImagePath;
                imageBox.Image = ImageService.Instance.GetImage(_imagePath);

                nameTextBox.Text = service.Name;
                descriptionTextBox.Text = service.Description;
                amountInput.Value = service.Amount;
                priceInput.Value = service.Price;
            }

            Text = title;
            titleLabel.Text = title;
            submitButton.Text = submit;

            using var dbContext = new DatabaseContext();

            foreach (var category in dbContext.Categories)
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

            foreach (PaymentType value in Enum.GetValues<PaymentType>())
            {
                var createdIndex = paymentTypeComboBox.Items.Add(new PaymentTypeItem()
                {
                    Value = value
                });

                if (service is not null && service.PaymentType == value)
                {
                    paymentTypeComboBox.SelectedIndex = createdIndex;
                }
            }

            _validationForm = new ValidationForm();

            _validationForm.MakeBinding(nameTextBox, nameLabel,
                ExprHelper.StringLength(() => nameTextBox.Text, 5, 32));
            _validationForm.MakeBinding(descriptionTextBox, descriptionLabel,
                ExprHelper.StringLength(() => descriptionTextBox.Text, 5, 64));

            _validationForm.MakeBinding(amountInput, amountLabel,
                ExprHelper.NumberExpr(() => amountInput.Value, 0, 100));

            _validationForm.MakeBinding(categoryComboBox, categoryLabel,
                () => categoryComboBox.SelectedItem is CategoryItem);

            _validationForm.MakeBinding(paymentTypeComboBox, paymentTypeLabel,
                () => paymentTypeComboBox.SelectedItem is PaymentTypeItem);

            _validationForm.MakeBinding(priceInput, priceLabel,
                ExprHelper.NumberExpr(() => priceInput.Value, 0, 10000000));
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
                Amount = (int)amountInput.Value,
                ImagePath = _imagePath,
                CategoryId = (categoryComboBox.SelectedItem as CategoryItem).Id,
                PaymentType = (paymentTypeComboBox.SelectedItem as PaymentTypeItem).Value,
                Price = priceInput.Value
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

        private class PaymentTypeItem
        {
            public PaymentType Value { get; set; }

            public override string ToString()
            {
                return EnumLocalizer.Instance.GetLocalizedEnum(Value);
            }
        }

        private void imageBox_DoubleClick(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _imagePath = ImageService.Instance.SaveImage(openFileDialog.FileName);

                imageBox.Image = ImageService.Instance.GetImage(_imagePath);
            }
        }
    }
}