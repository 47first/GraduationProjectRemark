using Database;
using Database.Entities;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class RequestForm : Form
    {
        private readonly ValidationForm _validationForm;

        public RequestForm(Service service)
        {
            InitializeComponent();

            serviceNameLabel.Text = string.Format(serviceNameLabel.Text, service.Name);
            serviceImageBox.Image = ImageService.Instance.GetImage(service.ImagePath);
            servicePaymentTypeLabel.Text = string.Format(servicePaymentTypeLabel.Text, EnumLocalizer.Instance.GetLocalizedEnum(service.PaymentType));
            startTimePicker.MinDate = DateTime.Now;
            endTimePicker.MinDate = DateTime.Now.AddHours(1);

            priceLabel.Text = string.Format(priceLabel.Text, service.Price);

            if (service.PaymentType is Database.Enums.PaymentType.OneTime)
            {
                endTimeLabel.Visible = false;
                endTimePicker.Visible = false;
            }

            using var dbContext = new DatabaseContext();
        }
    }
}
