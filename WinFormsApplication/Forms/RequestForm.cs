using Database;
using Database.Entities;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class RequestForm : Form
    {
        private readonly string _priceLabelFormat;
        private Service _service;
        private bool _isOneTimePay;

        private readonly ValidationForm _validationForm;

        public RequestForm(Service service)
        {
            _validationForm = new();
            _service = service;
            _isOneTimePay = service.PaymentType is Database.Enums.PaymentType.OneTime;

            InitializeComponent();

            _priceLabelFormat = priceLabel.Text;

            serviceNameLabel.Text = string.Format(serviceNameLabel.Text, service.Name);
            serviceImageBox.Image = ImageService.Instance.GetImage(service.ImagePath);
            servicePaymentTypeLabel.Text = string.Format(servicePaymentTypeLabel.Text, EnumLocalizer.Instance.GetLocalizedEnum(service.PaymentType));
            startTimePicker.MinDate = DateTime.Now;
            endTimePicker.MinDate = DateTime.Now.AddHours(1);

            if (_isOneTimePay)
            {
                endTimeLabel.Visible = false;
                endTimePicker.Visible = false;
            }

            endTimePicker.Value = DateTime.Now.AddHours(1);
            startTimePicker.Value = DateTime.Now;

            _validationForm.MakeBinding(startTimePicker, startTimeLabel, VerifyRequestRange);

            _validationForm.MakeBinding(endTimePicker, endTimeLabel, VerifyRequestRange);

            priceLabel.Text = string.Format(_priceLabelFormat, CalculatePrice());
        }

        private bool VerifyRequestRange()
        {
            return startTimePicker.Value < endTimePicker.Value
                && (endTimePicker.Value - startTimePicker.Value) > TimeSpan.FromMinutes(15);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (_validationForm.Verify(out string message) == false)
            {
                return;
            }

            using var dbContext = new DatabaseContext();

            if (_isOneTimePay == false)
            {
                var inRangeRequest = dbContext.Requests.FirstOrDefault(x =>
                (startTimePicker.Value <= x.ServiceEndDate) && (x.ServiceStartDate <= endTimePicker.Value));

                if (inRangeRequest is not null)
                {
                    MessageBox.Show($"Выбранный вами период времени на данную услугу уже занят! Попробуйте выбрать другой диапазон времени.");

                    return;
                }
            }

            dbContext.Requests.Add(new Request()
            {
                UserId = UserContext.Instance.CurrentUser.Id,
                ServiceId = _service.Id,
                CreatedDate = DateTime.Now,
                ServiceStartDate = startTimePicker.Value,
                ServiceEndDate = _isOneTimePay ? startTimePicker.Value.AddMinutes(15) : endTimePicker.Value,
                Price = CalculatePrice(),
                IsCompleted = false
            });

            dbContext.SaveChanges();

            MessageBox.Show("Заявка успешно отправлена!");

            Close();
        }

        private decimal CalculatePrice()
        {
            if (_isOneTimePay)
            {
                return _service.Price;
            }

            var hours = (endTimePicker.Value - startTimePicker.Value).TotalHours;

            return Math.Ceiling((decimal)hours * _service.Price);
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = string.Format(_priceLabelFormat, CalculatePrice());
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = string.Format(_priceLabelFormat, CalculatePrice());
        }
    }
}
