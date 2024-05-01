using Database;
using Database.Entities;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Components
{
    public partial class RequestView : UserControl
    {
        private int _requestId;

        public RequestView(Request request, bool canAppointSelf, bool canComplete)
        {
            _requestId = request.Id;

            InitializeComponent();

            using var dbContext = new DatabaseContext();

            var service = dbContext.Services.First(x => x.Id == request.ServiceId);
            var user = dbContext.Users.First(x => x.Id == request.UserId);
            var employee = request.EmployeeId is null ? null : dbContext.Employees.First(x => x.Id == request.EmployeeId);
            var employeeUser = employee is null ? null : dbContext.Users.First(x => x.Id == employee.UserId);

            serviceImageBox.Image = ImageService.Instance.GetImage(service.ImagePath);
            titleLabel.Text = service.Name;
            priceLabel.Text = string.Format(priceLabel.Text, request.Price);
            userNameLabel.Text = string.Format(userNameLabel.Text, GetFio(user));
            employeeLabelName.Text = string.Format(userNameLabel.Text, GetFio(employeeUser));
            createTimeLabel.Text = string.Format(createTimeLabel.Text, request.CreatedDate.ToString());
            endTimeLabel.Text = string.Format(endTimeLabel.Text, request.ServedDate.ToString());

            servicePeriodLabel.Text = string.Format(
                servicePeriodLabel.Text,
                request.ServiceStartDate.ToString(),
                request.ServiceEndDate.ToString());

            completedCheckBox.Checked = request.IsCompleted;

            appointButton.Visible = canAppointSelf && request.EmployeeId is null;

            completedCheckBox.Enabled = canComplete;
        }

        private string GetFio(User user)
        {
            if (user is null)
            {
                return "Не установлен";
            }

            return user.LastName + " " + user.FirstName + (user.MiddleName is null ? string.Empty : " " + user.MiddleName);
        }

        private void completedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var request = dbContext.Requests.First(x => x.Id == _requestId);

            request.IsCompleted = completedCheckBox.Checked;

            dbContext.SaveChanges();
        }
    }
}
