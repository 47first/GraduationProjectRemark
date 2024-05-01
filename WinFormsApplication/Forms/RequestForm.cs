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

            //startTimePicker.MinDate = DateTime.Now;
            //endTimePicker.MinDate = DateTime.Now;

            //priceLabel.Text = string.Format(priceLabel.Text, request.Price);

            //using var dbContext = new DatabaseContext();

            //var service = dbContext.Services.First(x => x.Id == request.ServiceId);

            //serviceNameLabel.Text = string.Format(serviceNameLabel.Text, service.Name);
            //serviceImageBox.Image = ImageService.Instance.GetImage(service.ImagePath);
        }
    }
}
